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

    // SIR_98_RECARGOS_IGIE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir98RecargosIgieConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir98RecargosIgie>
    {
        public SIR_Sir98RecargosIgieConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir98RecargosIgieConfiguration(string schema)
        {
            ToTable("SIR_98_RECARGOS_IGIE", schema);
            HasKey(x => x.NIdRecargos98);

            Property(x => x.NIdRecargos98).HasColumnName(@"nIdRecargos98").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NTarifa).HasColumnName(@"nTarifa").HasColumnType("decimal").IsRequired().HasPrecision(4,3);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir98RecargosIgie).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_98_RECARGOS_IGIE_cat_usr_ed
        }
    }

}
// </auto-generated>
