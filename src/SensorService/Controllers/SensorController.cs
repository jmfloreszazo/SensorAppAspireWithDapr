using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace SensorService.Controllers;

[ApiController]
[Route("[controller]")]
public class SensorController(DaprClient daprClient, ILogger<SensorController> logger) : ControllerBase
{
    [HttpPost("send")]
    public async Task<IActionResult> Send([FromBody] TemperatureReading reading)
    {
        await daprClient.PublishEventAsync("pubsub", "temperature", reading);
        logger.LogInformation("Publicado: {Celsius}°C desde {Id}", reading.Celsius, reading.SensorId);
        return Ok();
    }
}