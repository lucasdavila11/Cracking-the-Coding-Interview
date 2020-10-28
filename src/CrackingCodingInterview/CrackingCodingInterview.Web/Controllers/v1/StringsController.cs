using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrackingCodingInterview.Core.API.Strings.Requests;
using CrackingCodingInterview.Core.API.Strings.Responses;
using CrackingCodingInterview.Core.Common;
using CrackingCodingInterview.Services.Strings;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrackingCodingInterview.Web.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class StringsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get([FromBody] ReverseStringRequest request)
        {
            var response = new BaseResponse()
            {
                Success = true,
                Message = "Your sentence has been reversed!"
            };

            var stringResponse = new ReverseStringResponse()
            {
                Original = request.Reverse,
                Reversed = request.Reverse.ReverseString()
            };

            response.Result = stringResponse;

            return Ok(response);
        }

    }
}
