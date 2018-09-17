using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Yummy.Domain.DataAccess
{
    public class PlatilloDA: DapperBase
    {
        public List<Platillo> GetEmpresasPLatillos(string idEmpresa)
        {
            var sql = "dbo.spSelPlatilloXEmpresa";
            var platillos = Query<Platillo>(sql, new { IdEmpresa = idEmpresa }, commandType: CommandType.StoredProcedure).ToList();

            return platillos;
        }

    }
}
