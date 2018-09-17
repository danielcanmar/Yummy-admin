using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yummy.Domain.DTO
{
    public class EmpresaDTO
    {
        public System.Guid Id { get; set; }
        public Nullable<int> IdCiudad { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<int> CodigoPostal { get; set; }
        public string Direccion { get; set; }
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Logo { get; set; }
        public string Imagen { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.TimeSpan> HoraOpen { get; set; }
        public Nullable<System.TimeSpan> HoraClosed { get; set; }
        public string Telefono { get; set; }
        public Nullable<double> Latitud { get; set; }
        public Nullable<double> Longitud { get; set; }




    }
}
