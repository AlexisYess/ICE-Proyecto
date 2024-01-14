using ICE.Control.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Control.AccesoADatos
{
    public class MatriculaDAL
    {
        public static async Task<int> Crear(Matricula pMatricula)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {  
                    //pMatricula.FechaInicio = DateTime.Now;
                    //pMatricula.FechaFinal = DateTime.Now;
                    bdContexto.Add(pMatricula);
                    result = await bdContexto.SaveChangesAsync();   
            }
            return result;
        }
        public static async Task<int> Modificar(Matricula pMatricula)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                 var matricula = await bdContexto.Matricula.FirstOrDefaultAsync(d => d.Id == pMatricula.Id);
                    matricula.IdDocente = pMatricula.IdDocente;
                matricula.IdCurso = pMatricula.IdCurso;
                matricula.IdGrupo = pMatricula.IdGrupo;
                matricula.Nombre = pMatricula.Nombre;
                    matricula.Apellido = pMatricula.Apellido;
                    matricula.Edad = pMatricula.Edad;
                    //matricula.Estatus = pMatricula.Estatus;
                matricula.FechaInicio = pMatricula.FechaInicio;
                matricula.FechaFinal = pMatricula.FechaFinal;
                bdContexto.Update(matricula);
                    result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Eliminar(Matricula pMatricula)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var matricula = await bdContexto.Matricula.FirstOrDefaultAsync(d => d.Id == pMatricula.Id);
                bdContexto.Matricula.Remove(matricula);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<Matricula> ObtenerPorId(Matricula pMatricula)
        {
            var matricula = new Matricula();
            using (var bdContexto = new BDContexto())
            {
                matricula = await bdContexto.Matricula.FirstOrDefaultAsync(d => d.Id == pMatricula.Id);
            }
            return matricula;
        }
        public static async Task<List<Matricula>> ObtenerTodos()
        {
            var matriculas = new List<Matricula>();
            using (var bdContexto = new BDContexto())
            {
                matriculas = await bdContexto.Matricula.ToListAsync();
            }
            return matriculas;
        }
        internal static IQueryable<Matricula> QuerySelect(IQueryable<Matricula> pQuery, Matricula pMatricula)
        {
            if (pMatricula.Id > 0)
                pQuery = pQuery.Where(d => d.Id == pMatricula.Id);
            if (pMatricula.IdDocente > 0)
                pQuery = pQuery.Where(d => d.IdDocente == pMatricula.IdDocente);
            if (pMatricula.IdGrupo > 0)
                pQuery = pQuery.Where(d => d.IdGrupo == pMatricula.IdGrupo);
            if (pMatricula.IdCurso > 0)
                pQuery = pQuery.Where(d => d.IdCurso == pMatricula.IdCurso);
            if (!string.IsNullOrWhiteSpace(pMatricula.Nombre))
                pQuery = pQuery.Where(d => d.Nombre.Contains(pMatricula.Nombre));
            if (!string.IsNullOrWhiteSpace(pMatricula.Apellido))
                pQuery = pQuery.Where(d => d.Apellido.Contains(pMatricula.Apellido));
            if (pMatricula.Edad > 0)
                pQuery = pQuery.Where(d => d.Edad == pMatricula.Edad);
            if (pMatricula.Estatus > 0)
                pQuery = pQuery.Where(s => s.Estatus == pMatricula.Estatus);

            if (pMatricula.FechaInicio.Year > 1000)
            {
                DateTime fechaInicial = new DateTime(pMatricula.FechaInicio.Year, pMatricula.FechaInicio.Month, pMatricula.FechaInicio.Day, 0, 0, 0);
                DateTime fechaFinal = fechaInicial.AddDays(1).AddMilliseconds(-1);
                pQuery = pQuery.Where(d => d.FechaInicio >= fechaInicial && d.FechaInicio <= fechaFinal);
            }

            if (pMatricula.FechaFinal.Year > 1000)
            {
                DateTime fechaInicial = new DateTime(pMatricula.FechaFinal.Year, pMatricula.FechaFinal.Month, pMatricula.FechaFinal.Day, 0, 0, 0);
                DateTime fechaFinal = fechaInicial.AddDays(1).AddMilliseconds(-1);
                pQuery = pQuery.Where(d => d.FechaFinal >= fechaInicial && d.FechaFinal <= fechaFinal);
            }

            pQuery = pQuery.OrderByDescending(d => d.Id).AsQueryable();
            if (pMatricula.Top_Aux > 0)
                pQuery = pQuery.Take(pMatricula.Top_Aux).AsQueryable();
            return pQuery;
        }
        public static async Task<List<Matricula>> Buscar(Matricula pMatricula)
        {
            var Matriculas = new List<Matricula>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Matricula.AsQueryable();
                select = QuerySelect(select, pMatricula);
                Matriculas = await select.ToListAsync();
            }
            return Matriculas;
        }

        public static async Task<List<Matricula>> BuscarIncluirDGCS(Matricula pMatricula)
        {
            var matriculas = new List<Matricula>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Matricula.AsQueryable();
                select = QuerySelect(select, pMatricula).Include(d => d.Docente).AsQueryable();

                //mas adelante cuando se completen las entidades
                select = QuerySelect(select, pMatricula).Include(g => g.Grupo).AsQueryable();
                select = QuerySelect(select, pMatricula).Include(c => c.Curso).AsQueryable();
                matriculas = await select.ToListAsync();
            }
            return matriculas;
        }

        public static async Task<int> Editar(Matricula pMatricula)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var matricula = await bdContexto.Matricula.FirstOrDefaultAsync(d => d.Id == pMatricula.Id);
               
                matricula.Nombre = pMatricula.Nombre;
                matricula.Apellido = pMatricula.Apellido;
                matricula.Edad = pMatricula.Edad;
                matricula.Estatus = pMatricula.Estatus;
               
                bdContexto.Update(matricula);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
    }
}
