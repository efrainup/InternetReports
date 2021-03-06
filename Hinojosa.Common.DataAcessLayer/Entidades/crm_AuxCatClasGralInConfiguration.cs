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

    // aux_cat_clas_gral_ins
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_AuxCatClasGralInConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_AuxCatClasGralIn>
    {
        public crm_AuxCatClasGralInConfiguration()
            : this("crm")
        {
        }

        public crm_AuxCatClasGralInConfiguration(string schema)
        {
            ToTable("aux_cat_clas_gral_ins", schema);
            HasKey(x => new { x.IdClasGral, x.Sistema, x.CMul, x.CCtb, x.BRepetido });

            Property(x => x.IdClasGral).HasColumnName(@"id_clas_gral").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Cuenta).HasColumnName(@"cuenta").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsOptional();
            Property(x => x.Sistema).HasColumnName(@"sistema").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tipoobj).HasColumnName(@"tipoobj").HasColumnType("int").IsOptional();
            Property(x => x.CMul).HasColumnName(@"c_mul").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CCtb).HasColumnName(@"c_ctb").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BRepetido).HasColumnName(@"b_repetido").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
