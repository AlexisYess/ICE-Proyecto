using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ICE.Control.EntidadesDeNegocio;
using ICE.Control.LogicaDeNegocios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ICE.UI.WebAspCore.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class GrupoController : Controller
    {
        GrupoBL grupoBL = new GrupoBL();
        // GET: GrupoController
        public async Task<IActionResult> Index(Grupo pGrupo = null)
        {
            if (pGrupo == null)
                pGrupo = new Grupo();
            if (pGrupo.Top_Aux == 0)
                pGrupo.Top_Aux = 10;
            else if (pGrupo.Top_Aux == -1)
                pGrupo.Top_Aux = 0;
            var grupos = await grupoBL.Buscar(pGrupo);
            ViewBag.Top = pGrupo.Top_Aux;
            return View(grupos);
        }

        // GET: GrupoController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var grupo = await grupoBL.ObtenerPorId(new Grupo { Id = id });
            return View(grupo);
        }

        // GET: GrupoController/Create
        public ActionResult Create()
        {
            ViewBag.Error = "";
            return View();
        }

        // POST: GrupoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Grupo pGrupo)
        {
            try
            {
                int result = await grupoBL.Crear(pGrupo);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pGrupo);
            }
        }

        // GET: GrupoController/Edit/5
        public async Task<IActionResult> Edit(Grupo pGrupo)
        {
            var grupo = await grupoBL.ObtenerPorId(pGrupo);
            ViewBag.Error = "";
            return View(grupo);
        }


        // POST: GrupoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Grupo pGrupo)
        {
            try
            {
                int result = await grupoBL.Modificar(pGrupo);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pGrupo);
            }
        }

        // GET: GrupoController/Delete/5
        public async Task<IActionResult> Delete(Grupo pGrupo)
        {
            ViewBag.Error = "";
            var grupo = await grupoBL.ObtenerPorId(pGrupo);
            return View(grupo);
        }


        // POST: GrupoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Grupo pGrupo)
        {
            try
            {
                int result = await grupoBL.Eliminar(pGrupo);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pGrupo);
            }
        }
    }
}
