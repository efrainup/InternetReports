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

    // sis_ref_fracciones
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefFraccioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRefFraccione>
    {
        public SisRefFraccioneConfiguration()
            : this("dbo")
        {
        }

        public SisRefFraccioneConfiguration(string schema)
        {
            ToTable("sis_ref_fracciones", schema);
            HasKey(x => new { x.IdFac, x.IdRef, x.Numfrac, x.Mercancia });

            Property(x => x.IdFac).HasColumnName(@"id_fac").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numfrac).HasColumnName(@"numfrac").HasColumnType("nvarchar").IsRequired().HasMaxLength(8).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mercancia).HasColumnName(@"mercancia").HasColumnType("nvarchar").IsRequired().HasMaxLength(254).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
