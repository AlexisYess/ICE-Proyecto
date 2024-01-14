using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICE.Control.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;

namespace ICE.Control.AccesoADatos
{
    public class CursoDAL
    {
        public static async Task<int> Crear(Curso pCurso)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pCurso);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Modificar(Curso pCurso)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var curso = await bdContexto.Curso.FirstOrDefaultAsync(c => c.Id == pCurso.Id);
                curso.Nombre = pCurso.Nombre;
           
                bdContexto.Update(curso);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Eliminar(Curso pCurso)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var curso = await bdContexto.Curso.FirstOrDefaultAsync(c => c.Id == pCurso.Id);
                bdContexto.Curso.Remove(curso);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<Curso> ObtenerPorId(Curso pCurso)
        {
            var curso = new Curso();
            using (var bdContexto = new BDContexto())
            {
                curso = await bdContexto.Curso.FirstOrDefaultAsync(c => c.Id == pCurso.Id);
            }
            return curso;
        }
        public static async Task<List<Curso>> ObtenerTodos()
        {
            var cursos = new List<Curso>();
            using (var bdContexto = new BDContexto())
            {
                cursos = await bdContexto.Curso.ToListAsync();
            }
            return cursos;
        }
        internal static IQueryable<Curso> QuerySelect(IQueryable<Curso> pQuery, Curso pCurso)
        {
            if (pCurso.Id > 0)
                pQuery = pQuery.Where(c => c.Id == pCurso.Id);
            if (!string.IsNullOrWhiteSpace(pCurso.Nombre))
                pQuery = pQuery.Where(c => c.Nombre.Contains(pCurso.Nombre));
            pQuery = pQuery.OrderByDescending(c => c.Id).AsQueryable();
           
            if (pCurso.Top_Aux > 0)
                pQuery = pQuery.Take(pCurso.Top_Aux).AsQueryable();
            return pQuery;
        }
        public static async Task<List<Curso>> Buscar(Curso pCurso)
        {
            var cursos = new List<Curso>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Curso.AsQueryable();
                select = QuerySelect(select, pCurso);
                cursos = await select.ToListAsync();
            }
            return cursos;
        }
    }
}
