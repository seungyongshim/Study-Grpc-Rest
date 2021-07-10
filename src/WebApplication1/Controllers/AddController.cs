using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly ILogger<AddController> Logger;

        public AddController(ILogger<AddController> logger)
        {
            Logger = logger;
        }

        [HttpPost]
        public async Task<Dto.AddRes> Post(Dto.AddReq req)
        {
            return await Task.FromResult(new Dto.AddRes
            {
                Result = req.A + req.B
            });
        }
    }
}
