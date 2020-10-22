using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrackingCodingInterview.Core.Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrackingCodingInterview.Web.Controllers.v1
{
    [Route("api/v1")]
    public class BaseController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var response = new BaseResponse()
            {
                Success = true,
                Message = "Welcome to Cracking the Coding Interview Functions!"
            };

            return Ok(response);
        }

        
    }
}
