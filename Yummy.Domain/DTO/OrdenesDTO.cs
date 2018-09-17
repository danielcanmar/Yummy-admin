using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yummy.Domain.DTO
{
    public class OrdenesDTO
    {   

        public Nullable<int> Cantidad { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public Nullable<double> Precio { get; set; }    


    }
}
