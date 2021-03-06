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

    // cxc_mto_fin_tmp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxcMtoFinTmpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CxcMtoFinTmp>
    {
        public CxcMtoFinTmpConfiguration()
            : this("dbo")
        {
        }

        public CxcMtoFinTmpConfiguration(string schema)
        {
            ToTable("cxc_mto_fin_tmp", schema);
            HasKey(x => x.IdMtoFinTmp);

            Property(x => x.IdMtoFinTmp).HasColumnName(@"id_mto_fin_tmp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.MtoBse).HasColumnName(@"mto_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
