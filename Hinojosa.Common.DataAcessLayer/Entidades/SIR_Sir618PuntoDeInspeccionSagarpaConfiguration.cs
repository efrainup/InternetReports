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

    // SIR_618_PUNTO_DE_INSPECCION_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir618PuntoDeInspeccionSagarpaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir618PuntoDeInspeccionSagarpa>
    {
        public SIR_Sir618PuntoDeInspeccionSagarpaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir618PuntoDeInspeccionSagarpaConfiguration(string schema)
        {
            ToTable("SIR_618_PUNTO_DE_INSPECCION_SAGARPA", schema);
            HasKey(x => x.NIdPuntoDeInspeccion618);

            Property(x => x.NIdPuntoDeInspeccion618).HasColumnName(@"nIdPuntoDeInspeccion618").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SAcronimo).HasColumnName(@"sAcronimo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.NIdEntidadFed608).HasColumnName(@"nIdEntidadFed608").HasColumnType("int").IsOptional();
            Property(x => x.NDependencia).HasColumnName(@"nDependencia").HasColumnType("int").IsOptional();
            Property(x => x.DInicioVigencia).HasColumnName(@"dInicioVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.DTerminoVigencia).HasColumnName(@"dTerminoVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir608EntidadFederativaSagarpa).WithMany(b => b.SIR_Sir618PuntoDeInspeccionSagarpa).HasForeignKey(c => c.NIdEntidadFed608).WillCascadeOnDelete(false); // FK_SIR_618_PUNTO_DE_INSPECCION_SAGARPA_SIR_608_ENTIDAD_FEDERATIVA_SAGARPA
        }
    }

}
// </auto-generated>
