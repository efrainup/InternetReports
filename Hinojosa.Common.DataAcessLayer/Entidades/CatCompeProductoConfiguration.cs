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

    // cat_compe_productos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatCompeProductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatCompeProducto>
    {
        public CatCompeProductoConfiguration()
            : this("dbo")
        {
        }

        public CatCompeProductoConfiguration(string schema)
        {
            ToTable("cat_compe_productos", schema);
            HasKey(x => new { x.IdCompe, x.IdProd, x.FecReg });

            Property(x => x.IdCompe).HasColumnName(@"id_compe").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdProd).HasColumnName(@"id_Prod").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdProd1G).HasColumnName(@"id_Prod_1G").HasColumnType("int").IsOptional();
            Property(x => x.Nombre).HasColumnName(@"nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.NombreCorto).HasColumnName(@"nombre_corto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsOptional();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsOptional();
            Property(x => x.IdUdmVta).HasColumnName(@"id_udm_vta").HasColumnType("int").IsOptional();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsOptional();
            Property(x => x.FecReg).HasColumnName(@"Fec_reg").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cantidad).HasColumnName(@"cantidad").HasColumnType("float").IsOptional();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsOptional();
            Property(x => x.IdUdmDest).HasColumnName(@"id_udm_dest").HasColumnType("int").IsOptional();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsOptional();
        }
    }

}
// </auto-generated>