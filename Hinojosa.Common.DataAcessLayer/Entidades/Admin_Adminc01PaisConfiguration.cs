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

    // ADMINC_01_PAISES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc01PaisConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Adminc01Pais>
    {
        public Admin_Adminc01PaisConfiguration()
            : this("Admin")
        {
        }

        public Admin_Adminc01PaisConfiguration(string schema)
        {
            ToTable("ADMINC_01_PAISES", schema);
            HasKey(x => x.NIdPais01);

            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(72);
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsOptional();
            Property(x => x.SClaveAlpha2).HasColumnName(@"sClaveAlpha2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SClaveAlpha3).HasColumnName(@"sClaveAlpha3").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.BStatus).HasColumnName(@"bStatus").HasColumnType("bit").IsRequired();
            Property(x => x.NTratado).HasColumnName(@"nTratado").HasColumnType("tinyint").IsOptional();
            Property(x => x.SNacionalidad).HasColumnName(@"sNacionalidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasOptional(a => a.Admin_Adminc03Moneda).WithMany(b => b.Admin_Adminc01Pais).HasForeignKey(c => c.NIdMoneda03).WillCascadeOnDelete(false); // FK_ADMINC_01_PAISES_ADMINC_03_MONEDAS
        }
    }

}
// </auto-generated>
