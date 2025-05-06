using Dapr;
using Microsoft.AspNetCore.Mvc;

namespace AlertService.Controllers;

[ApiController]
[Route("[controller]")]
public class AlertController : ControllerBase
{
    [HttpPost("temperature")]
    [Topic("pubsub", "temperature")]
    public IActionResult HandleTemperature([FromBody] TemperatureReading reading)
    {
        Console.WriteLine($"Alerta recibida: {reading.Celsius}°C desde {reading.SensorId}");
        return Ok();
    }
}