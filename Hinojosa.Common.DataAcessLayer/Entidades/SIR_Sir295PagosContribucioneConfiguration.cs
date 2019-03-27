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

    // SIR_295_PAGOS_CONTRIBUCIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir295PagosContribucioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir295PagosContribucione>
    {
        public SIR_Sir295PagosContribucioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir295PagosContribucioneConfiguration(string schema)
        {
            ToTable("SIR_295_PAGOS_CONTRIBUCIONES", schema);
            HasKey(x => x.NIdPagoCont295);

            Property(x => x.NIdPagoCont295).HasColumnName(@"nIdPagoCont295").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdFraccComp215).HasColumnName(@"nIdFraccComp215").HasColumnType("int").IsRequired();
            Property(x => x.NIdTiposImp30).HasColumnName(@"nIdTiposImp30").HasColumnType("int").IsOptional();
            Property(x => x.NIdFormaPago32).HasColumnName(@"nIdFormaPago32").HasColumnType("int").IsOptional();
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NImporteSinOperar).HasColumnName(@"nImporteSinOperar").HasColumnType("int").IsOptional();
            Property(x => x.NInpc).HasColumnName(@"nINPC").HasColumnType("decimal").IsOptional().HasPrecision(10,9);

            // Foreign keys
            HasOptional(a => a.SIR_Sir30TiposImpuesto).WithMany(b => b.SIR_Sir295PagosContribucione).HasForeignKey(c => c.NIdTiposImp30).WillCascadeOnDelete(false); // FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_30_TIPOS_IMPUESTOS
            HasOptional(a => a.SIR_Sir32FormasPago).WithMany(b => b.SIR_Sir295PagosContribucione).HasForeignKey(c => c.NIdFormaPago32).WillCascadeOnDelete(false); // FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_32_FORMAS_PAGO
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir295PagosContribucione).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_295_PAGOS_CONTRIBUCIONES_cat_usr_ed
            HasRequired(a => a.SIR_Sir215FraccionesTlcExpo).WithMany(b => b.SIR_Sir295PagosContribucione).HasForeignKey(c => c.NIdFraccComp215).WillCascadeOnDelete(false); // FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_215_FRACCIONES_TLC_EXPO
        }
    }

}
// </auto-generated>
