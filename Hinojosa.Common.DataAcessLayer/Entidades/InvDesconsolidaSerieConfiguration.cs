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

    // inv_desconsolida_serie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvDesconsolidaSerieConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvDesconsolidaSerie>
    {
        public InvDesconsolidaSerieConfiguration()
            : this("dbo")
        {
        }

        public InvDesconsolidaSerieConfiguration(string schema)
        {
            ToTable("inv_desconsolida_serie", schema);
            HasKey(x => x.IdDescSer);

            Property(x => x.IdDescSer).HasColumnName(@"id_desc_ser").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdMtoSerLot).HasColumnName(@"id_mto_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.IdComSerLot).HasColumnName(@"id_com_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipDocOri).HasColumnName(@"id_tip_doc_ori").HasColumnType("int").IsRequired();
            Property(x => x.IdDocOri).HasColumnName(@"id_doc_ori").HasColumnType("int").IsRequired();
            Property(x => x.IdDocDetOri).HasColumnName(@"id_doc_det_ori").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
