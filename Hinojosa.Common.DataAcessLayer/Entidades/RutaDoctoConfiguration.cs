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

    // ruta_doctos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RutaDoctoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RutaDocto>
    {
        public RutaDoctoConfiguration()
            : this("dbo")
        {
        }

        public RutaDoctoConfiguration(string schema)
        {
            ToTable("ruta_doctos", schema);
            HasKey(x => new { x.Id, x.IdViaje, x.IdEvento, x.Extension, x.Descripcion, x.Tamanio, x.IdUsr, x.FecReg, x.Status });

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdViaje).HasColumnName(@"id_viaje").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdEvento).HasColumnName(@"id_evento").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Archivo).HasColumnName(@"archivo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Extension).HasColumnName(@"extension").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Imagen).HasColumnName(@"imagen").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Tamanio).HasColumnName(@"tamanio").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>