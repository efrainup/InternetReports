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

    // XmlLayout_GridModulo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class XmlLayoutGridModuloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XmlLayoutGridModulo>
    {
        public XmlLayoutGridModuloConfiguration()
            : this("dbo")
        {
        }

        public XmlLayoutGridModuloConfiguration(string schema)
        {
            ToTable("XmlLayout_GridModulo", schema);
            HasKey(x => new { x.IdLayout, x.IdUsr, x.IdRec, x.IdMod, x.Descripcion, x.NombreView });

            Property(x => x.IdLayout).HasColumnName(@"id_layout").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRec).HasColumnName(@"id_rec").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdMod).HasColumnName(@"id_mod").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xml).HasColumnName(@"XML").HasColumnType("xml").IsOptional();
            Property(x => x.XmlN1).HasColumnName(@"XML_N1").HasColumnType("xml").IsOptional();
            Property(x => x.@Default).HasColumnName(@"default").HasColumnType("bit").IsOptional();
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NombreView).HasColumnName(@"nombre_view").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
