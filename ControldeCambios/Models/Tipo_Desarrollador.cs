
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
    
public partial class Tipo_Desarrollador
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tipo_Desarrollador()
    {

        this.Proyecto_Equipo = new HashSet<Proyecto_Equipo>();

    }


    public string nombre { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Proyecto_Equipo> Proyecto_Equipo { get; set; }

}

}
