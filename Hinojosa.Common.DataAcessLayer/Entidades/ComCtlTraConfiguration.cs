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

    // com_ctl_tra
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ComCtlTraConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ComCtlTra>
    {
        public ComCtlTraConfiguration()
            : this("dbo")
        {
        }

        public ComCtlTraConfiguration(string schema)
        {
            ToTable("com_ctl_tra", schema);
            HasKey(x => x.IdFteTrn);

            Property(x => x.IdFteTrn).HasColumnName(@"id_fte_trn").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NoEmbarque).HasColumnName(@"no_embarque").HasColumnType("int").IsRequired();
            Property(x => x.NoViaje).HasColumnName(@"no_viaje").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.IdProvFlete).HasColumnName(@"id_prov_flete").HasColumnType("int").IsRequired();
            Property(x => x.ClaveProveedor).HasColumnName(@"clave_proveedor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Operador).HasColumnName(@"operador").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NoEconomico).HasColumnName(@"no_economico").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ubicacion).HasColumnName(@"ubicacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdPedido).HasColumnName(@"id_pedido").HasColumnType("int").IsRequired();
            Property(x => x.TipRecepCom).HasColumnName(@"tip_recep_com").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdPart).HasColumnName(@"id_part").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.CodAlm).HasColumnName(@"cod_alm").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.CantPart).HasColumnName(@"cant_part").HasColumnType("float").IsRequired();
            Property(x => x.CantEnv).HasColumnName(@"cant_env").HasColumnType("float").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.Peso).HasColumnName(@"peso").HasColumnType("float").IsRequired();
            Property(x => x.TipoCP).HasColumnName(@"tipo_c_p").HasColumnType("int").IsRequired();
            Property(x => x.CliProv).HasColumnName(@"cli_prov").HasColumnType("int").IsRequired();
            Property(x => x.CdOrigen).HasColumnName(@"cd_origen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.CdDestino).HasColumnName(@"cd_destino").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.EnvRecep).HasColumnName(@"env_recep").HasColumnType("int").IsRequired();
            Property(x => x.FecProm).HasColumnName(@"fec_prom").HasColumnType("datetime").IsRequired();
            Property(x => x.FecSal).HasColumnName(@"fec_sal").HasColumnType("datetime").IsRequired();
            Property(x => x.FecEntReal).HasColumnName(@"fec_ent_real").HasColumnType("datetime").IsRequired();
            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired();
            Property(x => x.Factura).HasColumnName(@"factura").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.Impuestos).HasColumnName(@"impuestos").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.NumPag).HasColumnName(@"num_pag").HasColumnType("int").IsRequired();
            Property(x => x.FolioPag).HasColumnName(@"folio_pag").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.PagApl).HasColumnName(@"pag_apl").HasColumnType("float").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipCamion).HasColumnName(@"tip_camion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TipPlataforma).HasColumnName(@"tip_plataforma").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CantEquSol).HasColumnName(@"cant_equ_sol").HasColumnType("int").IsRequired();
            Property(x => x.FecRec).HasColumnName(@"fec_rec").HasColumnType("datetime").IsRequired();
            Property(x => x.CostoBse).HasColumnName(@"costo_bse").HasColumnType("float").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdOperador).HasColumnName(@"id_operador").HasColumnType("int").IsRequired();
            Property(x => x.IdCamion).HasColumnName(@"id_camion").HasColumnType("int").IsRequired();
            Property(x => x.IdPlataforma).HasColumnName(@"id_plataforma").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>