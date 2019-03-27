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

    // bit_pag_crp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BitPagCrpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BitPagCrp>
    {
        public BitPagCrpConfiguration()
            : this("dbo")
        {
        }

        public BitPagCrpConfiguration(string schema)
        {
            ToTable("bit_pag_crp", schema);
            HasKey(x => x.IdBitPagCrp);

            Property(x => x.IdBitPagCrp).HasColumnName(@"id_bit_pag_crp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsOptional();
            Property(x => x.Usr).HasColumnName(@"usr").HasColumnType("int").IsOptional();
            Property(x => x.Docto).HasColumnName(@"docto").HasColumnType("int").IsOptional();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsOptional();
        }
    }

}
// </auto-generated>