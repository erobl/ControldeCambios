
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ControldeCambios.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Estado_Solicitud
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Estado_Solicitud()
    {

        this.Solicitud_Cambios = new HashSet<Solicitud_Cambios>();

    }


    public string nombre { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Solicitud_Cambios> Solicitud_Cambios { get; set; }

}

}
