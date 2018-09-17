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
    public class RatingController : ApiController
    {
        [Route("Rating")]
        [Authorize]
        [HttpGet]
        // GET: api/Rating
        public ResponseModel GetRating(string IdEmpresa)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            RatingDA ratingDA = new RatingDA();
            RatingDTO rating = new RatingDTO();

            rating = ratingDA.GetRating(IdEmpresa);

            _objResponseModel.Data = rating;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // GET: api/Rating/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rating
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Rating/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Rating/5
        public void Delete(int id)
        {
        }
    }
}
