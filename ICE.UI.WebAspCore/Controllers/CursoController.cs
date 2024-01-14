using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ICE.Control.LogicaDeNegocios;
using ICE.Control.EntidadesDeNegocio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ICE.UI.WebAspCore.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class CursoController : Controller
    {
        CursoBL cursoBL = new CursoBL();
        // GET: CursosController
        public async Task<IActionResult> Index(Curso pCurso = null)
        {

            if (pCurso == null)
                pCurso = new Curso();
            if (pCurso.Top_Aux == 0)
                pCurso.Top_Aux = 10;
            else if (pCurso.Top_Aux == -1)
                pCurso.Top_Aux = 0;
            var cursos = await cursoBL.Buscar(pCurso);
            ViewBag.Top = pCurso.Top_Aux;
            return View(cursos);
        }


        // GET: CursoController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var curso = await cursoBL.ObtenerPorId(new Curso { Id = id });
            return View(curso);
        }

        // GET: CursoController/Create
        public IActionResult Create()
        {
            ViewBag.Error = "";
            return View();
        }

        // POST: CursoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Curso pCurso)
        {
            try
            {
                int result = await cursoBL.Crear(pCurso);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pCurso);
            }
        }

        // GET: CursoController/Edit/5
        public async Task<IActionResult> Edit(Curso pCurso)
        {
            var curso = await cursoBL.ObtenerPorId(pCurso);
            ViewBag.Error = "";
            return View(curso);
        }

        // POST: CursoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Curso pCurso)
        {
            try
            {
                int result = await cursoBL.Modificar(pCurso);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pCurso);
            }
        }

        // GET: CursoController/Delete/5
        public async Task<IActionResult> Delete(Curso pCurso)
        {
            ViewBag.Error = "";
            var docente = await cursoBL.ObtenerPorId(pCurso);
            return View(docente);
        }

        // POST: CursoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Curso pCurso)
        {
            try
            {
                int result = await cursoBL.Eliminar(pCurso);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pCurso);
            }
        }
    }
}
