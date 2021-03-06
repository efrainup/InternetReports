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

    // imp_vta_fac_enc_clie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ImpVtaFacEncClieConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ImpVtaFacEncClie>
    {
        public ImpVtaFacEncClieConfiguration()
            : this("dbo")
        {
        }

        public ImpVtaFacEncClieConfiguration(string schema)
        {
            ToTable("imp_vta_fac_enc_clie", schema);
            HasKey(x => x.ImpIdFact);

            Property(x => x.ImpIdFact).HasColumnName(@"imp_id_fact").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ImpIdClie).HasColumnName(@"imp_id_clie").HasColumnType("int").IsRequired();
            Property(x => x.ImpNom1).HasColumnName(@"imp_nom1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.ImpNom2).HasColumnName(@"imp_nom2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.ImpDir1).HasColumnName(@"imp_dir1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ImpDir2).HasColumnName(@"imp_dir2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.ImpCiu).HasColumnName(@"imp_ciu").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.ImpEst).HasColumnName(@"imp_est").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.ImpCp).HasColumnName(@"imp_cp").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.ImpRfc).HasColumnName(@"imp_rfc").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpTel1).HasColumnName(@"imp_tel1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpTel2).HasColumnName(@"imp_tel2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ImpCMost).HasColumnName(@"imp_c_most").HasColumnType("tinyint").IsRequired();
            Property(x => x.ImpContacto1).HasColumnName(@"imp_contacto1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ImpDepto).HasColumnName(@"imp_depto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.ImpSelloDigi).HasColumnName(@"imp_sello_digi").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1200);
            Property(x => x.ImpCertifi).HasColumnName(@"imp_certifi").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ImpNumApr).HasColumnName(@"imp_num_apr").HasColumnType("bigint").IsRequired();
            Property(x => x.ImpAnioApr).HasColumnName(@"imp_anio_apr").HasColumnType("int").IsRequired();
            Property(x => x.ImpIdNota).HasColumnName(@"imp_id_nota").HasColumnType("int").IsRequired();
            Property(x => x.ImpCfdStatus).HasColumnName(@"imp_cfd_status").HasColumnType("int").IsRequired();
            Property(x => x.ImpIdTipGrp).HasColumnName(@"imp_id_tip_grp").HasColumnType("int").IsRequired();
            Property(x => x.ImpIdCert).HasColumnName(@"imp_id_cert").HasColumnType("int").IsRequired();
            Property(x => x.ImpIdSisDoctosSerFol).HasColumnName(@"imp_id_sis_doctos_ser_fol").HasColumnType("int").IsRequired();
            Property(x => x.ImpTipPag).HasColumnName(@"imp_tip_pag").HasColumnType("int").IsRequired();
            Property(x => x.ImpCIepsDesg).HasColumnName(@"imp_c_ieps_desg").HasColumnType("tinyint").IsRequired();
            Property(x => x.ImpIdTipSer).HasColumnName(@"imp_id_tip_ser").HasColumnType("int").IsRequired();
            Property(x => x.ImpUuid).HasColumnName(@"imp_uuid").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(36);
            Property(x => x.ImpSelloSat).HasColumnName(@"imp_sello_sat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1200);
            Property(x => x.ImpCbb).HasColumnName(@"imp_CBB").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.ImpIdPac).HasColumnName(@"imp_id_pac").HasColumnType("int").IsRequired();
            Property(x => x.ImpCalle).HasColumnName(@"imp_calle").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.ImpNumInt).HasColumnName(@"imp_num_int").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.ImpNumExt).HasColumnName(@"imp_num_ext").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.ImpCol).HasColumnName(@"imp_col").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ImpDeleg).HasColumnName(@"imp_deleg").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ImpCalles).HasColumnName(@"imp_calles").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ImpIdPais).HasColumnName(@"imp_id_pais").HasColumnType("int").IsRequired();
            Property(x => x.ImpIdEdo).HasColumnName(@"imp_id_edo").HasColumnType("int").IsRequired();
            Property(x => x.ImpFecTimPac).HasColumnName(@"imp_fec_tim_pac").HasColumnType("datetime").IsRequired();
            Property(x => x.ImpCertSat).HasColumnName(@"imp_cert_sat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ImpXmlCanc).HasColumnName(@"imp_xml_canc").HasColumnType("xml").IsRequired();
            Property(x => x.ImpCTimb).HasColumnName(@"imp_c_timb").HasColumnType("tinyint").IsRequired();
            Property(x => x.ImpCfdDirExp).HasColumnName(@"imp_cfd_dir_exp").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ImpUltDigCta).HasColumnName(@"imp_ult_dig_cta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ImpRegFis).HasColumnName(@"imp_reg_fis").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ImpIdSugar).HasColumnName(@"imp_id_sugar").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(36);
            Property(x => x.ImpIdCliCta).HasColumnName(@"imp_id_cli_cta").HasColumnType("int").IsRequired();
            Property(x => x.ImpTipPagCta).HasColumnName(@"imp_tip_pag_cta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ImpBcoCta).HasColumnName(@"imp_bco_cta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ImpIdisCta).HasColumnName(@"imp_idis_cta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ImpPais).HasColumnName(@"imp_pais").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ImpMail).HasColumnName(@"imp_mail").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.ImpNom).HasColumnName(@"imp_nom").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ImpApep).HasColumnName(@"imp_apep").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ImpApem).HasColumnName(@"imp_apem").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ImpNacionalidad).HasColumnName(@"imp_nacionalidad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ImpIdFisExt).HasColumnName(@"imp_id_fis_ext").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.ImpCodsatPais).HasColumnName(@"imp_codsat_pais").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpCodsatEdo).HasColumnName(@"imp_codsat_edo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpCodsatMundel).HasColumnName(@"imp_codsat_mundel").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpCodsatLoc).HasColumnName(@"imp_codsat_loc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpCodsatCol).HasColumnName(@"imp_codsat_col").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpCadOri).HasColumnName(@"imp_cad_ori").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.ImpPdf).HasColumnName(@"imp_pdf").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.ImpXml).HasColumnName(@"imp_xml").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ImpCodsatUsoCfdi).HasColumnName(@"imp_codsat_uso_cfdi").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ImpMtdPag).HasColumnName(@"imp_mtd_pag").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
