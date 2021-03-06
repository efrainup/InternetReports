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

    // gas_tar
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class GasTarConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GasTar>
    {
        public GasTarConfiguration()
            : this("dbo")
        {
        }

        public GasTarConfiguration(string schema)
        {
            ToTable("gas_tar", schema);
            HasKey(x => x.IdGasTar);

            Property(x => x.IdGasTar).HasColumnName(@"id_gas_tar").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CveTar).HasColumnName(@"cve_tar").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdEje).HasColumnName(@"id_eje").HasColumnType("int").IsRequired();
            Property(x => x.IdPer).HasColumnName(@"id_per").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.Mpu).HasColumnName(@"mpu").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.DesTar).HasColumnName(@"des_tar").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>
