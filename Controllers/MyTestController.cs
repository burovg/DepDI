using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTestController : ControllerBase
    {
        private readonly IMyBL _bl;

        public MyTestController(IMyBL mybl)
        {
            _bl = mybl;
        }

        [HttpGet]
        public int GetData()
        {
            return _bl.GetData();
        }
    }
}