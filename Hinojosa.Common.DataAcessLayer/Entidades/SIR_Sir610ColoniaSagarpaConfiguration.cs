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

    // SIR_610_COLONIA_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir610ColoniaSagarpaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir610ColoniaSagarpa>
    {
        public SIR_Sir610ColoniaSagarpaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir610ColoniaSagarpaConfiguration(string schema)
        {
            ToTable("SIR_610_COLONIA_SAGARPA", schema);
            HasKey(x => x.NIdColSagarpa610);

            Property(x => x.NIdColSagarpa610).HasColumnName(@"nIdColSAGARPA610").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdDelMun609).HasColumnName(@"nIdDelMun609").HasColumnType("int").IsRequired();
            Property(x => x.SNombre).HasColumnName(@"sNombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.DCaptura).HasColumnName(@"dCaptura").HasColumnType("datetime").IsOptional();
            Property(x => x.SClaveLocalidad).HasColumnName(@"sClaveLocalidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.SCp).HasColumnName(@"sCP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.SSatColonyCd).HasColumnName(@"sSATColony_CD").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(9);
            Property(x => x.DInicioVigencia).HasColumnName(@"dInicioVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.DTerminoVigencia).HasColumnName(@"dTerminoVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir609DelegacionMunicipioSagarpa).WithMany(b => b.SIR_Sir610ColoniaSagarpa).HasForeignKey(c => c.NIdDelMun609).WillCascadeOnDelete(false); // FK_SIR_610_COLONIA_SAGARPA_SIR_609_DELEGACION_MUNICIPIO_SAGARPA
        }
    }

}
// </auto-generated>
