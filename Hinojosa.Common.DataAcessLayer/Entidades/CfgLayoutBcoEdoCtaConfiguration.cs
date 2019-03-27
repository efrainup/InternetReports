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

    // cfg_layout_bco_edo_cta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgLayoutBcoEdoCtaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CfgLayoutBcoEdoCta>
    {
        public CfgLayoutBcoEdoCtaConfiguration()
            : this("dbo")
        {
        }

        public CfgLayoutBcoEdoCtaConfiguration(string schema)
        {
            ToTable("cfg_layout_bco_edo_cta", schema);
            HasKey(x => x.IdCfgLayout);

            Property(x => x.IdCfgLayout).HasColumnName(@"id_cfg_layout").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdLayout).HasColumnName(@"id_layout").HasColumnType("int").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("tinyint").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.Longitud).HasColumnName(@"longitud").HasColumnType("tinyint").IsRequired();
            Property(x => x.PosicionIni).HasColumnName(@"posicion_ini").HasColumnType("tinyint").IsRequired();
            Property(x => x.PosicionFin).HasColumnName(@"posicion_fin").HasColumnType("tinyint").IsRequired();
            Property(x => x.EsFechaImporte).HasColumnName(@"es_fecha_importe").HasColumnType("tinyint").IsRequired();
            Property(x => x.ValorFijo).HasColumnName(@"valor_fijo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.RellenarCon).HasColumnName(@"rellenar_con").HasColumnType("tinyint").IsRequired();
            Property(x => x.DireccionRelleno).HasColumnName(@"direccion_relleno").HasColumnType("tinyint").IsRequired();
            Property(x => x.LlevaPunto).HasColumnName(@"lleva_punto").HasColumnType("bit").IsRequired();
            Property(x => x.NumDecimales).HasColumnName(@"num_decimales").HasColumnType("tinyint").IsRequired();
            Property(x => x.Formato).HasColumnName(@"formato").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.CUtiliza).HasColumnName(@"c_utiliza").HasColumnType("bit").IsRequired();
            Property(x => x.Campo).HasColumnName(@"campo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.PosicionDefine).HasColumnName(@"posicion_define").HasColumnType("tinyint").IsRequired();
            Property(x => x.Opcional).HasColumnName(@"opcional").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
