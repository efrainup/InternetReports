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

    // sis_ref_imptos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefImptoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRefImpto>
    {
        public SisRefImptoConfiguration()
            : this("dbo")
        {
        }

        public SisRefImptoConfiguration(string schema)
        {
            ToTable("sis_ref_imptos", schema);
            HasKey(x => x.IdRefImpto);

            Property(x => x.IdRefImpto).HasColumnName(@"id_ref_impto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdTipImpto).HasColumnName(@"id_tip_impto").HasColumnType("int").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
