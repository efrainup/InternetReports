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

    // SIRA_11_CONFIG_REFERENCIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira11ConfigReferenciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira11ConfigReferencia>
    {
        public SIRAdmin_Sira11ConfigReferenciaConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira11ConfigReferenciaConfiguration(string schema)
        {
            ToTable("SIRA_11_CONFIG_REFERENCIA", schema);
            HasKey(x => new { x.NComponente, x.NOrden, x.DFechaEdicion, x.NIdUsuarioEd, x.BRectifPred, x.BReferenciaPred, x.NTipo, x.NIdConfRef11 });

            Property(x => x.NComponente).HasColumnName(@"nComponente").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NOrden).HasColumnName(@"nOrden").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NLongitud).HasColumnName(@"nLongitud").HasColumnType("tinyint").IsOptional();
            Property(x => x.SPrefijo).HasColumnName(@"sPrefijo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.BRectifPred).HasColumnName(@"bRectifPred").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BReferenciaPred).HasColumnName(@"bReferenciaPred").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdSucursal).HasColumnName(@"nIdSucursal").HasColumnType("int").IsOptional();
            Property(x => x.NIdClasCategoria).HasColumnName(@"nIdClasCategoria").HasColumnType("int").IsOptional();
            Property(x => x.NIdConfRef11).HasColumnName(@"nIdConfRef11").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Foreign keys
            HasOptional(a => a.CatCla).WithMany(b => b.SIRAdmin_Sira11ConfigReferencia).HasForeignKey(c => c.NIdClasCategoria).WillCascadeOnDelete(false); // FK_SIRA_11_CONFIG_REFERENCIA_cat_clas
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIRAdmin_Sira11ConfigReferencia).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIRA_11_CONFIG_REFERENCIA_SIR_71_SUCURSAL_PATENTE_ADUANA
            HasRequired(a => a.CatUsr).WithMany(b => b.SIRAdmin_Sira11ConfigReferencia).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIRA_11_CONFIG_REFERENCIA_cat_usr
        }
    }

}
// </auto-generated>