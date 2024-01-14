using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ICE.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ICE.Control.EntidadesDeNegocio;

//namespace ICE.AccesoADatos.Tests
//{
//    [TestClass()]
//    public class UsuarioDALTests
//    {
//        private static Usuario usuarioInicial = new Usuario { Id = 1, IdRol = 1, Login = "Alexis@5", Password = "admin" };
//        [TestMethod()]
//        public async Task  LoginTest()
//        {
//            var usuario = new Usuario();
//            usuario.Login = usuarioInicial.Login;
//            usuario.Password = usuarioInicial.Password;
//            var resultUsuario = await UsuarioDAL.Login(usuario);
//            Assert.AreEqual(usuario.Login, resultUsuario.Login);
//        }
//    }
//}