//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yummy.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public System.Guid Id { get; set; }
        public Nullable<int> AspNetUserId { get; set; }
        public Nullable<int> Rolld { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> CodigoPotal { get; set; }
        public Nullable<int> IdCiudad { get; set; }
        public Nullable<int> IdEstado { get; set; }
    }
}
