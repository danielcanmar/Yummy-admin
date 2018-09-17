using Yummy.Domain;
using Yummy.Domain.DataAccess;
using Yummy.WebApi.Models;
using Yummy.Domain.DTO;
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
    public class ComentarioController : ApiController
    {
        [Route("Comentario")]
        [Authorize]
        [HttpGet]
        // GET: api/Comentario
        public ResponseModel GetEmpresaComentario(string idEmpresa)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            ComentarioDA comentarioDA = new ComentarioDA();
            List<Comentario> comentarios = new List<Comentario>();

            comentarios = comentarioDA.GetEmpresaComentario(idEmpresa);

            _objResponseModel.Data = comentarios;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // GET: api/Comentario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Comentario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Comentario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Comentario/5
        public void Delete(int id)
        {
        }
    }
}
