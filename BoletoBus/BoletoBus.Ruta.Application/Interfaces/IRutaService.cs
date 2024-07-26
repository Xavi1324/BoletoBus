using BoletoBus.Ruta.Application.Base;
using BoletoBus.Ruta.Application.Dtos;


namespace BoletoBus.Ruta.Application.Interfaces
{
    public interface IRutaService
    {
        ServiceResult GetRutas();
        ServiceResult GetRutas(int id);
        ServiceResult UpDateRutas(RutaUpdateModel rutaUpdateModel);
        ServiceResult DeleteRuta(RutaDeleteModel rutaDeleteModel);
        ServiceResult SaveRuta(RutaSaveModel rutaSaveModel);
    }
}
