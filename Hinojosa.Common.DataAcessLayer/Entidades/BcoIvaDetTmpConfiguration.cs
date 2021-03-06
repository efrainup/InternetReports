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

    // bco_iva_det_TMP
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoIvaDetTmpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BcoIvaDetTmp>
    {
        public BcoIvaDetTmpConfiguration()
            : this("dbo")
        {
        }

        public BcoIvaDetTmpConfiguration(string schema)
        {
            ToTable("bco_iva_det_TMP", schema);
            HasKey(x => x.IdRcnIvaDet);

            Property(x => x.IdRcnIvaDet).HasColumnName(@"id_rcn_iva_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRcnIva).HasColumnName(@"id_rcn_iva").HasColumnType("int").IsRequired();
            Property(x => x.IdBcoAux).HasColumnName(@"id_bco_aux").HasColumnType("int").IsRequired();
            Property(x => x.IdSisImp).HasColumnName(@"id_sis_imp").HasColumnType("int").IsRequired();
            Property(x => x.TipIva).HasColumnName(@"tip_iva").HasColumnType("tinyint").IsRequired();
            Property(x => x.IvaApl).HasColumnName(@"iva_apl").HasColumnType("float").IsRequired();
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdBcoIvaAux).HasColumnName(@"id_bco_iva_aux").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
