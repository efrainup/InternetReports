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

    // SIRA_14_CONTROLES_PROPIEDADES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira14ControlesPropiedadeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira14ControlesPropiedade>
    {
        public SIRAdmin_Sira14ControlesPropiedadeConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira14ControlesPropiedadeConfiguration(string schema)
        {
            ToTable("SIRA_14_CONTROLES_PROPIEDADES", schema);
            HasKey(x => x.NIdProp14);

            Property(x => x.NIdProp14).HasColumnName(@"nIdProp14").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdControl13).HasColumnName(@"nIdControl13").HasColumnType("int").IsRequired();
            Property(x => x.NItem).HasColumnName(@"nItem").HasColumnType("tinyint").IsOptional();
            Property(x => x.STexto).HasColumnName(@"sTexto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.NIdTipoTrafico25).HasColumnName(@"nIdTipoTrafico25").HasColumnType("int").IsOptional();
            Property(x => x.NIdioma).HasColumnName(@"nIdioma").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir25TiposTrafico).WithMany(b => b.SIRAdmin_Sira14ControlesPropiedade).HasForeignKey(c => c.NIdTipoTrafico25).WillCascadeOnDelete(false); // FK_SIRA_14_CONTROLES_PROPIEDADES_SIR_25_TIPOS_TRAFICO
            HasRequired(a => a.SIRAdmin_Sira13ControlesSistema).WithMany(b => b.SIRAdmin_Sira14ControlesPropiedade).HasForeignKey(c => c.NIdControl13); // FK_SIRA_14_CONTROLES_PROPIEDADES_SIRA_13_CONTROLES_SISTEMA
        }
    }

}
// </auto-generated>
