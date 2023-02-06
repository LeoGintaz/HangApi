using Microsoft.AspNetCore.Mvc;

namespace HangApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordsControler : ControllerBase
    {
       

        private readonly ILogger<WordsControler> _logger;

        public WordsControler(ILogger<WordsControler> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}