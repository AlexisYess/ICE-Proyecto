using ICE.Control.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Control.AccesoADatos
{
    public class DocenteDAL
    {
        public static async Task<int> Crear(Docente pDocente)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pDocente);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Modificar(Docente pDocente)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var docente = await bdContexto.Docente.FirstOrDefaultAsync(d => d.Id == pDocente.Id);
                docente.Nombre = pDocente.Nombre;
                docente.Apellido = pDocente.Apellido;
                docente.Telefono = pDocente.Telefono;
                bdContexto.Update(docente);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Eliminar(Docente pDocente)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var docente = await bdContexto.Docente.FirstOrDefaultAsync(d => d.Id == pDocente.Id);
                bdContexto.Docente.Remove(docente);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<Docente> ObtenerPorId(Docente pDocente)
        {
            var docente = new Docente();
            using (var bdContexto = new BDContexto())
            {
                docente = await bdContexto.Docente.FirstOrDefaultAsync(d => d.Id == pDocente.Id);
            }
            return docente ;
        }
        public static async Task<List<Docente>> ObtenerTodos()
        {
            var docentes = new List<Docente>();
            using (var bdContexto = new BDContexto())
            {
                docentes = await bdContexto.Docente.ToListAsync();
            }
            return docentes;
        }
        internal static IQueryable<Docente> QuerySelect(IQueryable<Docente> pQuery, Docente pDocente)
        {
            if (pDocente.Id > 0)
                pQuery = pQuery.Where(d => d.Id == pDocente.Id);
            if (!string.IsNullOrWhiteSpace(pDocente.Nombre))
                pQuery = pQuery.Where(d => d.Nombre.Contains(pDocente.Nombre));
            pQuery = pQuery.OrderByDescending(d => d.Id).AsQueryable();
            if (!string.IsNullOrWhiteSpace(pDocente.Apellido))
                pQuery = pQuery.Where(d => d.Apellido.Contains(pDocente.Apellido));
            pQuery = pQuery.OrderByDescending(d => d.Id).AsQueryable();
            if (!string.IsNullOrWhiteSpace(pDocente.Apellido))
                pQuery = pQuery.Where(d => d.Telefono.Contains(pDocente.Telefono));
            pQuery = pQuery.OrderByDescending(d => d.Id).AsQueryable();
            if (pDocente.Top_Aux > 0)
                pQuery = pQuery.Take(pDocente.Top_Aux).AsQueryable();
            return pQuery;
        }
        public static async Task<List<Docente>> Buscar(Docente pDocente)
        {
            var docentes = new List<Docente>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Docente.AsQueryable();
                select = QuerySelect(select, pDocente);
                docentes = await select.ToListAsync();
            }
            return docentes;
        }
    }
}