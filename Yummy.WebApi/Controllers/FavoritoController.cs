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
    public class FavoritoController : ApiController
    {
        // GET: api/Favorito
        [Route("Favorito")]
        [Authorize]
        [HttpGet]
       
        public ResponseModel GetUsuarioFavorito(string idUsuario)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            FavoritoDA favoritoDA = new FavoritoDA();
            List<Favorito> favorito = new List<Favorito>();

            favorito = favoritoDA.GetUsuarioFavorito(idUsuario);

            _objResponseModel.Data = favorito;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // GET: api/Favorito/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Favorito
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Favorito/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Favorito/5
        public void Delete(int id)
        {
        }
    }
}
