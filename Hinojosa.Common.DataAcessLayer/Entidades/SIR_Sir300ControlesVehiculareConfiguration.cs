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

    // SIR_300_CONTROLES_VEHICULARES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir300ControlesVehiculareConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir300ControlesVehiculare>
    {
        public SIR_Sir300ControlesVehiculareConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir300ControlesVehiculareConfiguration(string schema)
        {
            ToTable("SIR_300_CONTROLES_VEHICULARES", schema);
            HasKey(x => x.NIdCtrlVeh300);

            Property(x => x.NIdCtrlVeh300).HasColumnName(@"nIdCtrlVeh300").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.DEntrada).HasColumnName(@"dEntrada").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.DSalida).HasColumnName(@"dSalida").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired();
            Property(x => x.NIdTransportista).HasColumnName(@"nIdTransportista").HasColumnType("int").IsOptional();
            Property(x => x.SCajaTractor).HasColumnName(@"sCajaTractor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.BConOrdenProg).HasColumnName(@"bConOrdenProg").HasColumnType("bit").IsRequired();
            Property(x => x.SNumEconomico).HasColumnName(@"sNumEconomico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NIdAlmacen).HasColumnName(@"nIdAlmacen").HasColumnType("int").IsRequired();
            Property(x => x.SPlacas).HasColumnName(@"sPlacas").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SChofer).HasColumnName(@"sChofer").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsOptional();
            Property(x => x.NIdSalBod205).HasColumnName(@"nIdSalBod205").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir156EntradasBodega).WithMany(b => b.SIR_Sir300ControlesVehiculare).HasForeignKey(c => c.NIdEntrada156).WillCascadeOnDelete(false); // FK_SIR_300_CONTROLES_VEHICULARES_SIR_156_ENTRADAS_BODEGAS
            HasOptional(a => a.SIR_Sir205SalidasBodega).WithMany(b => b.SIR_Sir300ControlesVehiculare).HasForeignKey(c => c.NIdSalBod205).WillCascadeOnDelete(false); // FK_SIR_300_CONTROLES_VEHICULARES_SIR_205_SALIDAS_BODEGA
            HasRequired(a => a.CatAlmac).WithMany(b => b.SIR_Sir300ControlesVehiculare).HasForeignKey(c => c.NIdAlmacen).WillCascadeOnDelete(false); // FK_SIR_300_CONTROLES_VEHICULARES_cat_almac
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir300ControlesVehiculare).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_300_CONTROLES_VEHICULARES_cat_usr
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir300ControlesVehiculare).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_300_CONTROLES_VEHICULARES_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>