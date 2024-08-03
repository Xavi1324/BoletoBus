using BoletoBus.Ruta.Application.Dtos;
using BoletoBus.Web.HelpController;
using BoletoBus.Web.Links;
using BoletoBus.Web.Models.Ruta;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BoletoBus.Web.Controllers
{
    public class RutaController : Controller
    {
        private readonly BaseHelp baseHelp;
        private readonly ConfigUrl configUrl;
        public RutaController(BaseHelp apiHelp, IOptions<ConfigUrl> options)
        {
            baseHelp = apiHelp;
            configUrl = options.Value;
        }
        // GET: RutaController
        public async Task<ActionResult> Index()
        {
            var Response = await baseHelp.GetAsync<List<RutaGetModelBase>>(configUrl.GetRuta);
            if (Response.Success)
            {
                return View(Response.data);
            }
            else
            {
                ModelState.AddModelError(string.Empty, Response.Message);
                return View(new List<RutaGetModelBase>());
            }
        }

        // GET: RutaController/Details/5
        public async  Task<ActionResult> Details(int id)
        {
            var Response = await baseHelp.GetAsync<RutaGetModelBase>(configUrl.GetRutabyId(id));
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

        // GET: RutaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RutaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RutaSaveModel rutaSaveModel)
        {
            if (!ModelState.IsValid)
            {
                return View(rutaSaveModel);
            }

            var apiResponse = await baseHelp.PostAsync(configUrl.RutaSave, rutaSaveModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(rutaSaveModel);
            }
        }

        // GET: RutaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RutaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Edit(int id, RutaUpdateModel rutaUpdateModel)
        {
            if (!ModelState.IsValid)
            {
                return View(rutaUpdateModel);
            }

            var apiResponse = await baseHelp.PostAsync(configUrl.RutaUpdate(id), rutaUpdateModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(rutaUpdateModel);
            }
        }
    }
}
