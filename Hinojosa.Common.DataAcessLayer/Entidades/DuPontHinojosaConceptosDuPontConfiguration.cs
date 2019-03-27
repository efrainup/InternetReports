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

    // DuPontHinojosa_Conceptos_DuPont
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DuPontHinojosaConceptosDuPontConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DuPontHinojosaConceptosDuPont>
    {
        public DuPontHinojosaConceptosDuPontConfiguration()
            : this("dbo")
        {
        }

        public DuPontHinojosaConceptosDuPontConfiguration(string schema)
        {
            ToTable("DuPontHinojosa_Conceptos_DuPont", schema);
            HasKey(x => new { x.NIdConcepto, x.SConcepto, x.NStatus, x.DFechaAlta });

            Property(x => x.NIdConcepto).HasColumnName(@"nIdConcepto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SConcepto).HasColumnName(@"sConcepto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>