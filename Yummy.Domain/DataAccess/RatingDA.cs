using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Yummy.Domain.DTO;

namespace Yummy.Domain.DataAccess
{
    public class RatingDA : DapperBase
    {
        public RatingDTO GetRating(string idEmpresa)
        {
            var sql = "dbo.spSelReting";
            var rating = Query<RatingDTO>(sql, new { IdEmpresa = idEmpresa }, commandType: CommandType.StoredProcedure).FirstOrDefault();

            return rating;
        }
    }
}
