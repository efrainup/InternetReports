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

    // cat_actas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatActaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatActa>
    {
        public CatActaConfiguration()
            : this("dbo")
        {
        }

        public CatActaConfiguration(string schema)
        {
            ToTable("cat_actas", schema);
            HasKey(x => x.IdTipAct);

            Property(x => x.IdTipAct).HasColumnName(@"id_tip_act").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nombre).HasColumnName(@"nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsOptional();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsOptional();
            Property(x => x.Modfech).HasColumnName(@"modfech").HasColumnType("datetime").IsOptional();
            Property(x => x.Regfech).HasColumnName(@"regfech").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
