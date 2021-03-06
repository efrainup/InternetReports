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

    // SIR_114_REGIMENES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir114RegimeneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir114Regimene>
    {
        public SIR_Sir114RegimeneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir114RegimeneConfiguration(string schema)
        {
            ToTable("SIR_114_REGIMENES", schema);
            HasKey(x => x.NIdReg114);

            Property(x => x.NIdReg114).HasColumnName(@"nIdReg114").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.NRegistro).HasColumnName(@"nRegistro").HasColumnType("int").IsRequired();
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir114Regimene).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_114_REGIMENES_cat_usr_ed
        }
    }

}
// </auto-generated>
