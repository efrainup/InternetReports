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

    // SIR_377_DOCUMENTOS_ANEXADOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir377DocumentosAnexadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir377DocumentosAnexado>
    {
        public SIR_Sir377DocumentosAnexadoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir377DocumentosAnexadoConfiguration(string schema)
        {
            ToTable("SIR_377_DOCUMENTOS_ANEXADOS", schema);
            HasKey(x => x.NIdDoctosAnexados377);

            Property(x => x.NIdDoctosAnexados377).HasColumnName(@"nIdDoctosAnexados377").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdManValor251).HasColumnName(@"nIdManValor251").HasColumnType("int").IsRequired();
            Property(x => x.SDoctoAnexado).HasColumnName(@"sDoctoAnexado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(254);
            Property(x => x.SMercancia).HasColumnName(@"sMercancia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(254);
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir377DocumentosAnexado).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_377_DOCUMENTOS_ANEXADOS_SIR_42_PROVEEDORES
            HasRequired(a => a.SIR_Sir251ManifestacionesValor).WithMany(b => b.SIR_Sir377DocumentosAnexado).HasForeignKey(c => c.NIdManValor251).WillCascadeOnDelete(false); // FK_SIR_377_DOCUMENTOS_ANEXADOS_SIR_251_MANIFESTACIONES_VALOR
        }
    }

}
// </auto-generated>