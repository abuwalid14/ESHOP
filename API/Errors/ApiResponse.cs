using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(StatusCode);
        }


        public int StatusCode { get; set; }
        public string Message{ get; set;}


        
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return StatusCode switch{
                    400 => "A bad request, you have made",
                    401 => " You are Not Authorized",
                    404 => "The Resource Was Not Found",
                    500 => "An Error Occured during the request",
                    _ => null
                    };
        }
    }
}