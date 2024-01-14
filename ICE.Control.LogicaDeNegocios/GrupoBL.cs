using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICE.Control.AccesoADatos;
using ICE.Control.EntidadesDeNegocio;

namespace ICE.Control.LogicaDeNegocios
{
   public  class GrupoBL
   {
        public async Task<int> Crear(Grupo pGrupo)
        {
            return await GrupoDAL.Crear(pGrupo);
        }

        public async Task<int> Modificar(Grupo pGrupo)
        {
            return await GrupoDAL.Modificar(pGrupo);
        }

        public async Task<int> Eliminar(Grupo pGrupo)
        {
            return await GrupoDAL.Eliminar(pGrupo);
        }

        public async Task<Grupo> ObtenerPorId(Grupo pGrupo)
        {
            return await GrupoDAL.ObtenerPorId(pGrupo);
        }

        public async Task<List<Grupo>> ObtenerTodos()
        {
            return await GrupoDAL.ObtenerTodos();
        }

        public async Task<List<Grupo>> Buscar(Grupo pGrupo)
        {
            return await GrupoDAL.Buscar(pGrupo);
        }
    }
}
