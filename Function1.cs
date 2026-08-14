using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CoffeeAndChill;

public class CoffeeNChillTest
{
    private readonly ILogger<CoffeeNChillTest> _logger;

    public CoffeeNChillTest(ILogger<CoffeeNChillTest> logger)
    {
        _logger = logger;
    }

    [Function("CoffeeNChillTest")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("CoffeeNChillTestA is Running");
    }
}

