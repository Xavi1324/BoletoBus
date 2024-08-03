using BoletoBus.Reserva.Application.Dtos;
using BoletoBus.ReservaDetalle.Application.Dtos;
using BoletoBus.Web.HelpController;
using BoletoBus.Web.Models.Reserva;
using BoletoBus.Web.Models.ReservaDetalle;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBus.Web.Controllers
{
    public class ReservaDetalleController : Controller
    {
        private readonly BaseHelp baseHelp;
        public ReservaDetalleController()
        {
            this.baseHelp = baseHelp;
        }
        // GET: ReservaDetalleController
        public async  Task<ActionResult> Index()
        {
            var url = "http://localhost:5268/api/ReservaDetalle/GetReservaDetalle";
            var result = await baseHelp.GetApiResult<ReservaDetalleListGetResult>(url);
            if (result == null)
            {
                ViewBag.ErrorMessage = "Error al obtener los detalles de las reservas.";
                return View();
            }

            return View(result.data);
        }

        // GET: ReservaDetalleController/Details/5
        public async  Task<ActionResult> Details(int id)
        {
            var url = $"http://localhost:5268/api/ReservaDetalle/GetReservaDetalleById?id={id}";
            var result = await baseHelp.GetApiResult<ReservaDetalleGetResult>(url);
            if (result == null)
            {
                ViewBag.ErrorMessage = "Error al obtener los detalles de la reserva.";
                return View();
            }

            return View(result.data);
        }

        // GET: ReservaDetalleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaDetalleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ReservaDetalleSave reservaDetalleSave )
        {
            if (!ModelState.IsValid)
            {
                return View(reservaDetalleSave);
            }
            var url = "http://localhost:5268/api/ReservaDetalle/SaverReservaDetalle";
            var isSuccess = await baseHelp.PostsApiResult(url, reservaDetalleSave);
            if (!isSuccess)
            {
                ViewBag.ErrorMessage = "Error al guardar detalles reserva.";
                return View(reservaDetalleSave);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ReservaDetalleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservaDetalleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ReservaDetalleUpdate reservaDetalleUpdate)
        {
            if (id != reservaDetalleUpdate.IdReservaDetalle)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(reservaDetalleUpdate);
            }

            var url = $"http://localhost:5268/api/ReservaDetalle/UpdateReservaDetalle?id={id}";
            var isSuccess = await baseHelp.PostsApiResult(url, reservaDetalleUpdate, isPut: true);
            if (!isSuccess)
            {
                ViewBag.ErrorMessage = "Error al actualizar detalles reserva.";
                return View(reservaDetalleUpdate);
            }

            return RedirectToAction(nameof(Index));
        }

        
    }
}
