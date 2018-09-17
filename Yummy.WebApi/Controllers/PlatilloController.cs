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
    public class PlatilloController : ApiController
    {
        [Route("Platillo")]
        [Authorize]
        [HttpGet]
        // GET: api/Platillo
        public ResponseModel Get(string idEmpresa)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            PlatilloDA platilloDA = new PlatilloDA();
            List<Platillo> platillos = new List<Platillo>();

            platillos = platilloDA.GetEmpresasPLatillos(idEmpresa);

            _objResponseModel.Data = platillos;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // GET: api/Platillo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Platillo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Platillo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Platillo/5
        public void Delete(int id)
        {
        }
    }
}
