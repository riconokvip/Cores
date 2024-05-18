namespace Cores.Exceptions
{
    public class BaseException : Exception
    {
        public ErrorCodes error { get; set; }
        public string message { get; set; }
        public HttpCodes httpCode { get; set; }

        public BaseException(ErrorCodes error, HttpCodes httpCode, string message)
        {
            this.error = error;
            this.message = message;
            this.httpCode = httpCode;
        }
    }
}
