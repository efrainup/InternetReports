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

    // sis_layout_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisLayoutDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisLayoutDet>
    {
        public SisLayoutDetConfiguration()
            : this("dbo")
        {
        }

        public SisLayoutDetConfiguration(string schema)
        {
            ToTable("sis_layout_det", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdL).HasColumnName(@"id_l").HasColumnType("int").IsOptional();
            Property(x => x.Nombre).HasColumnName(@"nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Tamanio).HasColumnName(@"tamanio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Obligatorio).HasColumnName(@"obligatorio").HasColumnType("tinyint").IsOptional();
            Property(x => x.EquiPant).HasColumnName(@"equi_pant").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FormatOri).HasColumnName(@"format_ori").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
