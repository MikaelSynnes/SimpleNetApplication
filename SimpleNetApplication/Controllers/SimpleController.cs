using Microsoft.AspNetCore.Mvc;
using SimpleNetApplication.Contracts.Models;
using SimpleNetApplication.Managers;

namespace SimpleNetApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class SimpleController : ControllerBase
    {

        private readonly ILogger<SimpleController> _logger;
        private readonly ISimpleManager _manager;

        public SimpleController(ILogger<SimpleController> logger, ISimpleManager manager)
        {
            _logger = logger;
            _manager = manager;
        }
        [HttpPost("Add")]
        public ActionResult<SimpleAddResponse> Add(SimpleAddRequest request)
        {
            try
            {
                return Ok(_manager.Add(request.Model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("Get")]
        public ActionResult<SimpleGetAllResponse> Get() //Request not used currently. Might be used in future to add params to request.
        {
            try
            {
                return Ok(_manager.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public bool Ping()
        {
            return true;
        }
    }
}
