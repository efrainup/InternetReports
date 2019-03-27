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

    // SIR_378_VALOR_PROVISIONAL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir378ValorProvisionalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir378ValorProvisional>
    {
        public SIR_Sir378ValorProvisionalConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir378ValorProvisionalConfiguration(string schema)
        {
            ToTable("SIR_378_VALOR_PROVISIONAL", schema);
            HasKey(x => x.NIdValorProvisional378);

            Property(x => x.NIdValorProvisional378).HasColumnName(@"nIdValorProvisional378").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdManValor251).HasColumnName(@"nIdManValor251").HasColumnType("int").IsRequired();
            Property(x => x.STipoMercancia).HasColumnName(@"sTipoMercancia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(254);
            Property(x => x.NValorProvisional).HasColumnName(@"nValorProvisional").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir378ValorProvisional).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_378_VALOR_PROVISIONAL_SIR_42_PROVEEDORES
            HasRequired(a => a.SIR_Sir251ManifestacionesValor).WithMany(b => b.SIR_Sir378ValorProvisional).HasForeignKey(c => c.NIdManValor251).WillCascadeOnDelete(false); // FK_SIR_378_VALOR_PROVISIONAL_SIR_251_MANIFESTACIONES_VALOR
        }
    }

}
// </auto-generated>