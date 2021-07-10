using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
        private readonly ILogger<CalcController> Logger;

        public CalcController(ILogger<CalcController> logger)
        {
            Logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<Dto.CalcRes>> Post(Dto.CalcReq req)
        {
            return new Dto.CalcRes
            {
                Result = req.A + req.B
            };
        }
    }
}
