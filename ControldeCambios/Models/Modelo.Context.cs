﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Entities : DbContext
{
    public Entities()
        : base("name=Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<CambiosRequerimiento> CambiosRequerimientos { get; set; }

    public virtual DbSet<Estado_Requerimientos> Estado_Requerimientos { get; set; }

    public virtual DbSet<Modulo> Modulos { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Proyecto_Equipo> Proyecto_Equipo { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<Requerimiento> Requerimientos { get; set; }

    public virtual DbSet<Rol_Permisos> Rol_Permisos { get; set; }

    public virtual DbSet<Sprint_Modulo> Sprint_Modulo { get; set; }

    public virtual DbSet<Sprint> Sprints { get; set; }

    public virtual DbSet<Tipo_Desarrollador> Tipo_Desarrollador { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Usuarios_Telefonos> Usuarios_Telefonos { get; set; }

    public virtual DbSet<Estado_Proyecto> Estado_Proyecto { get; set; }

    public virtual DbSet<Progreso_Sprint> Progreso_Sprint { get; set; }

    public virtual DbSet<Requerimientos_Cri_Acep> Requerimientos_Cri_Acep { get; set; }

}

}

