## Overview

SensorAppAspireWithDapr is a project designed to demonstrate the integration of Aspire with a sensor application. 

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Aspire CLI]([https://aspire-docs-lin](https://learn.microsoft.com/en-us/dotnet/aspire/)k)
- [Dapr](https://dapr.io)
- Docker (optional, for containerized deployment)

## Testing the Application

1. **Send a POST Request**:
    Use a tool like `curl` or Postman to send a POST request to the application:
    ```bash
    curl -X POST http://localhost:5000/sensor-data \
    -H "Content-Type: application/json" \
    -d '{"sensorId": "123", "value": 42}'
    ```

2. **Verify the Response**:
    Ensure the application processes the data and returns the expected response in the Aspìre dashboard.