# AspNetCore.HealthChecks

Use HealthCheck In Asp.NetCore web API

## Installation

Use the package manager [Nuget](https://pip.pypa.io/en/stable/) to install AspNetCore.HealthChecks

```bash
NuGet\Install-Package AspNetCore.HealthChecks.UI -Version 6.0.5
NuGet\Install-Package AspNetCore.HealthChecks.UI.Client -Version 6.0.5
NuGet\Install-Package AspNetCore.HealthChecks.UI.InMemory.Storage -Version 6.0.5
```

## Usage

```C#
import foobar

builder.Services.AddHealthChecks()

app.MapHealthChecks("/health");
```

## Description

Health Checks allow us to determine the overall health and availability of our application infrastructure. They are exposed as HTTP endpoints and can be configured to provide information for various monitoring scenarios, such as the response time and memory usage of our application, or whether our application can communicate with our database provider.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)
