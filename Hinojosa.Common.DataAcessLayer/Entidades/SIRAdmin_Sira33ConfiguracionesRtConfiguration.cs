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

    // SIRA_33_CONFIGURACIONES_RT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira33ConfiguracionesRtConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira33ConfiguracionesRt>
    {
        public SIRAdmin_Sira33ConfiguracionesRtConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira33ConfiguracionesRtConfiguration(string schema)
        {
            ToTable("SIRA_33_CONFIGURACIONES_RT", schema);
            HasKey(x => new { x.NComponente, x.NOrden, x.BRtAuto, x.NTipo, x.BActivo });

            Property(x => x.NComponente).HasColumnName(@"nComponente").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NOrden).HasColumnName(@"nOrden").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NLongitud).HasColumnName(@"nLongitud").HasColumnType("int").IsOptional();
            Property(x => x.SPrefijo).HasColumnName(@"sPrefijo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.BRtAuto).HasColumnName(@"bRTAuto").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdSucursal).HasColumnName(@"nIdSucursal").HasColumnType("int").IsOptional();
            Property(x => x.NIdAlmacen).HasColumnName(@"nIdAlmacen").HasColumnType("int").IsOptional();
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NVencimiento).HasColumnName(@"nVencimiento").HasColumnType("int").IsOptional();
            Property(x => x.NRecintoVencimiento).HasColumnName(@"nRecintoVencimiento").HasColumnType("int").IsOptional();
            Property(x => x.NUltimoVencimiento).HasColumnName(@"nUltimoVencimiento").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.CatAlmac).WithMany(b => b.SIRAdmin_Sira33ConfiguracionesRt).HasForeignKey(c => c.NIdAlmacen).WillCascadeOnDelete(false); // FK_SIRA_33_CONFIGURACIONES_RT_cat_almac
            HasOptional(a => a.McpSuc).WithMany(b => b.SIRAdmin_Sira33ConfiguracionesRt).HasForeignKey(c => c.NIdSucursal).WillCascadeOnDelete(false); // FK_SIRA_33_CONFIGURACIONES_RT_mcp_suc
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIRAdmin_Sira33ConfiguracionesRt).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIRA_33_CONFIGURACIONES_RT_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>
