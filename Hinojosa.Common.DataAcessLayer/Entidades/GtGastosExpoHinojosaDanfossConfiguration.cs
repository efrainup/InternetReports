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

    // GT_GastosExpoHinojosaDanfoss
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class GtGastosExpoHinojosaDanfossConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GtGastosExpoHinojosaDanfoss>
    {
        public GtGastosExpoHinojosaDanfossConfiguration()
            : this("dbo")
        {
        }

        public GtGastosExpoHinojosaDanfossConfiguration(string schema)
        {
            ToTable("GT_GastosExpoHinojosaDanfoss", schema);
            HasKey(x => x.NIdGastoHd);

            Property(x => x.NIdGastoHd).HasColumnName(@"nIdGastoHD").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdGastoD).HasColumnName(@"nIdGastoD").HasColumnType("int").IsOptional();
            Property(x => x.NIdGastoH).HasColumnName(@"nIdGastoH").HasColumnType("int").IsRequired();
            Property(x => x.NActivo).HasColumnName(@"nActivo").HasColumnType("int").IsRequired();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>