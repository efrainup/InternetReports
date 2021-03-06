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

    // sis_ref_rel_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefRelDocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRefRelDoc>
    {
        public SisRefRelDocConfiguration()
            : this("dbo")
        {
        }

        public SisRefRelDocConfiguration(string schema)
        {
            ToTable("sis_ref_rel_doc", schema);
            HasKey(x => x.IdRefDetDoc);

            Property(x => x.IdRefDetDoc).HasColumnName(@"id_ref_det_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdRefRelDet).HasColumnName(@"id_ref_rel_det").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdInt).HasColumnName(@"id_int").HasColumnType("int").IsRequired();
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDocDet).HasColumnName(@"id_doc_det").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.Costo).HasColumnName(@"costo").HasColumnType("float").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.CostoTot).HasColumnName(@"costo_tot").HasColumnType("float").IsRequired();
            Property(x => x.ImpTot).HasColumnName(@"imp_tot").HasColumnType("float").IsRequired();
            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdCodSrv).HasColumnName(@"id_cod_srv").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCliCtaDe).HasColumnName(@"id_cli_cta_de").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdAux).HasColumnName(@"id_aux").HasColumnType("int").IsRequired();
            Property(x => x.IdCliFaDa).HasColumnName(@"id_cli_fa_da").HasColumnType("int").IsRequired();
            Property(x => x.IdCtaBco).HasColumnName(@"id_cta_bco").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDocApl).HasColumnName(@"id_tip_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdDocApl).HasColumnName(@"id_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.RefNum).HasColumnName(@"ref_num").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.NumChq).HasColumnName(@"num_chq").HasColumnType("int").IsRequired();
            Property(x => x.RefNumApl).HasColumnName(@"ref_num_apl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.IdAct).HasColumnName(@"id_act").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.Rfc).HasColumnName(@"rfc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.CostoBse).HasColumnName(@"costo_bse").HasColumnType("float").IsRequired();
            Property(x => x.PrecioBse).HasColumnName(@"precio_bse").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotBse).HasColumnName(@"costo_tot_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImpTotBse).HasColumnName(@"imp_tot_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdTipSol).HasColumnName(@"id_tip_sol").HasColumnType("int").IsRequired();
            Property(x => x.CEnCga).HasColumnName(@"c_en_cga").HasColumnType("tinyint").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.ImptosBse).HasColumnName(@"imptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotCimptos).HasColumnName(@"costo_tot_cimptos").HasColumnType("float").IsRequired();
            Property(x => x.ImpTotCimptos).HasColumnName(@"imp_tot_cimptos").HasColumnType("float").IsRequired();
            Property(x => x.CostoTotCimptosBse).HasColumnName(@"costo_tot_cimptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImpTotCimptosBse).HasColumnName(@"imp_tot_cimptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.CantApl).HasColumnName(@"cant_apl").HasColumnType("float").IsRequired();
            Property(x => x.Sec).HasColumnName(@"sec").HasColumnType("int").IsRequired();
            Property(x => x.PtgKit).HasColumnName(@"ptg_kit").HasColumnType("float").IsRequired();
            Property(x => x.BaseGrav).HasColumnName(@"base_grav").HasColumnType("float").IsRequired();
            Property(x => x.TipHon).HasColumnName(@"tip_hon").HasColumnType("int").IsRequired();
            Property(x => x.PtgHon).HasColumnName(@"ptg_hon").HasColumnType("float").IsRequired();
            Property(x => x.IdCga).HasColumnName(@"id_cga").HasColumnType("int").IsRequired();
            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired();
            Property(x => x.IdCac).HasColumnName(@"id_cac").HasColumnType("int").IsRequired();
            Property(x => x.PrecioExt).HasColumnName(@"precio_ext").HasColumnType("float").IsRequired();
            Property(x => x.CantRealGto).HasColumnName(@"cant_real_gto").HasColumnType("float").IsRequired();
            Property(x => x.IdDocDetApl).HasColumnName(@"id_doc_det_apl").HasColumnType("int").IsRequired();
            Property(x => x.CDev).HasColumnName(@"c_dev").HasColumnType("int").IsRequired();
            Property(x => x.IdNc).HasColumnName(@"id_nc").HasColumnType("int").IsRequired();
            Property(x => x.MtoDevBse).HasColumnName(@"mto_dev_bse").HasColumnType("float").IsRequired();
            Property(x => x.CCar26).HasColumnName(@"c_car_26").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SisRefRelDocs).HasForeignKey(c => c.IdRef).WillCascadeOnDelete(false); // FK_sis_ref_rel_doc_SIR_60_REFERENCIAS
        }
    }

}
// </auto-generated>
