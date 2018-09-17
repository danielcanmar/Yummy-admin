using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Yummy.Domain.DTO;


namespace Yummy.Domain.DataAccess
{
    public class EmpresaDA : DapperBase
    {
       
        public List<EmpresaDTO> GetEmpresasCiudad(int idCiudad)
        {
            var sql = "dbo.spSelEmpresaXCiudad";
            var empresas = Query<EmpresaDTO>(sql, new { IdCiudad = idCiudad }, commandType: CommandType.StoredProcedure).ToList();

            return empresas;
        }

        public List<Empresa> GetEmpresasCategoria(int Idcategoria )
        {
            var sql = "dbo.spSelEmpresaXCategoria";
            var empresas = Query<Empresa>(sql, new { Categoria = Idcategoria }, commandType: CommandType.StoredProcedure).ToList();

            return empresas;
        }
       
        


    }
}
