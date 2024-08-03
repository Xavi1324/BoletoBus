namespace BoletoBus.Web.Models
{
    public class BaseListGetResult<t> : BaseResult
    {
        public List<t> data { get; set; }
    }
}
