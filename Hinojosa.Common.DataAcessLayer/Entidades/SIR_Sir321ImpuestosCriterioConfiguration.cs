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

    // SIR_321_IMPUESTOS_CRITERIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir321ImpuestosCriterioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir321ImpuestosCriterio>
    {
        public SIR_Sir321ImpuestosCriterioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir321ImpuestosCriterioConfiguration(string schema)
        {
            ToTable("SIR_321_IMPUESTOS_CRITERIOS", schema);
            HasKey(x => new { x.NIdRegCri320, x.NIdTiposImp30, x.NAplica });

            Property(x => x.NIdRegCri320).HasColumnName(@"nIdRegCri320").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdTiposImp30).HasColumnName(@"nIdTiposImp30").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NAplica).HasColumnName(@"nAplica").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.SIR_Sir30TiposImpuesto).WithMany(b => b.SIR_Sir321ImpuestosCriterio).HasForeignKey(c => c.NIdTiposImp30).WillCascadeOnDelete(false); // FK_SIR_321_IMPUESTOS_CRITERIOS_SIR_30_TIPOS_IMPUESTOS
            HasRequired(a => a.SIR_Sir320ReglasCriterio).WithMany(b => b.SIR_Sir321ImpuestosCriterio).HasForeignKey(c => c.NIdRegCri320).WillCascadeOnDelete(false); // FK_SIR_321_IMPUESTOS_CRITERIOS_SIR_320_REGLAS_CRITERIOS
        }
    }

}
// </auto-generated>
