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

    // ctb_est_obj
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbEstObjConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CtbEstObj>
    {
        public CtbEstObjConfiguration()
            : this("dbo")
        {
        }

        public CtbEstObjConfiguration(string schema)
        {
            ToTable("ctb_est_obj", schema);
            HasKey(x => x.IdEstObj);

            Property(x => x.IdEstObj).HasColumnName(@"id_est_obj").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipObj).HasColumnName(@"id_tip_obj").HasColumnType("int").IsRequired();
            Property(x => x.IdTipRub).HasColumnName(@"id_tip_rub").HasColumnType("int").IsRequired();
            Property(x => x.IdCtaDef).HasColumnName(@"id_cta_def").HasColumnType("int").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
