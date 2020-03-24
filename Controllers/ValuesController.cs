using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Buildit.Webcrawler.Models;
namespace Buildit.Webcrawler.Controllers
{
    [Route("crawl")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public Page Get()
        {
            return new Page();
        }
    }
}
