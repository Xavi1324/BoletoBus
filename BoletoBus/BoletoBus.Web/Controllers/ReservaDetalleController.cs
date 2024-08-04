using BoletoBus.ReservaDetalle.Application.Dtos;
using BoletoBus.Web.HelpController;
using BoletoBus.Web.Links;
using BoletoBus.Web.Models.ReservaDetalle;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BoletoBus.Web.Controllers
{
    public class ReservaDetalleController : Controller
    {
        private readonly BaseHelp baseHelp;
        private readonly ConfigUrl configUrl;
        public ReservaDetalleController(BaseHelp apiHelp, IOptions<ConfigUrl> options)
        {
            baseHelp = apiHelp;
            configUrl = options.Value;
        }
        
        // GET: ReservaDetalleController
        public async  Task<ActionResult> Index()
        {


            var Response = await baseHelp.GetAsync<List<ReservaDetalleGetModelBase>>(configUrl.GetReservaDetalle);
            if (Response.Success)
            {
                return View(Response.data);
            }
            else
            {
                ModelState.AddModelError(string.Empty, Response.Message);
                return View(new List<ReservaDetalleGetModelBase>());
            }
        }

        // GET: ReservaDetalleController/Details/5
        public async  Task<ActionResult> Details(int id)
        {
            var Response = await baseHelp.GetAsync<ReservaDetalleGetModelBase>(configUrl.GetReservaDetallebyId(id));
            if (Response.Success)
            {
                return View(Response.data);
            }
            else
            {
                ModelState.AddModelError(string.Empty, Response.Message);
                return NotFound();
            }
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

            var apiResponse = await baseHelp.PostAsync(configUrl.ReservaDetalleSave, reservaDetalleSave);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(reservaDetalleSave);
            }
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


            if (!ModelState.IsValid)
            {
                return View(reservaDetalleUpdate);
            }
            var apiResponse = await baseHelp.PostAsync(configUrl.ReservaDetalleUpdate(id), reservaDetalleUpdate);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(reservaDetalleUpdate);
            }
        }

        
    }
}
