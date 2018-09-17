using Yummy.Domain;
using Yummy.Domain.DataAccess;
using Yummy.Domain.DTO;
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
    public class OrdenController : ApiController
    {
        [Route("Orden")]
        [Authorize]
        [HttpGet]
        // GET: api/Orden
        public ResponseModel GetUsuarioOrden(string idUsuario)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            OrdenDA ordenDA = new OrdenDA();
            List<Orden> Ordens = new List<Orden>();

            Ordens = ordenDA.GetUsuarioOrden(idUsuario);

            _objResponseModel.Data = Ordens;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        [Route("Orden")]
        [Authorize]
        [HttpGet]
        // GET: api/Orden/5
        public ResponseModel GetOrdenXPlatillos(string idOrden)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            OrdenDA ordenDA = new OrdenDA();
            List<OrdenesDTO> platillos = new List<OrdenesDTO>();

            platillos = ordenDA.GetOrdenXPlatillos(idOrden);

            _objResponseModel.Data = platillos;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // POST: api/Orden
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orden/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orden/5
        public void Delete(int id)
        {
        }
    }
}
