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

    // cat_emp_activ
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpActivConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatEmpActiv>
    {
        public CatEmpActivConfiguration()
            : this("dbo")
        {
        }

        public CatEmpActivConfiguration(string schema)
        {
            ToTable("cat_emp_activ", schema);
            HasKey(x => x.IdActividad);

            Property(x => x.IdActividad).HasColumnName(@"id_actividad").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRelActiv).HasColumnName(@"id_rel_activ").HasColumnType("int").IsRequired();
            Property(x => x.Actividad).HasColumnName(@"actividad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.IdPrd).HasColumnName(@"id_prd").HasColumnType("int").IsRequired();
            Property(x => x.Duracion).HasColumnName(@"duracion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdClas).HasColumnName(@"id_clas").HasColumnType("int").IsRequired();
            Property(x => x.Dias).HasColumnName(@"dias").HasColumnType("int").IsRequired();
            Property(x => x.Pond).HasColumnName(@"pond").HasColumnType("int").IsRequired();
            Property(x => x.IdLstActs).HasColumnName(@"id_lst_acts").HasColumnType("int").IsRequired();
            Property(x => x.DuraHr).HasColumnName(@"dura_hr").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DuraSegs).HasColumnName(@"dura_segs").HasColumnType("bigint").IsRequired();
            Property(x => x.PndAct).HasColumnName(@"pnd_act").HasColumnType("float").IsRequired();
            Property(x => x.CApl).HasColumnName(@"c_apl").HasColumnType("tinyint").IsRequired();
            Property(x => x.PndGrp).HasColumnName(@"pnd_grp").HasColumnType("float").IsRequired();
            Property(x => x.IdActLay).HasColumnName(@"id_act_lay").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
