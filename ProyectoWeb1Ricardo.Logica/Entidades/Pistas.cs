//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb1Ricardo.Logica.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pistas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pistas()
        {
            this.UsuariosPistas = new HashSet<UsuariosPistas>();
        }
    
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Demo { get; set; }
        public string Observacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuariosPistas> UsuariosPistas { get; set; }
    }
}