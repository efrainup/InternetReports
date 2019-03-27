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

    // rh_reg_asi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RhRegAsiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RhRegAsi>
    {
        public RhRegAsiConfiguration()
            : this("dbo")
        {
        }

        public RhRegAsiConfiguration(string schema)
        {
            ToTable("rh_reg_asi", schema);
            HasKey(x => x.IdRegAsi);

            Property(x => x.IdRegAsi).HasColumnName(@"id_reg_asi").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.IdPuesto).HasColumnName(@"id_puesto").HasColumnType("int").IsRequired();
            Property(x => x.IdDepto).HasColumnName(@"id_depto").HasColumnType("int").IsRequired();
            Property(x => x.IdTipInc).HasColumnName(@"id_tip_inc").HasColumnType("int").IsRequired();
            Property(x => x.Valor).HasColumnName(@"valor").HasColumnType("tinyint").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.IdTipTur).HasColumnName(@"id_tip_tur").HasColumnType("int").IsRequired();
            Property(x => x.MinRet).HasColumnName(@"min_ret").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsrMod).HasColumnName(@"id_usr_mod").HasColumnType("int").IsRequired();
            Property(x => x.FecRegMod).HasColumnName(@"fec_reg_mod").HasColumnType("datetime").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpReg).HasColumnName(@"id_emp_reg").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpMod).HasColumnName(@"id_emp_mod").HasColumnType("int").IsRequired();
            Property(x => x.Area).HasColumnName(@"area").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>