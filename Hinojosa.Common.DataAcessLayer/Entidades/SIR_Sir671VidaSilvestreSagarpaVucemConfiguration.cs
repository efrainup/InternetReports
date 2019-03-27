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

    // SIR_671_VIDA_SILVESTRE_SAGARPA_VUCEM
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir671VidaSilvestreSagarpaVucemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir671VidaSilvestreSagarpaVucem>
    {
        public SIR_Sir671VidaSilvestreSagarpaVucemConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir671VidaSilvestreSagarpaVucemConfiguration(string schema)
        {
            ToTable("SIR_671_VIDA_SILVESTRE_SAGARPA_VUCEM", schema);
            HasKey(x => x.NIdVidaSilvestre671);

            Property(x => x.NIdVidaSilvestre671).HasColumnName(@"nIdVidaSilvestre671").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(800);
            Property(x => x.DInicioVigencia).HasColumnName(@"dInicioVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.DTerminoVigencia).HasColumnName(@"dTerminoVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>
