using System;
using System.ComponentModel.DataAnnotations;

namespace CrackingCodingInterview.Core.API.Strings.Requests
{
    public class ReverseStringRequest
    {
        [Required(ErrorMessage = "Uh oh!  Please include a sentence in the body to be reversed.")]
        public string Reverse { get; set; }
    }
}
