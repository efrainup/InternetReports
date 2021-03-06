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

    // SIR_75_TIPOS_GARANTIA_REVAL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir75TiposGarantiaRevalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir75TiposGarantiaReval>
    {
        public SIR_Sir75TiposGarantiaRevalConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir75TiposGarantiaRevalConfiguration(string schema)
        {
            ToTable("SIR_75_TIPOS_GARANTIA_REVAL", schema);
            HasKey(x => x.NIdTipoGarantia75);

            Property(x => x.NIdTipoGarantia75).HasColumnName(@"nIdTipoGarantia75").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir75TiposGarantiaReval).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_75_TIPOS_GARANTIA_REVAL_cat_usr_ed
        }
    }

}
// </auto-generated>
