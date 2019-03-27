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

    // cxp_pag_enc_prov
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxpPagEncProvConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxpPagEncProv>
    {
        public CxpPagEncProvConfiguration()
            : this("dbo")
        {
        }

        public CxpPagEncProvConfiguration(string schema)
        {
            ToTable("cxp_pag_enc_prov", schema);
            HasKey(x => x.IdPago);

            Property(x => x.IdPago).HasColumnName(@"id_pago").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.Nom1).HasColumnName(@"nom1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Rfc).HasColumnName(@"rfc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsRequired();
            Property(x => x.ResFis).HasColumnName(@"res_fis").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.NumRegIdFis).HasColumnName(@"num_reg_id_fis").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.UsoCfdi).HasColumnName(@"uso_cfdi").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.SelloDigi).HasColumnName(@"sello_digi").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Certifi).HasColumnName(@"certifi").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.CfdStatus).HasColumnName(@"cfd_status").HasColumnType("int").IsRequired();
            Property(x => x.IdCert).HasColumnName(@"id_cert").HasColumnType("int").IsRequired();
            Property(x => x.Uuid).HasColumnName(@"uuid").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(36);
            Property(x => x.SelloSat).HasColumnName(@"sello_sat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Cbb).HasColumnName(@"cbb").HasColumnType("image").IsRequired().HasMaxLength(2147483647);
            Property(x => x.FecTimPac).HasColumnName(@"fec_tim_pac").HasColumnType("datetime").IsRequired();
            Property(x => x.CertSat).HasColumnName(@"cert_sat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XmlCanc).HasColumnName(@"xml_canc").HasColumnType("xml").IsRequired();
            Property(x => x.CTimb).HasColumnName(@"c_timb").HasColumnType("tinyint").IsRequired();
            Property(x => x.CpExp).HasColumnName(@"cp_exp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Confirmacion).HasColumnName(@"confirmacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Ver).HasColumnName(@"ver").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.FecPago).HasColumnName(@"fec_pago").HasColumnType("datetime").IsRequired();
            Property(x => x.FormaPago).HasColumnName(@"forma_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.MetodoPago).HasColumnName(@"metodo_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.MdaPago).HasColumnName(@"mda_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.TcPago).HasColumnName(@"tc_pago").HasColumnType("float").IsRequired();
            Property(x => x.MtoPago).HasColumnName(@"mto_pago").HasColumnType("float").IsRequired();
            Property(x => x.NumOperPago).HasColumnName(@"num_oper_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.RfcEmiOri).HasColumnName(@"rfc_emi_ori").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.NomEmiExtOri).HasColumnName(@"nom_emi_ext_ori").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.CtaPago).HasColumnName(@"cta_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RfcRecDest).HasColumnName(@"rfc_rec_dest").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.CtaBenef).HasColumnName(@"cta_benef").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TipCadPago).HasColumnName(@"tip_cad_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.CertPago).HasColumnName(@"cert_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.CadPago).HasColumnName(@"cad_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.SelloPago).HasColumnName(@"sello_pago").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.RegFisDes).HasColumnName(@"reg_fis_des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.TipPagCtaDes).HasColumnName(@"tip_pag_cta_des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.MetPagDes).HasColumnName(@"met_pag_des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.IdTipCfd).HasColumnName(@"id_tip_cfd").HasColumnType("int").IsRequired();
            Property(x => x.StatusConcil).HasColumnName(@"status_concil").HasColumnType("tinyint").IsRequired();
            Property(x => x.Arch).HasColumnName(@"arch").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
        }
    }

}
// </auto-generated>
