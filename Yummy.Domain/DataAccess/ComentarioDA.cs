using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Yummy.Domain.DTO;

namespace Yummy.Domain.DataAccess
{
    public class ComentarioDA: DapperBase
    {
        public List<Comentario> GetEmpresaComentario(string idEmpresa)
        {
            var sql = "dbo.spSelComentarioXEmpresa";
            var comentarios = Query<Comentario>(sql, new { IdEmpresa = idEmpresa }, commandType: CommandType.StoredProcedure).ToList();

            return comentarios;
        }
    }
}
