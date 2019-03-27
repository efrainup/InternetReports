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

    // sis_img_rec
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisImgRecConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisImgRec>
    {
        public crm_SisImgRecConfiguration()
            : this("crm")
        {
        }

        public crm_SisImgRecConfiguration(string schema)
        {
            ToTable("sis_img_rec", schema);
            HasKey(x => x.IdImg);

            Property(x => x.IdImg).HasColumnName(@"id_img").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ruta).HasColumnName(@"ruta").HasColumnType("text").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
        }
    }

}
// </auto-generated>