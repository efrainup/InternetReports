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

    // cat_emp_est
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpEstConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatEmpEst>
    {
        public CatEmpEstConfiguration()
            : this("dbo")
        {
        }

        public CatEmpEstConfiguration(string schema)
        {
            ToTable("cat_emp_est", schema);
            HasKey(x => x.IdEst);

            Property(x => x.IdEst).HasColumnName(@"id_est").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelEst).HasColumnName(@"id_rel_est").HasColumnType("int").IsRequired();
            Property(x => x.Grado).HasColumnName(@"grado").HasColumnType("tinyint").IsRequired();
            Property(x => x.Estudio).HasColumnName(@"estudio").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Escuela).HasColumnName(@"escuela").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cedula).HasColumnName(@"cedula").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdNivel).HasColumnName(@"id_nivel").HasColumnType("tinyint").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecIni).HasColumnName(@"fec_ini").HasColumnType("datetime").IsRequired();
            Property(x => x.FecFin).HasColumnName(@"fec_fin").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
