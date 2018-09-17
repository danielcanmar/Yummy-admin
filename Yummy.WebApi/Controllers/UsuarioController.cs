using Yummy.Domain;
using Yummy.Domain.DataAccess;
using Yummy.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yummy.WebApi.Controllers
{
    [RoutePrefix("Yummy")]
    public class UsuarioController : ApiController
    {
        [Route("Usuario")]
        [Authorize]
        [HttpGet]
        // GET: api/Usuario
        public ResponseModel GetUsuario(string email, string password)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            UsuarioDA UsuarioDA = new UsuarioDA();
            Usuario empresas = new Usuario();

            empresas = UsuarioDA.GetUsuario(email, password);

            _objResponseModel.Data = empresas;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
