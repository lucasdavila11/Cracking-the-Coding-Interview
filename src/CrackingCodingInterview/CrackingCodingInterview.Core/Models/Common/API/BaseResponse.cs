using System;
namespace CrackingCodingInterview.Core.Common
{
    public class BaseResponse
    {
        public string Language { get; set; } = "en";
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Result { get; set; } = null;
    }
}
