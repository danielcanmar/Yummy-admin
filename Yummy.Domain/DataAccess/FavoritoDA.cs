using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Yummy.Domain.DataAccess
{
    public class FavoritoDA: DapperBase
    {
        public List<Favorito> GetUsuarioFavorito(string idUsuario)
        {
            var sql = "dbo.spSelFavoritoXUsuario";
            var favorito = Query<Favorito>(sql, new { IdUsuario = idUsuario }, commandType: CommandType.StoredProcedure).ToList();

            return favorito;
        }
    }
}
