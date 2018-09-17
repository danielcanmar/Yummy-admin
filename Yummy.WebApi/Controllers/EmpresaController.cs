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
    public class EmpresaController : ApiController
    {
        [Route("Empresa")]
        [Authorize]
        [HttpGet]
        // GET api/<controller>
        public ResponseModel GetEmpresasCiudad(int idCiudad)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            EmpresaDA empresaDA = new EmpresaDA();
            List<EmpresaDTO> empresas = new List<EmpresaDTO>();

            empresas = empresaDA.GetEmpresasCiudad(idCiudad);

            _objResponseModel.Data = empresas;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // GET: api/Empresa/5
        [Route("Empresa")]
        [Authorize]
        [HttpGet]
        public ResponseModel GetEmpresasCategoria(int Idcategoria)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            EmpresaDA empresaDA = new EmpresaDA();
            List<Empresa> empresas = new List<Empresa>();

            empresas = empresaDA.GetEmpresasCategoria(Idcategoria);

            _objResponseModel.Data = empresas;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Datos recibidos correctamente.";

            return _objResponseModel;
        }

        // POST: api/Empresa
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Empresa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empresa/5
        public void Delete(int id)
        {
        }
    }
}
