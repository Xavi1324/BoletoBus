namespace BoletoBus.Web.Models.Reserva
{
    public class ReservaListGetResult
    {
        public bool success { get; set; }
        public string message { get; set; }
        public List<RervaGetModel> data { get; set; }
    }
}
