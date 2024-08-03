namespace BoletoBus.Web.HelpController
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public String Message { get; set; }
        public T data { get; set; }
    }
}
