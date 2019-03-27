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

    // SIR_565_SALARIO_MINIMO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir565SalarioMinimoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir565SalarioMinimo>
    {
        public SIR_Sir565SalarioMinimoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir565SalarioMinimoConfiguration(string schema)
        {
            ToTable("SIR_565_SALARIO_MINIMO", schema);
            HasKey(x => x.NIdSalarioMin);

            Property(x => x.NIdSalarioMin).HasColumnName(@"nIdSalarioMin").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NValor).HasColumnName(@"nValor").HasColumnType("decimal").IsOptional().HasPrecision(14,4);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
