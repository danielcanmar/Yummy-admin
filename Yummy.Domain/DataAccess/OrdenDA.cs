using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Yummy.Domain.DTO;

namespace Yummy.Domain.DataAccess
{
    public class OrdenDA: DapperBase
    {
        public List<Orden> GetUsuarioOrden(string idUsuario)
        {
            var sql = "dbo.spSelUsuarioXOrden";
            var Ordenes = Query<Orden>(sql, new { IdUsuario = idUsuario }, commandType: CommandType.StoredProcedure).ToList();

            return Ordenes;
        }
        public List<OrdenesDTO> GetOrdenXPlatillos(string idOrden)
        {
            var sql = "dbo.spSelOrdenXPlatillo";
            var ordenXPlatillos = Query<OrdenesDTO>(sql, new { IdOrden = idOrden }, commandType: CommandType.StoredProcedure).ToList();

            return ordenXPlatillos;
        }
    }
}
