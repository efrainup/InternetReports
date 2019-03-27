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

    // ADMINC_24_PROV_CARACTERISTICAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc24ProvCaracteristicaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Adminc24ProvCaracteristica>
    {
        public Admin_Adminc24ProvCaracteristicaConfiguration()
            : this("Admin")
        {
        }

        public Admin_Adminc24ProvCaracteristicaConfiguration(string schema)
        {
            ToTable("ADMINC_24_PROV_CARACTERISTICAS", schema);
            HasKey(x => x.NIdProvCarac24);

            Property(x => x.NIdProvCarac24).HasColumnName(@"nIdProvCarac24").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SValor).HasColumnName(@"sValor").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.NIdCarac29).HasColumnName(@"nIdCarac29").HasColumnType("int").IsRequired();
            Property(x => x.NIdProv42).HasColumnName(@"nIdProv42").HasColumnType("int").IsRequired();
            Property(x => x.NIdTipoProv10).HasColumnName(@"nIdTipoProv10").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Admin_Adminc10TiposProveedore).WithMany(b => b.Admin_Adminc24ProvCaracteristica).HasForeignKey(c => c.NIdTipoProv10).WillCascadeOnDelete(false); // FK_ADMINC_24_PROV_CARACTERISTICAS_ADMINC_10_TIPOS_PROVEEDORES
            HasRequired(a => a.Admin_Adminc29Caracteristica).WithMany(b => b.Admin_Adminc24ProvCaracteristica).HasForeignKey(c => c.NIdCarac29).WillCascadeOnDelete(false); // FK_ADMINC_24_PROV_CARACTERISTICAS_ADMINC_29_CARACTERISTICAS
            HasRequired(a => a.Admin_Adminc42Proveedore).WithMany(b => b.Admin_Adminc24ProvCaracteristica).HasForeignKey(c => c.NIdProv42); // FK_ADMINC_24_PROV_CARACTERISTICAS_ADMINC_42_PROVEEDORES
        }
    }

}
// </auto-generated>