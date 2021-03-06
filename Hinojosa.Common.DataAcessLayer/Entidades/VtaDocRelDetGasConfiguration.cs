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

    // vta_doc_rel_det_gas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaDocRelDetGasConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaDocRelDetGas>
    {
        public VtaDocRelDetGasConfiguration()
            : this("dbo")
        {
        }

        public VtaDocRelDetGasConfiguration(string schema)
        {
            ToTable("vta_doc_rel_det_gas", schema);
            HasKey(x => new { x.Nrotrn, x.Codgas });

            Property(x => x.Nrotrn).HasColumnName(@"nrotrn").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Codgas).HasColumnName(@"codgas").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nrofac).HasColumnName(@"nrofac").HasColumnType("int").IsRequired();
            Property(x => x.Nrobom).HasColumnName(@"nrobom").HasColumnType("int").IsRequired();
            Property(x => x.Fchtrn).HasColumnName(@"fchtrn").HasColumnType("datetime").IsRequired();
            Property(x => x.Hratrn).HasColumnName(@"hratrn").HasColumnType("datetime").IsRequired();
            Property(x => x.Nomarch).HasColumnName(@"nomarch").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2000);
            Property(x => x.Precio).HasColumnName(@"Precio").HasColumnType("float").IsRequired();
            Property(x => x.IdCliExt).HasColumnName(@"id_cli_ext").HasColumnType("int").IsRequired();
            Property(x => x.IdCli1G).HasColumnName(@"id_cli_1g").HasColumnType("int").IsRequired();
            Property(x => x.IdVehExt).HasColumnName(@"id_veh_ext").HasColumnType("int").IsRequired();
            Property(x => x.IdTipPag).HasColumnName(@"id_tip_pag").HasColumnType("int").IsRequired();
            Property(x => x.Monto).HasColumnName(@"Monto").HasColumnType("float").IsRequired();
            Property(x => x.Nroaut).HasColumnName(@"nroaut").HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.Nrotar).HasColumnName(@"nrotar").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired();
            Property(x => x.TipPagDes).HasColumnName(@"tip_pag_des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Fchcor).HasColumnName(@"fchcor").HasColumnType("date").IsRequired();
            Property(x => x.Mtogto).HasColumnName(@"mtogto").HasColumnType("float").IsRequired();
            Property(x => x.Tiptrn).HasColumnName(@"tiptrn").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdBcoAtio).HasColumnName(@"id_bco_atio").HasColumnType("int").IsRequired();
            Property(x => x.Rut).HasColumnName(@"rut").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Nrotur).HasColumnName(@"nrotur").HasColumnType("int").IsRequired();
            Property(x => x.Codprd).HasColumnName(@"codprd").HasColumnType("int").IsRequired();
            Property(x => x.Can).HasColumnName(@"can").HasColumnType("float").IsRequired();
            Property(x => x.Nrocte).HasColumnName(@"nrocte").HasColumnType("int").IsRequired();
            Property(x => x.Nrovhe).HasColumnName(@"nrovhe").HasColumnType("int").IsRequired();
            Property(x => x.Nrocho).HasColumnName(@"nrocho").HasColumnType("int").IsRequired();
            Property(x => x.Cho).HasColumnName(@"cho").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Odm).HasColumnName(@"odm").HasColumnType("int").IsRequired();
            Property(x => x.Codisl).HasColumnName(@"codisl").HasColumnType("int").IsRequired();
            Property(x => x.Pto).HasColumnName(@"pto").HasColumnType("float").IsRequired();
            Property(x => x.Codres).HasColumnName(@"codres").HasColumnType("int").IsRequired();
            Property(x => x.Graprd).HasColumnName(@"graprd").HasColumnType("int").IsRequired();
            Property(x => x.Logfch).HasColumnName(@"logfch").HasColumnType("datetime").IsRequired();
            Property(x => x.Nrotrnpad).HasColumnName(@"nrotrnpad").HasColumnType("int").IsRequired();
            Property(x => x.IdFacDet).HasColumnName(@"id_fac_det").HasColumnType("int").IsRequired();
            Property(x => x.@Base).HasColumnName(@"base").HasColumnType("float").IsRequired();
            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired();
            Property(x => x.Tasa).HasColumnName(@"tasa").HasColumnType("float").IsRequired();
            Property(x => x.MtoImpto).HasColumnName(@"mto_impto").HasColumnType("float").IsRequired();
            Property(x => x.TasaIeps).HasColumnName(@"tasa_ieps").HasColumnType("float").IsRequired();
            Property(x => x.MtoIeps).HasColumnName(@"mto_ieps").HasColumnType("float").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.CodBcoGas).HasColumnName(@"cod_bco_gas").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.LogNew).HasColumnName(@"log_new").HasColumnType("datetime").IsRequired();
            Property(x => x.DatosRef).HasColumnName(@"datos_ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DatosCli).HasColumnName(@"datos_cli").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DatosVehi).HasColumnName(@"datos_vehi").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.IdSisExt).HasColumnName(@"id_sis_ext").HasColumnType("int").IsRequired();
            Property(x => x.Gas).HasColumnName(@"gas").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
