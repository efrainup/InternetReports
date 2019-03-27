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

    // MT_Gasto_Mabe_Hinojosa
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MtGastoMabeHinojosaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MtGastoMabeHinojosa>
    {
        public MtGastoMabeHinojosaConfiguration()
            : this("dbo")
        {
        }

        public MtGastoMabeHinojosaConfiguration(string schema)
        {
            ToTable("MT_Gasto_Mabe_Hinojosa", schema);
            HasKey(x => x.NIdGasto);

            Property(x => x.NIdGasto).HasColumnName(@"nIdGasto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdGHinojosa).HasColumnName(@"nIdGHinojosa").HasColumnType("int").IsRequired();
            Property(x => x.NIdGMabe).HasColumnName(@"nIdGMabe").HasColumnType("int").IsRequired();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired();
            Property(x => x.NActivo).HasColumnName(@"nActivo").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>