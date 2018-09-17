using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Yummy.Domain.DataAccess
{
    public class UsuarioDA : DapperBase
    {
        public Usuario GetUsuario(string email , string password)
        {           
            var sql = "dbo.spSelUsuario";
            var usuario = Query<Usuario>(sql, new { Email = email, Password = password }, commandType: CommandType.StoredProcedure).FirstOrDefault();

            return usuario;
         }
        public List<Favorito> GetUsuarioFavorito(string idUsuario)
        {
            var sql = "dbo.spSelFavoritoXUsuario";
            var favorito = Query<Favorito>(sql, new { IdUsuario = idUsuario }, commandType: CommandType.StoredProcedure).ToList();

            return favorito;
        }
    }
    
}
