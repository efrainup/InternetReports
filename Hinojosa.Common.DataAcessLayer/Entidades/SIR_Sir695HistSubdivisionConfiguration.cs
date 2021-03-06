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

    // SIR_695_HIST_SUBDIVISION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir695HistSubdivisionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir695HistSubdivision>
    {
        public SIR_Sir695HistSubdivisionConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir695HistSubdivisionConfiguration(string schema)
        {
            ToTable("SIR_695_HIST_SUBDIVISION", schema);
            HasKey(x => x.NIdHistSubdivision695);

            Property(x => x.NIdHistSubdivision695).HasColumnName(@"nIdHistSubdivision695").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferenciaOrig60).HasColumnName(@"nIdReferenciaOrig60").HasColumnType("int").IsOptional();
            Property(x => x.NIdReferenciaSub60).HasColumnName(@"nIdReferenciaSub60").HasColumnType("int").IsOptional();
            Property(x => x.NIdEntradaOrig156).HasColumnName(@"nIdEntradaOrig156").HasColumnType("int").IsOptional();
            Property(x => x.NIdEntradaSub156).HasColumnName(@"nIdEntradaSub156").HasColumnType("int").IsOptional();
            Property(x => x.NIdSubdivision).HasColumnName(@"nIdSubdivision").HasColumnType("int").IsRequired();
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir156EntradasBodega_NIdEntradaOrig156).WithMany(b => b.SIR_Sir695HistSubdivision_NIdEntradaOrig156).HasForeignKey(c => c.NIdEntradaOrig156).WillCascadeOnDelete(false); // FK_SIR_695_HIST_SUBDIVISION_SIR_156_ENTRADAS_BODEGAS_ORIG
            HasOptional(a => a.SIR_Sir156EntradasBodega_NIdEntradaSub156).WithMany(b => b.SIR_Sir695HistSubdivision_NIdEntradaSub156).HasForeignKey(c => c.NIdEntradaSub156).WillCascadeOnDelete(false); // FK_SIR_695_HIST_SUBDIVISION_SIR_156_ENTRADAS_BODEGAS_SUB
            HasOptional(a => a.SIR_Sir60Referencia_NIdReferenciaOrig60).WithMany(b => b.SIR_Sir695HistSubdivision_NIdReferenciaOrig60).HasForeignKey(c => c.NIdReferenciaOrig60).WillCascadeOnDelete(false); // FK_SIR_695_HIST_SUBDIVISION_SIR_60_REFERENCIAS_ORIG
            HasOptional(a => a.SIR_Sir60Referencia_NIdReferenciaSub60).WithMany(b => b.SIR_Sir695HistSubdivision_NIdReferenciaSub60).HasForeignKey(c => c.NIdReferenciaSub60).WillCascadeOnDelete(false); // FK_SIR_695_HIST_SUBDIVISION_SIR_60_REFERENCIAS_SUB
        }
    }

}
// </auto-generated>
