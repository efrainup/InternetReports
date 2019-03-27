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

    // mcp_suc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class McpSucConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<McpSuc>
    {
        public McpSucConfiguration()
            : this("dbo")
        {
        }

        public McpSucConfiguration(string schema)
        {
            ToTable("mcp_suc", schema);
            HasKey(x => x.IdSuc);

            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired();
            Property(x => x.Suc).HasColumnName(@"suc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Nom).HasColumnName(@"nom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.Nom2).HasColumnName(@"nom2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Dir).HasColumnName(@"dir").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Calle).HasColumnName(@"calle").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Noint).HasColumnName(@"noint").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Noext).HasColumnName(@"noext").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Entrecalles).HasColumnName(@"entrecalles").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Colonia).HasColumnName(@"colonia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Delegacion).HasColumnName(@"delegacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ciudad).HasColumnName(@"ciudad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.IdEdo).HasColumnName(@"id_edo").HasColumnType("int").IsRequired();
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsRequired();
            Property(x => x.Cp).HasColumnName(@"CP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Tel1).HasColumnName(@"tel1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Tel2).HasColumnName(@"tel2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Email).HasColumnName(@"email").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Url).HasColumnName(@"url").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Fax).HasColumnName(@"fax").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ruta).HasColumnName(@"ruta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmP).HasColumnName(@"id_alm_p").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmE).HasColumnName(@"id_alm_e").HasColumnType("int").IsRequired();
            Property(x => x.CZonFrn).HasColumnName(@"c_zon_frn").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdRelFaDa).HasColumnName(@"id_rel_fa_da").HasColumnType("int").IsRequired();
            Property(x => x.CfdDirExp).HasColumnName(@"cfd_dir_exp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.CUsaSorf).HasColumnName(@"c_usa_sorf").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdJurisdiccion).HasColumnName(@"id_jurisdiccion").HasColumnType("int").IsRequired();
            Property(x => x.IdSucursal).HasColumnName(@"id_sucursal").HasColumnType("int").IsRequired();
            Property(x => x.IdCategoria).HasColumnName(@"id_categoria").HasColumnType("int").IsRequired();
            Property(x => x.Clues).HasColumnName(@"Clues").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.IdExterno).HasColumnName(@"id_externo").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>