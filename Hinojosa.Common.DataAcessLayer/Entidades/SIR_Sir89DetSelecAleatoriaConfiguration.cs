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

    // SIR_89_DET_SELEC_ALEATORIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir89DetSelecAleatoriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir89DetSelecAleatoria>
    {
        public SIR_Sir89DetSelecAleatoriaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir89DetSelecAleatoriaConfiguration(string schema)
        {
            ToTable("SIR_89_DET_SELEC_ALEATORIA", schema);
            HasKey(x => x.NIdDetSelAle89);

            Property(x => x.NIdDetSelAle89).HasColumnName(@"nIdDetSelAle89").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NPrimeraSel).HasColumnName(@"nPrimeraSel").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaPrimSel).HasColumnName(@"dFechaPrimSel").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NSegundaSel).HasColumnName(@"nSegundaSel").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaSegSel).HasColumnName(@"dFechaSegSel").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NTerceraSel).HasColumnName(@"nTerceraSel").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaTerSel).HasColumnName(@"dFechaTerSel").HasColumnType("smalldatetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir89DetSelecAleatoria).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_89_DET_SELEC_ALEATORIA_cat_usr_ed
        }
    }

}
// </auto-generated>
