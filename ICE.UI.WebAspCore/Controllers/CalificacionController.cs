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
    public class CalificacionController : Controller
    {
       

        CalificacionBL calificacionBL = new CalificacionBL();
        MatriculaBL matriculaBL = new MatriculaBL();
        // GET: CalificacionController
        public async Task<IActionResult> Index(Calificacion pCalificacion = null)
        {
            if (pCalificacion == null)
                pCalificacion = new Calificacion();
            if (pCalificacion.Top_Aux == 0)
                pCalificacion.Top_Aux = 10;
            else if (pCalificacion.Top_Aux == -1)
                pCalificacion.Top_Aux = 0;
            var taskBuscar = calificacionBL.BuscarIncluirMatriculas(pCalificacion);
            var taskObtenerTodosMatriculas = matriculaBL.ObtenerTodos();
            var calificacions = await taskBuscar;
            ViewBag.Top = pCalificacion.Top_Aux;
            ViewBag.Matriculas = await taskObtenerTodosMatriculas;
            return View(calificacions);
        }

        // GET: CalificacionController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var calificacion = await calificacionBL.ObtenerPorId(new Calificacion { Id = id });
            return View(calificacion);
        }

        // GET: CalificacionController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.matriculas = await matriculaBL.ObtenerTodos();

            ViewBag.Error = "";
            return View();
        }

        // POST: CalificacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Calificacion pCalificacion)
        {
           
            try
            {

                float prom = 0.0f;
             

                prom = (float)((pCalificacion.Word + pCalificacion.Excel + pCalificacion.PowerPoint + pCalificacion.
                    Access + pCalificacion.Publisher + pCalificacion.Photoshop + pCalificacion.CorelDraw + pCalificacion.Mantenimiento + pCalificacion.Redes) / (9.0f));
                pCalificacion.Promedio = prom;
           
                float result = await calificacionBL.Crear(pCalificacion);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.matriculas = await matriculaBL.ObtenerTodos();
                return View(pCalificacion);
            }
        }

        // GET: CalificacionController/Edit/5
        public async Task<IActionResult> Edit(Calificacion pCalificacion)
        {

            var taskObtenerPorId = calificacionBL.ObtenerPorId(pCalificacion);
            var taskObtenerTodosMatriculas = matriculaBL.ObtenerTodos();

            var calificacion = await taskObtenerPorId;
            ViewBag.Matriculas = await taskObtenerTodosMatriculas;
            ViewBag.Error = "";
            return View(calificacion);
        }

        // POST: CalificacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Calificacion pCalificacion)
        {
            try
            {
                float prom = 0.0f;


                prom = (float)((pCalificacion.Word + pCalificacion.Excel + pCalificacion.PowerPoint + pCalificacion.
                    Access + pCalificacion.Publisher + pCalificacion.Photoshop + pCalificacion.CorelDraw + pCalificacion.Mantenimiento + pCalificacion.Redes) / (9.0f));
                pCalificacion.Promedio = prom;

                int result = await calificacionBL.Modificar(pCalificacion);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Matriculas = await matriculaBL.ObtenerTodos();
                return View(pCalificacion);
            }
        }

        // GET: CalificacionController/Delete/5
        public async Task<IActionResult> Delete(Calificacion pCalificacion)
        {
             ViewBag.Error = "";
            var calificacion = await calificacionBL.ObtenerPorId(pCalificacion);
            return View(calificacion);
        }

        // POST: CalificacionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Calificacion pCalificacion)
        {
            try
            {
                int result = await calificacionBL.Eliminar(pCalificacion);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(pCalificacion);
            }
        }
    }
}
