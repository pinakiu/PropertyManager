using Microsoft.AspNetCore.Mvc;

namespace PropertyManager.Controllers;

[ApiController]
[Route("[controller]")]
public class PropertyController : Controller
{
    private readonly ILogger<PropertyController> _logger;

    public PropertyController(ILogger<PropertyController> logger)
    {
        _logger = logger;
    } 
    
    /// <summary>
    /// Gets information.
    /// </summary>
    /// <returns>Some Text</returns>
    [HttpGet("")]
    public async Task<IActionResult> Get()
    {
        const string text = "sup sup";
        
        return Ok(text);
    }

}