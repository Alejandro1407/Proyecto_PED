//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministradorOrtopediaVelásquez
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipoOrtesis
    {
        public tipoOrtesis()
        {
            this.ortesis = new HashSet<ortesis>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public byte[] foto { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<ortesis> ortesis { get; set; }
    }
}
