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

    // sis_cod_svr_trx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisCodSvrTrxConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisCodSvrTrx>
    {
        public SisCodSvrTrxConfiguration()
            : this("dbo")
        {
        }

        public SisCodSvrTrxConfiguration(string schema)
        {
            ToTable("sis_cod_svr_trx", schema);
            HasKey(x => x.IdCodSvrTrx);

            Property(x => x.IdCodSvrTrx).HasColumnName(@"id_cod_svr_trx").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCodSvr).HasColumnName(@"id_cod_svr").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Subtotal).HasColumnName(@"subtotal").HasColumnType("real").IsRequired();
            Property(x => x.Iva).HasColumnName(@"iva").HasColumnType("real").IsRequired();
            Property(x => x.CargosMisc).HasColumnName(@"cargos_misc").HasColumnType("real").IsRequired();
            Property(x => x.Flete).HasColumnName(@"flete").HasColumnType("real").IsRequired();
            Property(x => x.FleteIva).HasColumnName(@"flete_iva").HasColumnType("real").IsRequired();
            Property(x => x.FleteRet).HasColumnName(@"flete_ret").HasColumnType("real").IsRequired();
            Property(x => x.FleteRetPtg).HasColumnName(@"flete_ret_ptg").HasColumnType("real").IsRequired();
            Property(x => x.IsrRet).HasColumnName(@"isr_ret").HasColumnType("real").IsRequired();
            Property(x => x.IsrRetPtg).HasColumnName(@"isr_ret_ptg").HasColumnType("real").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("real").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.TipCam).HasColumnName(@"tip_cam").HasColumnType("real").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.SubtotalBse).HasColumnName(@"subtotal_bse").HasColumnType("real").IsRequired();
            Property(x => x.IvaBse).HasColumnName(@"iva_bse").HasColumnType("real").IsRequired();
            Property(x => x.CargosMiscBse).HasColumnName(@"cargos_misc_bse").HasColumnType("real").IsRequired();
            Property(x => x.FleteBse).HasColumnName(@"flete_bse").HasColumnType("real").IsRequired();
            Property(x => x.FleteIvaBse).HasColumnName(@"flete_iva_bse").HasColumnType("real").IsRequired();
            Property(x => x.FleteRetBse).HasColumnName(@"flete_ret_bse").HasColumnType("real").IsRequired();
            Property(x => x.IsrRetBse).HasColumnName(@"isr_ret_bse").HasColumnType("real").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("real").IsRequired();
        }
    }

}
// </auto-generated>
