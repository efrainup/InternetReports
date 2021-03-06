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

    // cat_emp_promo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpPromoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatEmpPromo>
    {
        public CatEmpPromoConfiguration()
            : this("dbo")
        {
        }

        public CatEmpPromoConfiguration(string schema)
        {
            ToTable("cat_emp_promo", schema);
            HasKey(x => x.IdPromo);

            Property(x => x.IdPromo).HasColumnName(@"id_promo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FecInicio).HasColumnName(@"fec_inicio").HasColumnType("datetime").IsRequired();
            Property(x => x.FecTermino).HasColumnName(@"fec_termino").HasColumnType("datetime").IsRequired();
            Property(x => x.IdPuesto).HasColumnName(@"id_puesto").HasColumnType("int").IsRequired();
            Property(x => x.SueldoBto).HasColumnName(@"sueldo_bto").HasColumnType("float").IsRequired();
            Property(x => x.IdRelPromo).HasColumnName(@"id_rel_promo").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdTipModSal).HasColumnName(@"id_tip_mod_sal").HasColumnType("int").IsRequired();
            Property(x => x.CModSal).HasColumnName(@"c_mod_sal").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdDepto).HasColumnName(@"id_depto").HasColumnType("int").IsRequired();
            Property(x => x.SueldoIni).HasColumnName(@"sueldo_ini").HasColumnType("float").IsRequired();
            Property(x => x.Empresa).HasColumnName(@"empresa").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Puesto).HasColumnName(@"puesto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Depto).HasColumnName(@"depto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
        }
    }

}
// </auto-generated>
