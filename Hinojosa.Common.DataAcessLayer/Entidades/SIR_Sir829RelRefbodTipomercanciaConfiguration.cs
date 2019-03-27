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

    // SIR_829_REL_REFBOD_TIPOMERCANCIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir829RelRefbodTipomercanciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir829RelRefbodTipomercancia>
    {
        public SIR_Sir829RelRefbodTipomercanciaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir829RelRefbodTipomercanciaConfiguration(string schema)
        {
            ToTable("SIR_829_REL_REFBOD_TIPOMERCANCIA", schema);
            HasKey(x => new { x.NIdEntrada156, x.NIdTipoMerc80 });

            Property(x => x.NIdTipoMerc80).HasColumnName(@"nIdTipoMerc80").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir156EntradasBodega).WithMany(b => b.SIR_Sir829RelRefbodTipomercancia).HasForeignKey(c => c.NIdEntrada156).WillCascadeOnDelete(false); // FK_SIR_829_REL_REFBOD_TIPOMERCANCIA_SIR_156_ENTRADAS_BODEGAS
            HasRequired(a => a.SIR_Sir80TiposMercancia).WithMany(b => b.SIR_Sir829RelRefbodTipomercancia).HasForeignKey(c => c.NIdTipoMerc80).WillCascadeOnDelete(false); // FK_SIR_829_REL_REFBOD_TIPOMERCANCIA_SIR_80_TIPOS_MERCANCIA
        }
    }

}
// </auto-generated>