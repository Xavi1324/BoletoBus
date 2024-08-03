namespace BoletoBus.Web.Models
{
    public class BaseGetResult<T> : BaseResult
    {
        public T data {  get; set; } 
    }
}
