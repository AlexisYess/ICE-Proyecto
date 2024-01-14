using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICE.Control.AccesoADatos;
using ICE.Control.EntidadesDeNegocio;

namespace ICE.Control.LogicaDeNegocios
{
    public class CursoBL
    {
        public async Task<int> Crear(Curso pCurso)
        {
            return await CursoDAL.Crear(pCurso);
        }

        public async Task<int> Modificar(Curso pCurso)
        {
            return await CursoDAL.Modificar(pCurso);
        }

        public async Task<int> Eliminar(Curso pCurso)
        {
            return await CursoDAL.Eliminar(pCurso);
        }

        public async Task<Curso> ObtenerPorId(Curso pCurso)
        {
            return await CursoDAL.ObtenerPorId(pCurso);
        }

        public async Task<List<Curso>> ObtenerTodos()
        {
            return await CursoDAL.ObtenerTodos();
        }

        public async Task<List<Curso>> Buscar(Curso pCurso)
        {
            return await CursoDAL.Buscar(pCurso);
        }
    }
}