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

    // cxp_aux_pre_pag
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxpAuxPrePagConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxpAuxPrePag>
    {
        public CxpAuxPrePagConfiguration()
            : this("dbo")
        {
        }

        public CxpAuxPrePagConfiguration(string schema)
        {
            ToTable("cxp_aux_pre_pag", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCxpAux).HasColumnName(@"id_cxp_aux").HasColumnType("int").IsRequired();
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired();
            Property(x => x.IdTipTrn).HasColumnName(@"id_tip_trn").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
