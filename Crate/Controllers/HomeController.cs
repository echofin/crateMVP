using Microsoft.AspNetCore.Mvc;

namespace Crate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly MessageDbContext _messageDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MessageDbContext messageDbContext)
        {
            _logger = logger;
            _messageDbContext = messageDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var messagess = _messageDbContext.ChatMessages.ToArray();

            return Ok(messagess);
        }
    }
}