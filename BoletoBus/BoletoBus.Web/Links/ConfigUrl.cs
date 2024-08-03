namespace BoletoBus.Web.Links
{
    public class ConfigUrl
    {
        public string ReservaBaseLink { get; set; }
        public string ReservaDetalleBaseLink { get; set; }
        public string RutaBaseLink { get; set; }
        public string ViajeBaseLink { get; set; }


        public string GetReserva => $"{ReservaBaseLink}/api/Reserva/GetReserva";
        public string GetReservabyId(int id) => $"{ReservaBaseLink}/api/Reserva/GetReservabyId?id={id}";
        public string ReservaSave => $"{ReservaBaseLink}/api/Reserva/SaveReserva";
        public string ReservaUpdate(int id) => $"{ReservaBaseLink}/api/Reserva/UpdateReserva?id={id}";


        public string GetReservaDetalle => $"{ReservaDetalleBaseLink}/api/ReservaDetalle/GetReservaDetalle";
        public string GetReservaDetallebyId(int id) => $"{ReservaDetalleBaseLink}/api/ReservaDetalle/GetReservaDetalleById?id={id}";
        public string ReservaDetalleSave => $"{ReservaDetalleBaseLink}/api/ReservaDetalle/SaverReservaDetalle";
        public string ReservaDetalleUpdate(int id) => $"{ReservaDetalleBaseLink}/api/ReservaDetalle/UpdateReservaDetalle?id={id}";


        public string GetRuta => $"{RutaBaseLink}/api/Ruta/GetRuta";
        public string GetRutabyId(int id) => $"{RutaBaseLink}/api/Ruta/GetRutaById?id={id}";
        public string RutaSave => $"{RutaBaseLink}/api/Ruta/SaveRuta";
        public string RutaUpdate(int id) => $"{RutaBaseLink}/api/Ruta/UpDateRuta?id={id}";


        public string GetViaje => $"{ViajeBaseLink}/api/Viaje/GetViaje";
        public string GetViajebyId(int id) => $"{ViajeBaseLink}/api/Viaje/GetViajeById?id={id}";
        public string ViajeSave => $"{ViajeBaseLink}/api/Viaje/SaveViaje";
        public string ViajeUpdate(int id) => $"{ViajeBaseLink}/api/Viaje/UpdateViaje?id={id}";
    }
}
