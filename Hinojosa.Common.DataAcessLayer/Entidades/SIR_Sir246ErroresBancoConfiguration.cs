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

    // SIR_246_ERRORES_BANCOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir246ErroresBancoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir246ErroresBanco>
    {
        public SIR_Sir246ErroresBancoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir246ErroresBancoConfiguration(string schema)
        {
            ToTable("SIR_246_ERRORES_BANCOS", schema);
            HasKey(x => x.NIdErrBanc246);

            Property(x => x.NIdErrBanc246).HasColumnName(@"nIdErrBanc246").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("int").IsRequired();
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
        }
    }

}
// </auto-generated>
