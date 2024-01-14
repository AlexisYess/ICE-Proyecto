using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICE.Control.EntidadesDeNegocio;
using ICE.Control.LogicaDeNegocios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ICE.UI.AppWebAspCore.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class DocenteController : Controller
    {
        DocenteBL docenteBL = new DocenteBL();
        // GET: DocenteController
        public async Task<IActionResult> Index(Docente pDocente = null)
        {
            if (pDocente == null)
                pDocente = new Docente();
            if (pDocente.Top_Aux == 0)
                pDocente.Top_Aux = 10;
            else if (pDocente.Top_Aux == -1)
                pDocente.Top_Aux = 0;
            var docentes = await docenteBL.Buscar(pDocente);
            ViewBag.Top = pDocente.Top_Aux;
            return View(docentes);
        }

        // GET: DocenteController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var docente = await docenteBL.ObtenerPorId(new Docente { Id = id });
            return View(docente);
        }

        // GET: DocenteController/Create
        public IActionResult Create()
        {
            ViewBag.Error = "";
            return View();
        }

        // POST: DocenteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Docente pDocente)
        {
            try
            {
                int result = await docenteBL.Crear(pDocente);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pDocente);
            }
        }

        // GET: DocenteController/Edit/5
        public async Task<IActionResult> Edit(Docente pDocente)
        {
            var docente = await docenteBL.ObtenerPorId(pDocente);
            ViewBag.Error = "";
            return View(docente);
        }

        // POST: DocenteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Docente pDocente)
        {
            try
            {
                int result = await docenteBL.Modificar(pDocente);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pDocente);
            }
        }

        // GET: DocenteController/Delete/5
        public async Task<IActionResult> Delete(Docente pDocente)
        {
            ViewBag.Error = "";
            var docente = await docenteBL.ObtenerPorId(pDocente);
            return View(docente);
        }

        // POST: DocenteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Docente pDocente)
        {
            try
            {
                int result = await docenteBL.Eliminar(pDocente);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pDocente);
            }
        }
    }
}