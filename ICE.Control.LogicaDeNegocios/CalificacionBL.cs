using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICE.Control.AccesoADatos;
using ICE.Control.EntidadesDeNegocio;

namespace ICE.Control.LogicaDeNegocios
{
    public class CalificacionBL
    {
        public async Task<int> Crear(Calificacion pCalificacion)
        {
            return await CalificacionDAL.Crear(pCalificacion);
        }

        public async Task<int> Modificar(Calificacion pCalificacion)
        {
            return await CalificacionDAL.Modificar(pCalificacion);
        }

        public async Task<int> Eliminar(Calificacion pCalificacion)
        {
            return await CalificacionDAL.Eliminar(pCalificacion);
        }

        public async Task<Calificacion> ObtenerPorId(Calificacion pCalificacion)
        {
            return await CalificacionDAL.ObtenerPorId(pCalificacion);
        }

        public async Task<List<Calificacion>> ObtenerTodos()
        {
            return await CalificacionDAL.ObtenerTodos();
        }

        public async Task<List<Calificacion>> Buscar(Calificacion pCalificacion)
        {
            return await CalificacionDAL.Buscar(pCalificacion);
        }
        public async Task<List<Calificacion>> BuscarIncluirMatriculas(Calificacion pCalificacion)
        {
            return await CalificacionDAL.BuscarIncluirMatriculas(pCalificacion);
        }
    }
}
