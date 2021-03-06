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

    // SIRA_46_CONF_SERVICIOS_CONT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira46ConfServiciosContConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira46ConfServiciosCont>
    {
        public SIRAdmin_Sira46ConfServiciosContConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira46ConfServiciosContConfiguration(string schema)
        {
            ToTable("SIRA_46_CONF_SERVICIOS_CONT", schema);
            HasKey(x => x.NIdServCont46);

            Property(x => x.NIdServCont46).HasColumnName(@"nIdServCont46").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>
