using BoletoBus.Web.Models.Reserva;
using Microsoft.AspNetCore.Mvc;
using BoletoBus.Web.HelpController;
using BoletoBus.Reserva.Application.Dtos;

namespace BoletoBus.Web.Controllers
{
    public class ReservaController : Controller
    {
        private readonly BaseHelp baseHelp;

        public ReservaController(BaseHelp baseHelp)
        {
            this.baseHelp = baseHelp;
        }
        // GET: ReservaController
        public async Task<ActionResult> Index()
        {
            var url = "http://localhost:5089/api/Reserva/GetReserva";
            var result = await baseHelp.GetApiResult<ReservaListGetResult>(url);
            if (result == null)
            {
                ViewBag.ErrorMessage = "Error al obtener los datos de las Reservas.";
                return View();
            }

            return View(result.data); //?? new List<ReservaGetModelBase>());
        }
        // GET: ReservaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var url = $"http://localhost:5089/api/Reserva/GetReservabyId?id={id}";
            var result = await baseHelp.GetApiResult<ReservaGetResult>(url);
            if (result == null)
            {
                ViewBag.ErrorMessage = "Error al obtener los datos de la reserva.";
                return View();
            }

            return View(result.data);
        }

        // GET: ReservaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ReservaSaveModel reservaSaveModel)
        {

            if (!ModelState.IsValid)
            {
                return View(reservaSaveModel);
            }
            var url = "http://localhost:5089/api/Reserva/SaveReserva";
            var isSuccess = await baseHelp.PostsApiResult(url, reservaSaveModel);
            if (!isSuccess)
            {
                ViewBag.ErrorMessage = "Error al guardar esta reserva.";
                return View(reservaSaveModel);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ReservaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ReservaUpdateModel reservaUpdateModel)
        {
            if (id != reservaUpdateModel.IdReserva)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(reservaUpdateModel);
            }
        
            var url = $"http://localhost:5089/api/Reserva/UpdateReserva?id={id}";
            var isSuccess = await baseHelp.PostsApiResult(url, reservaUpdateModel, isPut: true);
            if (!isSuccess)
            {
                ViewBag.ErrorMessage = "Error al actualizar la reserva.";
                return View(reservaUpdateModel);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
