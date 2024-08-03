using BoletoBus.Viaje.Application.Dtos;
using BoletoBus.Web.HelpController;
using BoletoBus.Web.Links;
using BoletoBus.Web.Models.Viaje;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BoletoBus.Web.Controllers
{
    public class ViajeController : Controller
    {
        private readonly BaseHelp baseHelp;
        private readonly ConfigUrl configUrl;
        public ViajeController(BaseHelp apiHelp, IOptions<ConfigUrl> options)
        {
            baseHelp = apiHelp;
            configUrl = options.Value;
        }
        // GET: ViajeController
        public async  Task<ActionResult> Index()
        {
            var Response = await baseHelp.GetAsync<List<ViajeGetModelBase>>(configUrl.GetViaje);
            if (Response.Success)
            {
                return View(Response.data);
            }
            else
            {
                ModelState.AddModelError(string.Empty, Response.Message);
                return View(new List<ViajeGetModelBase>());
            }
        }

        // GET: ViajeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var Response = await baseHelp.GetAsync<ViajeGetModelBase>(configUrl.GetViajebyId(id));
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

        // GET: ViajeController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: ViajeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ViajeSaveModel viajeSaveModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viajeSaveModel);
            }

            var apiResponse = await baseHelp.PostAsync(configUrl.ViajeSave, viajeSaveModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(viajeSaveModel);
            }
        }

        // GET: ViajeController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: ViajeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ViajeUpdateModel  viajeUpdateModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viajeUpdateModel);
            }

            var apiResponse = await baseHelp.PostAsync(configUrl.ViajeUpdate(id), viajeUpdateModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(viajeUpdateModel);
            }
        }
    }
}
