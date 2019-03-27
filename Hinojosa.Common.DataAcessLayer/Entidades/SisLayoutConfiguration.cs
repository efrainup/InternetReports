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

    // sis_layout
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisLayoutConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisLayout>
    {
        public SisLayoutConfiguration()
            : this("dbo")
        {
        }

        public SisLayoutConfiguration(string schema)
        {
            ToTable("sis_layout", schema);
            HasKey(x => x.IdLayout);

            Property(x => x.IdLayout).HasColumnName(@"id_layout").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRec).HasColumnName(@"id_rec").HasColumnType("int").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Layout).HasColumnName(@"layout").HasColumnType("xml").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"Tipo").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
// </auto-generated>