//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solicitud
    {
        public string titulo { get; set; }
        public string des { get; set; }
        public int usuario { get; set; }
    
        public virtual Usuario Director { get; set; }
    }
}
