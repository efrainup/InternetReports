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

    // SIR_279_ERRORES_CARTASCUPO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir279ErroresCartascupoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir279ErroresCartascupo>
    {
        public SIR_Sir279ErroresCartascupoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir279ErroresCartascupoConfiguration(string schema)
        {
            ToTable("SIR_279_ERRORES_CARTASCUPO", schema);
            HasKey(x => x.NIdErrorCc279);

            Property(x => x.NIdErrorCc279).HasColumnName(@"nIdErrorCC279").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SNumeroRegistro).HasColumnName(@"sNumeroRegistro").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SNumeroCampo).HasColumnName(@"sNumeroCampo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.STipo).HasColumnName(@"sTipo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SNumero).HasColumnName(@"sNumero").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir279ErroresCartascupo).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_279_ERRORES_CARTASCUPO_cat_usr_ed
        }
    }

}
// </auto-generated>
