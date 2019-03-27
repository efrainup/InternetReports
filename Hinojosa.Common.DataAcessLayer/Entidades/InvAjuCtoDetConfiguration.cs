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

    // inv_aju_cto_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvAjuCtoDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvAjuCtoDet>
    {
        public InvAjuCtoDetConfiguration()
            : this("dbo")
        {
        }

        public InvAjuCtoDetConfiguration(string schema)
        {
            ToTable("inv_aju_cto_det", schema);
            HasKey(x => x.IdAjuCtoDet);

            Property(x => x.IdAjuCtoDet).HasColumnName(@"id_aju_cto_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdAjuCto).HasColumnName(@"id_aju_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDocApl).HasColumnName(@"id_tip_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdDocApl).HasColumnName(@"id_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdDocDetApl).HasColumnName(@"id_doc_det_apl").HasColumnType("int").IsRequired();
            Property(x => x.NumDocApl).HasColumnName(@"num_doc_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.CostoRec).HasColumnName(@"costo_rec").HasColumnType("float").IsRequired();
            Property(x => x.CostoCxp).HasColumnName(@"costo_cxp").HasColumnType("float").IsRequired();
            Property(x => x.Aju).HasColumnName(@"aju").HasColumnType("float").IsRequired();
            Property(x => x.IdClAs).HasColumnName(@"id_clAS").HasColumnType("int").IsRequired();
            Property(x => x.IdAlm).HasColumnName(@"id_alm").HasColumnType("int").IsRequired();
            Property(x => x.CInv).HasColumnName(@"c_inv").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdRelCtoInd).HasColumnName(@"id_rel_cto_ind").HasColumnType("int").IsRequired();
            Property(x => x.IdCenCto).HasColumnName(@"id_cen_cto").HasColumnType("int").IsRequired();
            Property(x => x.IdCtaGto).HasColumnName(@"id_cta_gto").HasColumnType("int").IsRequired();
            Property(x => x.IdCtaApl).HasColumnName(@"id_cta_apl").HasColumnType("int").IsRequired();
            Property(x => x.IdTipCto).HasColumnName(@"id_tip_cto").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>