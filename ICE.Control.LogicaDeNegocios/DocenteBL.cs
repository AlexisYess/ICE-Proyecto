using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICE.Control.AccesoADatos;
using ICE.Control.EntidadesDeNegocio;


namespace ICE.Control.LogicaDeNegocios
{
    public class DocenteBL
    {
       public async Task<int>Crear(Docente pDocente)
        {
            return await DocenteDAL.Crear(pDocente);
        }

        public async Task<int>Modificar(Docente pDocente)
        {
            return await DocenteDAL.Modificar(pDocente);
        }

        public async Task<int>Eliminar(Docente pDocente)
        {
            return await DocenteDAL.Eliminar(pDocente);
        }

        public async Task<Docente>ObtenerPorId(Docente pDocente)
        {
            return await DocenteDAL.ObtenerPorId(pDocente);
        }

        public async Task<List<Docente>>ObtenerTodos()
        { 
            return await DocenteDAL.ObtenerTodos();
        }

        public async Task<List<Docente>>Buscar(Docente pDocente)
        {
            return await DocenteDAL.Buscar(pDocente);
        }
    }
}
