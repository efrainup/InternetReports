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

    // cat_puestos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatPuestoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatPuesto>
    {
        public CatPuestoConfiguration()
            : this("dbo")
        {
        }

        public CatPuestoConfiguration(string schema)
        {
            ToTable("cat_puestos", schema);
            HasKey(x => x.IdPuesto);

            Property(x => x.IdPuesto).HasColumnName(@"id_puesto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SalMin).HasColumnName(@"sal_min").HasColumnType("float").IsRequired();
            Property(x => x.SalMax).HasColumnName(@"sal_max").HasColumnType("float").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.CDir).HasColumnName(@"c_dir").HasColumnType("tinyint").IsRequired();
            Property(x => x.CGer).HasColumnName(@"c_ger").HasColumnType("tinyint").IsRequired();
            Property(x => x.CEmp).HasColumnName(@"c_emp").HasColumnType("tinyint").IsRequired();
            Property(x => x.CEve).HasColumnName(@"c_eve").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdOtrSis).HasColumnName(@"id_otr_sis").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.COper).HasColumnName(@"c_oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Des2).HasColumnName(@"des2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
        }
    }

}
// </auto-generated>
