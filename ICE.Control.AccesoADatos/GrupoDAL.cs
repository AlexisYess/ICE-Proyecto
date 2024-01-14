using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICE.Control.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;

namespace ICE.Control.AccesoADatos
{
   public class GrupoDAL
    {

        public static async Task<int> Crear(Grupo pGrupo)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                bdContexto.Add(pGrupo);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Modificar(Grupo pGrupo)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var grupo = await bdContexto.Grupo.FirstOrDefaultAsync(c => c.Id == pGrupo.Id);
                grupo.Nombre = pGrupo.Nombre;

                bdContexto.Update(grupo);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Eliminar(Grupo pGrupo)
        {
            int result = 0;
            using (var bdContexto = new BDContexto())
            {
                var grupo = await bdContexto.Grupo.FirstOrDefaultAsync(c => c.Id == pGrupo.Id);
                bdContexto.Grupo.Remove(grupo);
                result = await bdContexto.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<Grupo> ObtenerPorId(Grupo pGrupo)
        {
            var grupo = new Grupo();
            using (var bdContexto = new BDContexto())
            {
                grupo = await bdContexto.Grupo.FirstOrDefaultAsync(c => c.Id == pGrupo.Id);
            }
            return grupo;
        }
        public static async Task<List<Grupo>> ObtenerTodos()
        {
            var grupos = new List<Grupo>();
            using (var bdContexto = new BDContexto())
            {
                grupos = await bdContexto.Grupo.ToListAsync();
            }
            return grupos;
        }
        internal static IQueryable<Grupo> QuerySelect(IQueryable<Grupo> pQuery, Grupo pGrupo)
        {
            if (pGrupo.Id > 0)
                pQuery = pQuery.Where(c => c.Id == pGrupo.Id);
            if (!string.IsNullOrWhiteSpace(pGrupo.Nombre))
                pQuery = pQuery.Where(c => c.Nombre.Contains(pGrupo.Nombre));
            pQuery = pQuery.OrderByDescending(c => c.Id).AsQueryable();

            if (pGrupo.Top_Aux > 0)
                pQuery = pQuery.Take(pGrupo.Top_Aux).AsQueryable();
            return pQuery;
        }
        public static async Task<List<Grupo>> Buscar(Grupo pGrupo)
        {
            var grupos = new List<Grupo>();
            using (var bdContexto = new BDContexto())
            {
                var select = bdContexto.Grupo.AsQueryable();
                select = QuerySelect(select, pGrupo);
                grupos = await select.ToListAsync();
            }
            return grupos;
        }
    }
}
