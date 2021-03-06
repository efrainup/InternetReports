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

    // bco_concil_tmp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoConcilTmpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BcoConcilTmp>
    {
        public BcoConcilTmpConfiguration()
            : this("dbo")
        {
        }

        public BcoConcilTmpConfiguration(string schema)
        {
            ToTable("bco_concil_tmp", schema);
            HasKey(x => x.IdBcoAux);

            Property(x => x.IdBcoAux).HasColumnName(@"id_bco_aux").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CChecked).HasColumnName(@"c_checked").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ip).HasColumnName(@"IP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.FecBco).HasColumnName(@"fec_bco").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
