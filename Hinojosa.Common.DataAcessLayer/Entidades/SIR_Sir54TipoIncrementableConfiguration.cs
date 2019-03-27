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

    // SIR_54_TIPO_INCREMENTABLES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir54TipoIncrementableConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir54TipoIncrementable>
    {
        public SIR_Sir54TipoIncrementableConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir54TipoIncrementableConfiguration(string schema)
        {
            ToTable("SIR_54_TIPO_INCREMENTABLES", schema);
            HasKey(x => x.NIdTipoIncrementable54);

            Property(x => x.NIdTipoIncrementable54).HasColumnName(@"nIdTipoIncrementable54").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.NRegistro).HasColumnName(@"nRegistro").HasColumnType("int").IsRequired();
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir54TipoIncrementable).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_54_TIPO_INCREMENTABLES_cat_usr_ed
        }
    }

}
// </auto-generated>
