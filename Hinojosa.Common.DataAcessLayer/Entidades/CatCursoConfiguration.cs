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

    // cat_cursos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatCursoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatCurso>
    {
        public CatCursoConfiguration()
            : this("dbo")
        {
        }

        public CatCursoConfiguration(string schema)
        {
            ToTable("cat_cursos", schema);
            HasKey(x => x.IdCur);

            Property(x => x.IdCur).HasColumnName(@"id_cur").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CveCur).HasColumnName(@"cve_cur").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.TipCur).HasColumnName(@"tip_cur").HasColumnType("tinyint").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Sede).HasColumnName(@"sede").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.Nivel).HasColumnName(@"nivel").HasColumnType("tinyint").IsRequired();
            Property(x => x.ValCur).HasColumnName(@"val_cur").HasColumnType("tinyint").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.Dura).HasColumnName(@"dura").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdRelCurTem).HasColumnName(@"id_rel_cur_tem").HasColumnType("int").IsRequired();
            Property(x => x.CStps).HasColumnName(@"c_stps").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>