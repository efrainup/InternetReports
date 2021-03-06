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

    // SIR_128_PEDIDOS_CLIENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir128PedidosClienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir128PedidosCliente>
    {
        public SIR_Sir128PedidosClienteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir128PedidosClienteConfiguration(string schema)
        {
            ToTable("SIR_128_PEDIDOS_CLIENTES", schema);
            HasKey(x => x.NIdPedido128);

            Property(x => x.NIdPedido128).HasColumnName(@"nIdPedido128").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SNumPedido).HasColumnName(@"sNumPedido").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NIdFactura52).HasColumnName(@"nIdFactura52").HasColumnType("int").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsOptional();
            Property(x => x.NIdAduSec06).HasColumnName(@"nIdAduSec06").HasColumnType("int").IsOptional();
            Property(x => x.DPedido).HasColumnName(@"dPedido").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SMercancia).HasColumnName(@"sMercancia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.NCantidad).HasColumnName(@"nCantidad").HasColumnType("decimal").IsOptional().HasPrecision(16,2);
            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsOptional();
            Property(x => x.NIdIncoterm53).HasColumnName(@"nIdIncoterm53").HasColumnType("int").IsOptional();
            Property(x => x.NValorFactura).HasColumnName(@"nValorFactura").HasColumnType("decimal").IsOptional().HasPrecision(16,2);
            Property(x => x.NIdProveedor42).HasColumnName(@"nIdProveedor42").HasColumnType("int").IsOptional();
            Property(x => x.DEntregaSitio).HasColumnName(@"dEntregaSitio").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.BRecibida).HasColumnName(@"bRecibida").HasColumnType("bit").IsOptional();
            Property(x => x.SRutaAcuseRecibo).HasColumnName(@"sRutaAcuseRecibo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.SGuia).HasColumnName(@"sGuia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.NIdTransportista).HasColumnName(@"nIdTransportista").HasColumnType("int").IsOptional();
            Property(x => x.SPlacas).HasColumnName(@"sPlacas").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SChofer).HasColumnName(@"sChofer").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NIdTransportista42).HasColumnName(@"nIdTransportista42").HasColumnType("int").IsOptional();
            Property(x => x.NIdUMed10).HasColumnName(@"nIdUMed10").HasColumnType("int").IsOptional();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.NEstadoMercancia).HasColumnName(@"nEstadoMercancia").HasColumnType("tinyint").IsOptional();
            Property(x => x.SEstado).HasColumnName(@"sEstado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NIdUsuarioRecibe).HasColumnName(@"nIdUsuarioRecibe").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioComprador).HasColumnName(@"nIdUsuarioComprador").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioRecibe01).HasColumnName(@"nIdUsuarioRecibe01").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioComprador01).HasColumnName(@"nIdUsuarioComprador01").HasColumnType("int").IsOptional();
            Property(x => x.NIdRem206).HasColumnName(@"nIdRem206").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_ADMINC_07_CLIENTES
            HasOptional(a => a.Admin_Adminc42Proveedore).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdTransportista42).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_ADMINC_42_PROVEEDORES1
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_cat_clientes
            HasOptional(a => a.CatProv).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdTransportista).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_cat_prov
            HasOptional(a => a.CatUsr_NIdUsuarioComprador).WithMany(b => b.SIR_Sir128PedidosCliente_NIdUsuarioComprador).HasForeignKey(c => c.NIdUsuarioComprador).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_cat_usr_comp
            HasOptional(a => a.CatUsr_NIdUsuarioRecibe).WithMany(b => b.SIR_Sir128PedidosCliente_NIdUsuarioRecibe).HasForeignKey(c => c.NIdUsuarioRecibe).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_cat_usr_recibe
            HasOptional(a => a.SIR_Sir01Pais).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdPais01).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_01_PAISES
            HasOptional(a => a.SIR_Sir03Moneda).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdMoneda03).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_03_MONEDAS
            HasOptional(a => a.SIR_Sir06AduanaSec).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdAduSec06).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_06_ADUANA_SEC
            HasOptional(a => a.SIR_Sir10UnidadesMedida).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdUMed10).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_10_UNIDADES_MEDIDA
            HasOptional(a => a.SIR_Sir156EntradasBodega).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdEntrada156).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_156_ENTRADAS_BODEGAS
            HasOptional(a => a.SIR_Sir206Remesa).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdRem206).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_206_REMESAS
            HasOptional(a => a.SIR_Sir42Proveedore).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdProveedor42).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_42_PROVEEDORES
            HasOptional(a => a.SIR_Sir52Factura).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdFactura52).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_52_FACTURAS
            HasOptional(a => a.SIR_Sir53Incoterm).WithMany(b => b.SIR_Sir128PedidosCliente).HasForeignKey(c => c.NIdIncoterm53).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_SIR_53_INCOTERMS
            HasRequired(a => a.CatUsr_NIdUsuarioEd).WithMany(b => b.SIR_Sir128PedidosCliente_NIdUsuarioEd).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_128_PEDIDOS_CLIENTES_cat_usr_ed
            HasMany(t => t.SIR_Sir60Referencia).WithMany(t => t.SIR_Sir128PedidosCliente).Map(m =>
            {
                m.ToTable("SIR_345_REFERENCIAS_PEDIDOS", "SIR");
                m.MapLeftKey("nIdPedido128");
                m.MapRightKey("nIdReferencia60");
            });
        }
    }

}
// </auto-generated>
