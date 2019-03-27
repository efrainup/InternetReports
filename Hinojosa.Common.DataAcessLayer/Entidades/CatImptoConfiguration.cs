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

    // cat_impto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatImptoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatImpto>
    {
        public CatImptoConfiguration()
            : this("dbo")
        {
        }

        public CatImptoConfiguration(string schema)
        {
            ToTable("cat_impto", schema);
            HasKey(x => x.IdImpto);

            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecRec).HasColumnName(@"fec_rec").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdImptoCmp).HasColumnName(@"id_impto_cmp").HasColumnType("tinyint").IsRequired();
            Property(x => x.CPagImp).HasColumnName(@"c_pag_imp").HasColumnType("tinyint").IsRequired();
            Property(x => x.CZonFrn).HasColumnName(@"c_zon_frn").HasColumnType("tinyint").IsRequired();
            Property(x => x.CIvaImp).HasColumnName(@"c_iva_imp").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdOtrSis).HasColumnName(@"id_otr_sis").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
        }
    }

}
// </auto-generated>