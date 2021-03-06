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

    // bit_bco_ped
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BitBcoPedConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BitBcoPed>
    {
        public BitBcoPedConfiguration()
            : this("dbo")
        {
        }

        public BitBcoPedConfiguration(string schema)
        {
            ToTable("bit_bco_ped", schema);
            HasKey(x => x.IdBcoBitPed);

            Property(x => x.IdBcoBitPed).HasColumnName(@"id_bco_bit_ped").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.NumDocCli).HasColumnName(@"num_doc_cli").HasColumnType("int").IsRequired();
            Property(x => x.RefBen).HasColumnName(@"ref_ben").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.Ped).HasColumnName(@"ped").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.IdCliACtaDe).HasColumnName(@"id_cli_a_cta_de").HasColumnType("int").IsRequired();
            Property(x => x.ErrMsg).HasColumnName(@"errMsg").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.ErrNmbr).HasColumnName(@"errNmbr").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
