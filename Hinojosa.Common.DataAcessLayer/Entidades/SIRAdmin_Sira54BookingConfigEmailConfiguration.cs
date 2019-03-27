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

    // SIRA_54_BOOKING_CONFIG_EMAIL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira54BookingConfigEmailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira54BookingConfigEmail>
    {
        public SIRAdmin_Sira54BookingConfigEmailConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira54BookingConfigEmailConfiguration(string schema)
        {
            ToTable("SIRA_54_BOOKING_CONFIG_EMAIL", schema);
            HasKey(x => x.NIdBkConfigEmail54);

            Property(x => x.NIdBkConfigEmail54).HasColumnName(@"nIdBkConfigEmail54").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NDias).HasColumnName(@"nDias").HasColumnType("int").IsOptional();
            Property(x => x.DFechaReporte).HasColumnName(@"dFechaReporte").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdEmailContactos55).HasColumnName(@"nIdEmailContactos55").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIRAdmin_Sira55EmailContacto).WithMany(b => b.SIRAdmin_Sira54BookingConfigEmail).HasForeignKey(c => c.NIdEmailContactos55); // FK_SIRA_54_BOOKING_CONFIG_EMAIL_SIRA_55_EMAIL_CONTACTOS
        }
    }

}
// </auto-generated>