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

    // sis_rel_tip_clas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelTipClaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_SisRelTipCla>
    {
        public crm_SisRelTipClaConfiguration()
            : this("crm")
        {
        }

        public crm_SisRelTipClaConfiguration(string schema)
        {
            ToTable("sis_rel_tip_clas", schema);
            HasKey(x => x.IdRelTipClas);

            Property(x => x.IdRelTipClas).HasColumnName(@"id_rel_tip_clas").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTip).HasColumnName(@"id_tip").HasColumnType("int").IsRequired();
            Property(x => x.IdClas).HasColumnName(@"id_clas").HasColumnType("int").IsRequired();
            Property(x => x.IdTipClasPad).HasColumnName(@"id_tip_clas_pad").HasColumnType("int").IsRequired();
            Property(x => x.NOrden).HasColumnName(@"n_orden").HasColumnType("int").IsRequired();
            Property(x => x.NNivel).HasColumnName(@"n_nivel").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
