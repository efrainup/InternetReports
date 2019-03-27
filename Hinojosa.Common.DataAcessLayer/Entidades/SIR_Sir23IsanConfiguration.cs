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

    // SIR_23_ISAN
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir23IsanConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir23Isan>
    {
        public SIR_Sir23IsanConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir23IsanConfiguration(string schema)
        {
            ToTable("SIR_23_ISAN", schema);
            HasKey(x => x.NIdIsan23);

            Property(x => x.NIdIsan23).HasColumnName(@"nIdISAN23").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NValorLimInf).HasColumnName(@"nValorLimInf").HasColumnType("decimal").IsRequired().HasPrecision(9,2);
            Property(x => x.NValorLimSup).HasColumnName(@"nValorLimSup").HasColumnType("decimal").IsRequired().HasPrecision(9,2);
            Property(x => x.NCuotaFija).HasColumnName(@"nCuotaFija").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.NPorcentajeEx).HasColumnName(@"nPorcentajeEx").HasColumnType("decimal").IsRequired().HasPrecision(4,1);
            Property(x => x.NIdVer09).HasColumnName(@"nIdVer09").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir23Isan).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_23_ISAN_cat_usr_ed
        }
    }

}
// </auto-generated>