// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;

namespace Hinojosa.Common.DataAccessLayer.Entidades
{

    // SIRA_48_DETALLE_PROG_SERVICIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira48DetalleProgServicioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira48DetalleProgServicio>
    {
        public SIRAdmin_Sira48DetalleProgServicioConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira48DetalleProgServicioConfiguration(string schema)
        {
            ToTable("SIRA_48_DETALLE_PROG_SERVICIOS", schema);
            HasKey(x => x.NIdDetProgServ48);

            Property(x => x.NIdDetProgServ48).HasColumnName(@"nIdDetProgServ48").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.NIdRecOrigen42).HasColumnName(@"nIdRecOrigen42").HasColumnType("int").IsOptional();
            Property(x => x.NIdRecOrigen).HasColumnName(@"nIdRecOrigen").HasColumnType("int").IsOptional();
            Property(x => x.NIdRecDestino42).HasColumnName(@"nIdRecDestino42").HasColumnType("int").IsOptional();
            Property(x => x.NIdRecDestino).HasColumnName(@"nIdRecDestino").HasColumnType("int").IsOptional();
            Property(x => x.NPesoBruto).HasColumnName(@"nPesoBruto").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.DFechaEntrada).HasColumnName(@"dFechaEntrada").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdTransporte175).HasColumnName(@"nIdTransporte175").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc42Proveedore_NIdRecDestino42).WithMany(b => b.SIRAdmin_Sira48DetalleProgServicio_NIdRecDestino42).HasForeignKey(c => c.NIdRecDestino42).WillCascadeOnDelete(false); // FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_DESTINO
            HasOptional(a => a.Admin_Adminc42Proveedore_NIdRecOrigen42).WithMany(b => b.SIRAdmin_Sira48DetalleProgServicio_NIdRecOrigen42).HasForeignKey(c => c.NIdRecOrigen42).WillCascadeOnDelete(false); // FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_ORIGEN
            HasOptional(a => a.CatProv_NIdRecDestino).WithMany(b => b.SIRAdmin_Sira48DetalleProgServicio_NIdRecDestino).HasForeignKey(c => c.NIdRecDestino).WillCascadeOnDelete(false); // FK_SIRA_48_DETALLE_PROG_SERVICIOS_cat_prov_DESTINO
            HasOptional(a => a.CatProv_NIdRecOrigen).WithMany(b => b.SIRAdmin_Sira48DetalleProgServicio_NIdRecOrigen).HasForeignKey(c => c.NIdRecOrigen).WillCascadeOnDelete(false); // FK_SIRA_48_DETALLE_PROG_SERVICIOS_cat_prov_ORIGEN
            HasOptional(a => a.SIR_Sir175Transporte).WithMany(b => b.SIRAdmin_Sira48DetalleProgServicio).HasForeignKey(c => c.NIdTransporte175).WillCascadeOnDelete(false); // FK_SIRA_48_DETALLE_PROG_SERVICIOS_SIR_175_TRANSPORTES
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIRAdmin_Sira48DetalleProgServicio).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIRA_48_DETALLE_PROG_SERVICIOS_SIR_60_REFERENCIAS
        }
    }

}
// </auto-generated>
