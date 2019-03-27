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

    // SIR_133_CAMPOS_VALIDA_DESPACHO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir133CamposValidaDespachoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir133CamposValidaDespacho>
    {
        public SIR_Sir133CamposValidaDespachoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir133CamposValidaDespachoConfiguration(string schema)
        {
            ToTable("SIR_133_CAMPOS_VALIDA_DESPACHO", schema);
            HasKey(x => x.NIdCampValDesp133);

            Property(x => x.NIdCampValDesp133).HasColumnName(@"nIdCampValDesp133").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SCampo).HasColumnName(@"sCampo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SPropiedad).HasColumnName(@"sPropiedad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            HasMany(t => t.SIR_Sir129TiposDespacho).WithMany(t => t.SIR_Sir133CamposValidaDespacho).Map(m =>
            {
                m.ToTable("SIR_357_VALIDACIONES_DESPACHOS", "SIR");
                m.MapLeftKey("nIdCampValDesp133");
                m.MapRightKey("nIdTipoDesp129");
            });
        }
    }

}
// </auto-generated>