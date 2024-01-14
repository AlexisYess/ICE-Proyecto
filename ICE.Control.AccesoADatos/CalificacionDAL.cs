using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICE.Control.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;

namespace ICE.Control.AccesoADatos
{
    public class CalificacionDAL
    {

        public static async Task<int> Crear(Calificacion pCalificacion)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pCalificacion);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Modificar(Calificacion pCalificacion)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var calificacion = await bdContexto.Calificacion.FirstOrDefaultAsync(d => d.Id == pCalificacion.Id);
                calificacion.IdMatricula = pCalificacion.IdMatricula;
                calificacion.Word = pCalificacion.Word;
                calificacion.Excel = pCalificacion.Excel;
                calificacion.PowerPoint = pCalificacion.PowerPoint;
                calificacion.Access = pCalificacion.Access;
                calificacion.Publisher = pCalificacion.Publisher;
                calificacion.CorelDraw = pCalificacion.CorelDraw;
                calificacion.Photoshop = pCalificacion.Photoshop;
                calificacion.Mantenimiento = pCalificacion.Mantenimiento;
                calificacion.Redes = pCalificacion.Redes;
                calificacion.Promedio = pCalificacion.Promedio;
                bdContexto.Update(calificacion);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Eliminar(Calificacion pCalificacion)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var calificacion = await bdContexto.Calificacion.FirstOrDefaultAsync(d => d.Id == pCalificacion.Id);
                bdContexto.Calificacion.Remove(calificacion);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<Calificacion> ObtenerPorId(Calificacion pCalificacion)
        {
            var calificacion = new Calificacion();
            using (var bdContexto = new BDContexto())
            {
                calificacion = await bdContexto.Calificacion.FirstOrDefaultAsync(d => d.Id == pCalificacion.Id);
            }
            return calificacion;
        }
        public static async Task<List<Calificacion>> ObtenerTodos()
        {
            var calificacion = new List<Calificacion>();
            using (var bdContexto = new BDContexto())
            {
                calificacion = await bdContexto.Calificacion.ToListAsync();
            }
            return calificacion;
        }
        internal static IQueryable<Calificacion> QuerySelect(IQueryable<Calificacion> pQuery, Calificacion pCalificacion)
        {
            if (pCalificacion.Id > 0)
                pQuery = pQuery.Where(s => s.Id == pCalificacion.Id);

            if (pCalificacion.IdMatricula > 0)
                pQuery = pQuery.Where(s => s.IdMatricula == pCalificacion.IdMatricula);

            if (pCalificacion.Word > 0)
                pQuery = pQuery.Where(s => s.Word == pCalificacion.Word);

            if (pCalificacion.Excel > 0)
                pQuery = pQuery.Where(s => s.Excel == pCalificacion.Excel);

            if (pCalificacion.PowerPoint > 0)
                pQuery = pQuery.Where(s => s.PowerPoint == pCalificacion.PowerPoint);

            if (pCalificacion.Access > 0)
                pQuery = pQuery.Where(s => s.Access == pCalificacion.Access);

            if (pCalificacion.Publisher > 0)
                pQuery = pQuery.Where(s => s.Publisher == pCalificacion.Publisher);

            if (pCalificacion.CorelDraw > 0)
                pQuery = pQuery.Where(s => s.CorelDraw == pCalificacion.CorelDraw);

            if (pCalificacion.Photoshop > 0)
                pQuery = pQuery.Where(s => s.Photoshop == pCalificacion.Photoshop);

            if (pCalificacion.Mantenimiento > 0)
                pQuery = pQuery.Where(s => s.Mantenimiento == pCalificacion.Mantenimiento);

            if (pCalificacion.Redes > 0)
                pQuery = pQuery.Where(s => s.Redes == pCalificacion.Redes);

            if (pCalificacion.Promedio > 0.0f)
                pQuery = pQuery.Where(s => s.Promedio == pCalificacion.Promedio);

            pQuery = pQuery.OrderByDescending(s => s.Id).AsQueryable();
            if (pCalificacion.Top_Aux > 0)
                pQuery = pQuery.Take(pCalificacion.Top_Aux).AsQueryable();
            return pQuery;



        }
        public static async Task<List<Calificacion>> Buscar(Calificacion pCalificacion)
        {
            var calificacion = new List<Calificacion>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Calificacion.AsQueryable();
                select = QuerySelect(select, pCalificacion);
                calificacion = await select.ToListAsync();
            }
            return calificacion;
        }
        public static async Task<List<Calificacion>> BuscarIncluirMatriculas(Calificacion pCalificacion)
        {
            var calificacions = new List<Calificacion>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Calificacion.AsQueryable();
                select = QuerySelect(select, pCalificacion).Include(s => s.Matricula).AsQueryable();
                calificacions = await select.ToListAsync();
            }
            return calificacions;

        }
    }
}


