using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ICE.Control.EntidadesDeNegocio;
using ICE.Control.LogicaDeNegocios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ICE.UI.WebAspCore.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class MatriculaController : Controller
    {
        MatriculaBL matriculaBL = new MatriculaBL();
        DocenteBL docenteBL = new DocenteBL();
        CursoBL cursoBL = new CursoBL();
        GrupoBL grupoBL = new GrupoBL();


        //Agregar cursobl y grupobl
        // GET: MatriculaController
        public async Task<IActionResult> Index(Matricula pMatricula = null)
        {
            if (pMatricula == null)
                pMatricula = new Matricula();
            if (pMatricula.Top_Aux == 0)
                pMatricula.Top_Aux = 10;
            else if (pMatricula.Top_Aux == -1)
                pMatricula.Top_Aux = 0;
            var taskBuscar = matriculaBL.BuscarIncluirDGCS(pMatricula);
            var taskObtenerTodosDocentes = docenteBL.ObtenerTodos();
            var taskObtnerTodosGrupos = grupoBL.ObtenerTodos();
            var taskObtenerTodosCursos = cursoBL.ObtenerTodos();
            var matriculas = await taskBuscar;
            ViewBag.Top = pMatricula.Top_Aux;
            ViewBag.Docentes = await taskObtenerTodosDocentes;
            ViewBag.Cursos = await taskObtenerTodosCursos;
                ViewBag.Grupos = await taskObtnerTodosGrupos;
            return View(matriculas);
        }


        // GET: MatriculaController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var matricula = await matriculaBL.ObtenerPorId(new Matricula { Id = id });
            matricula.Docente = await docenteBL.ObtenerPorId(new Docente { Id = matricula.IdDocente });
            matricula.Curso = await cursoBL.ObtenerPorId(new Curso { Id = matricula.IdCurso });
            matricula.Grupo = await grupoBL.ObtenerPorId(new Grupo { Id = matricula.IdGrupo });
            //falta grupo y curso
            return View(matricula);
        }

        // GET: MatriculaController/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Docentes = await docenteBL.ObtenerTodos();
            ViewBag.Grupos = await grupoBL.ObtenerTodos();
            ViewBag.Cursos = await cursoBL.ObtenerTodos();
            ViewBag.Error = "";
            return View();
        }

        // POST: MatriculaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Matricula pMatricula)
        {
            try
            {
                
                int result = await matriculaBL.Crear(pMatricula);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Docentes = await docenteBL.ObtenerTodos();
                return View(pMatricula);
            }
        }

        // GET: MatriculaController/Edit/5
        public async Task<IActionResult> Edit(Matricula pMatricula)
        {
            var taskObtenerPorId = matriculaBL.ObtenerPorId(pMatricula);
            var taskObtenerTodosDocentes = docenteBL.ObtenerTodos();
            var taskObtenerTodosGrupos = grupoBL.ObtenerTodos();
            var taskObtenerTodosCursos = cursoBL.ObtenerTodos();
            var matricula = await taskObtenerPorId;
            ViewBag.Docentes = await taskObtenerTodosDocentes;
            ViewBag.Grupos = await taskObtenerTodosGrupos;
            ViewBag.Cursos = await taskObtenerTodosCursos;
            ViewBag.Error = "";
            return View(matricula);
        }

        // POST: MatriculaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Matricula pMatricula)
        {
            try
            {
                int result = await matriculaBL.Modificar(pMatricula);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Docentes = await docenteBL.ObtenerTodos();
                ViewBag.Docentes = await cursoBL.ObtenerTodos();
                ViewBag.Docentes = await grupoBL.ObtenerTodos();
                return View(pMatricula);
            }
        }

        // GET: MatriculaController/Delete/5
        public async Task<IActionResult> Delete(Matricula pMatricula)
        {
            var matricula = await matriculaBL.ObtenerPorId(pMatricula);
            matricula.Docente = await docenteBL.ObtenerPorId(new Docente { Id = matricula.IdDocente });
            matricula.Grupo = await grupoBL.ObtenerPorId(new Grupo { Id = matricula.IdGrupo });
            matricula.Curso = await cursoBL.ObtenerPorId(new Curso { Id = matricula.IdCurso });
            ViewBag.Error = "";
            return View(matricula);
        }

        // POST: MatriculaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Matricula pMatricula)
        {
            try
            {
                int result = await matriculaBL.Eliminar(pMatricula);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var matricula = await matriculaBL.ObtenerPorId(pMatricula);
                if (matricula == null)
                    matricula = new Matricula();
                if (matricula.Id > 0)
                    matricula.Docente = await docenteBL.ObtenerPorId(new Docente { Id = matricula.IdDocente });
                    matricula.Grupo = await grupoBL.ObtenerPorId(new Grupo { Id = matricula.IdGrupo });
                    matricula.Curso = await cursoBL.ObtenerPorId(new Curso { Id = matricula.IdCurso });
                return View(matricula);
            }
        }

        
        // GET: MatriculaController
        public async Task<IActionResult> Inicio(Matricula pMatricula = null)
        {

            if (pMatricula == null)
                pMatricula = new Matricula();
            if (pMatricula.Top_Aux == 0)
                pMatricula.Top_Aux = 10;
            else if (pMatricula.Top_Aux == -1)
                pMatricula.Top_Aux = 0;
            var taskBuscar = matriculaBL.BuscarIncluirDGCS(pMatricula);
            var matriculas = await taskBuscar;
            ViewBag.Top = pMatricula.Top_Aux;
            return View(matriculas);
        }

        // GET: MatriculaController/Detalle/
        public async Task<IActionResult> Detalle(int id)
        {
            var matricula = await matriculaBL.ObtenerPorId(new Matricula { Id = id });
            return View(matricula);
        }

        // GET: MatriculaController/Editar
        public async Task<IActionResult> Editar(Matricula pMatricula)
        {
            var taskObtenerPorId = matriculaBL.ObtenerPorId(pMatricula);
            var taskObtenerTodosDocentes = docenteBL.ObtenerTodos();
            var taskObtenerTodosGrupos = grupoBL.ObtenerTodos();
            var taskObtenerTodosCursos = cursoBL.ObtenerTodos();
            var matricula = await taskObtenerPorId;
            ViewBag.Docentes = await taskObtenerTodosDocentes;
            ViewBag.Grupos = await taskObtenerTodosGrupos;
            ViewBag.Cursos = await taskObtenerTodosCursos;
            ViewBag.Error = "";
            return View(matricula);
        }

        // POST: MatriculaController/Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, Matricula pMatricula)
        {
            try
            {
                int result = await matriculaBL.Editar(pMatricula);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Docentes = await docenteBL.ObtenerTodos();
                ViewBag.Docentes = await cursoBL.ObtenerTodos();
                ViewBag.Docentes = await grupoBL.ObtenerTodos();
                return View(pMatricula);
            }
        }
        //try
        //{
        //    int result = await matriculaBL.Modificar(pMatricula);
        //    return RedirectToAction(nameof(Index));
        //}
        //catch (Exception ex)
        //{
        //    ViewBag.Error = ex.Message;
        //    return View(pMatricula);
        //}
    }


    
}

    
