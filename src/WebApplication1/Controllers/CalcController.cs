using System.Threading.Tasks;
using LanguageExt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
        private CalcService AddService { get; }

        private readonly ILogger<CalcController> Logger;

        public CalcController(ILogger<CalcController> logger, CalcService addService)
        {
            Logger = logger;
            AddService = addService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Dto.CalcReq req) =>
            this.Ok(
                from x in AddService.Add(new AddQuery(req.A, req.B))
                from y in AddService.Sub((req.A, req.B))
                from z in AddService.Except(y)
                select new
                {
                    Add = x.Result,
                    Sub = y,
                });
    }
}
}
