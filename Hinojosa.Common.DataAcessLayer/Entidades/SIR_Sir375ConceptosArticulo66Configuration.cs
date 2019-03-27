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

    // SIR_375_CONCEPTOS_ARTICULO66
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir375ConceptosArticulo66Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir375ConceptosArticulo66>
    {
        public SIR_Sir375ConceptosArticulo66Configuration()
            : this("SIR")
        {
        }

        public SIR_Sir375ConceptosArticulo66Configuration(string schema)
        {
            ToTable("SIR_375_CONCEPTOS_ARTICULO66", schema);
            HasKey(x => x.NIdConArt375);

            Property(x => x.NIdConArt375).HasColumnName(@"nIdConArt375").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdManValor251).HasColumnName(@"nIdManValor251").HasColumnType("int").IsRequired();
            Property(x => x.SNumero).HasColumnName(@"sNumero").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.SMercancia).HasColumnName(@"sMercancia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(254);
            Property(x => x.SFacturaDocumento).HasColumnName(@"sFacturaDocumento").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(254);
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("decimal").IsOptional().HasPrecision(16,2);
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.SConcepto).HasColumnName(@"sConcepto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(254);
            Property(x => x.NTipoConcepto).HasColumnName(@"nTipoConcepto").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir03Moneda).WithMany(b => b.SIR_Sir375ConceptosArticulo66).HasForeignKey(c => c.NIdMoneda03).WillCascadeOnDelete(false); // FK_SIR_375_CONCEPTOS_ARTICULO66_SIR_03_MONEDAS
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir375ConceptosArticulo66).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_375_CONCEPTOS_ARTICULO66_SIR_42_PROVEEDORES
            HasRequired(a => a.SIR_Sir251ManifestacionesValor).WithMany(b => b.SIR_Sir375ConceptosArticulo66).HasForeignKey(c => c.NIdManValor251).WillCascadeOnDelete(false); // FK_SIR_375_CONCEPTOS_ARTICULO66_SIR_251_MANIFESTACIONES_VALOR
        }
    }

}
// </auto-generated>
