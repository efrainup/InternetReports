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

    // SIR_181_RELACION_CARGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir181RelacionCargaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir181RelacionCarga>
    {
        public SIR_Sir181RelacionCargaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir181RelacionCargaConfiguration(string schema)
        {
            ToTable("SIR_181_RELACION_CARGA", schema);
            HasKey(x => x.NIdRelCarga181);

            Property(x => x.NIdRelCarga181).HasColumnName(@"nIdRelCarga181").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NNumRelacion).HasColumnName(@"nNumRelacion").HasColumnType("int").IsRequired();
            Property(x => x.NTipoCruce).HasColumnName(@"nTipoCruce").HasColumnType("int").IsRequired();
            Property(x => x.BRetorno).HasColumnName(@"bRetorno").HasColumnType("bit").IsRequired();
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaCarga).HasColumnName(@"dFechaCarga").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NNumFacturas).HasColumnName(@"nNumFacturas").HasColumnType("int").IsOptional();
            Property(x => x.BConsolidado).HasColumnName(@"bConsolidado").HasColumnType("bit").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired();
            Property(x => x.NIdMandatario).HasColumnName(@"nIdMandatario").HasColumnType("int").IsRequired();
            Property(x => x.NIdLineaNacional).HasColumnName(@"nIdLineaNacional").HasColumnType("int").IsRequired();
            Property(x => x.NIdTransportista).HasColumnName(@"nIdTransportista").HasColumnType("int").IsRequired();
            Property(x => x.SPlacasTransfer).HasColumnName(@"sPlacasTransfer").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NModoTransporte).HasColumnName(@"nModoTransporte").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatEmp).WithMany(b => b.SIR_Sir181RelacionCarga).HasForeignKey(c => c.NIdMandatario).WillCascadeOnDelete(false); // FK_SIR_181_RELACION_CARGA_cat_emp
            HasRequired(a => a.CatProv_NIdLineaNacional).WithMany(b => b.SIR_Sir181RelacionCarga_NIdLineaNacional).HasForeignKey(c => c.NIdLineaNacional).WillCascadeOnDelete(false); // FK_SIR_181_RELACION_CARGA_cat_prov1
            HasRequired(a => a.CatProv_NIdTransportista).WithMany(b => b.SIR_Sir181RelacionCarga_NIdTransportista).HasForeignKey(c => c.NIdTransportista).WillCascadeOnDelete(false); // FK_SIR_181_RELACION_CARGA_cat_prov
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir181RelacionCarga).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_181_RELACION_CARGA_cat_usr
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir181RelacionCarga).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_181_RELACION_CARGA_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>
