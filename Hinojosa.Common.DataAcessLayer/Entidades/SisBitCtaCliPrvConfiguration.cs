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

    // sis_bit_cta_cli_prv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitCtaCliPrvConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisBitCtaCliPrv>
    {
        public SisBitCtaCliPrvConfiguration()
            : this("dbo")
        {
        }

        public SisBitCtaCliPrvConfiguration(string schema)
        {
            ToTable("sis_bit_cta_cli_prv", schema);
            HasKey(x => x.IdBit);

            Property(x => x.IdBit).HasColumnName(@"id_bit").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired();
            Property(x => x.TipTbl).HasColumnName(@"tip_tbl").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Evento).HasColumnName(@"evento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(11);
            Property(x => x.ValorAnt).HasColumnName(@"valor_ant").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.ValorNvo).HasColumnName(@"valor_nvo").HasColumnType("nvarchar(max)").IsRequired();
        }
    }

}
// </auto-generated>
