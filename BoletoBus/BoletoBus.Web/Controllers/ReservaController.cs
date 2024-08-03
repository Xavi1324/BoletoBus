using BoletoBus.Web.Models.Reserva;
using Microsoft.AspNetCore.Mvc;
using BoletoBus.Web.HelpController;
using BoletoBus.Reserva.Application.Dtos;
using BoletoBus.Web.Links;
using Microsoft.Extensions.Options;

namespace BoletoBus.Web.Controllers
{
    public class ReservaController : Controller
    {
        private readonly BaseHelp baseHelp;
        private readonly ConfigUrl configUrl;
        public ReservaController(BaseHelp apiHelp, IOptions<ConfigUrl> options)
        {
            baseHelp = apiHelp;
            configUrl = options.Value;
        }
        // GET: ReservaController
        public async Task<ActionResult> Index()
        {
            var Response = await baseHelp.GetAsync<List<ReservaGetModelBase>>(configUrl.GetReserva);
            if (Response.Success)
            {
                return View(Response.data);
            }
            else
            {
                ModelState.AddModelError(string.Empty, Response.Message);
                return View(new List<ReservaGetModelBase>());
            }
        }
        // GET: ReservaController/Details/5
        public async Task<ActionResult> Details(int id)
        {

            var Response = await baseHelp.GetAsync<ReservaGetModelBase>(configUrl.GetReservabyId(id));
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

            var apiResponse = await baseHelp.PostAsync(configUrl.ReservaSave, reservaSaveModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(reservaSaveModel);
            }
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

            if (!ModelState.IsValid)
            {
                return View(reservaUpdateModel);
            }

            var apiResponse = await baseHelp.PostAsync(configUrl.ReservaUpdate(id), reservaUpdateModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(reservaUpdateModel);
            }
        }
    }
}
