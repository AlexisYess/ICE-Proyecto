using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICE.Control.AccesoADatos;
using ICE.Control.EntidadesDeNegocio;

namespace ICE.Control.LogicaDeNegocios
{
    public class MatriculaBL
    {
        public async Task<int>Crear(Matricula pMatricula)
        {
            return await MatriculaDAL.Crear(pMatricula);
        }

        public async Task<int> Modificar(Matricula pMatricula)
        {
            return await MatriculaDAL.Modificar(pMatricula);
        }

        public async Task<int> Eliminar(Matricula pMatricula)
        {
            return await MatriculaDAL.Eliminar(pMatricula);
        }

        public async Task<Matricula>ObtenerPorId(Matricula pMatricula)
        {
            return await MatriculaDAL.ObtenerPorId(pMatricula);
        }

        public async Task<List<Matricula>>ObtenerTodos()
        {
            return await MatriculaDAL.ObtenerTodos();
        }

        public async Task<List<Matricula>>Buscar(Matricula pMatricula)
        {
            return await MatriculaDAL.Buscar(pMatricula);
        }

        public async Task<List<Matricula>> BuscarIncluirDGCS(Matricula pMatricula)
        {
            return await MatriculaDAL.BuscarIncluirDGCS(pMatricula);
        }

        public async Task<int> Editar(Matricula pMatricula)
        {
            return await MatriculaDAL.Editar(pMatricula);
        }
    }
}
