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

    // ADMINC_04_PUERTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc04PuertoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Adminc04Puerto>
    {
        public Admin_Adminc04PuertoConfiguration()
            : this("Admin")
        {
        }

        public Admin_Adminc04PuertoConfiguration(string schema)
        {
            ToTable("ADMINC_04_PUERTOS", schema);
            HasKey(x => x.NIdPuerto04);

            Property(x => x.NIdPuerto04).HasColumnName(@"nIdPuerto04").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SNombreCorto).HasColumnName(@"sNombreCorto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsOptional();
            Property(x => x.BStatus).HasColumnName(@"bStatus").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc01Pais).WithMany(b => b.Admin_Adminc04Puerto).HasForeignKey(c => c.NIdPais01).WillCascadeOnDelete(false); // FK_ADMINC_04_PUERTOS_ADMINC_01_PAISES
        }
    }

}
// </auto-generated>
