using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace HelloWorld;

public class HelloWorldFunction
{
    private readonly ILogger<HelloWorldFunction> _logger;

    public HelloWorldFunction(ILogger<HelloWorldFunction> logger)
    {
        _logger = logger;
    }

    [Function("HelloWorld")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "helloworld")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
