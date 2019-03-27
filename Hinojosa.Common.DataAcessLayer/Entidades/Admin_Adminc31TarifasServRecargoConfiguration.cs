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

    // ADMINC_31_TARIFAS_SERV_RECARGOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc31TarifasServRecargoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Adminc31TarifasServRecargo>
    {
        public Admin_Adminc31TarifasServRecargoConfiguration()
            : this("Admin")
        {
        }

        public Admin_Adminc31TarifasServRecargoConfiguration(string schema)
        {
            ToTable("ADMINC_31_TARIFAS_SERV_RECARGOS", schema);
            HasKey(x => x.NIdTsRec31);

            Property(x => x.NIdTsRec31).HasColumnName(@"nIdTSRec31").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdServicio12).HasColumnName(@"nIdServicio12").HasColumnType("int").IsRequired();
            Property(x => x.NRangoInicio).HasColumnName(@"nRangoInicio").HasColumnType("int").IsRequired();
            Property(x => x.NRangoFin).HasColumnName(@"nRangoFin").HasColumnType("int").IsRequired();
            Property(x => x.NPorcenImporte).HasColumnName(@"nPorcenImporte").HasColumnType("decimal").IsRequired().HasPrecision(13,6);

            // Foreign keys
            HasRequired(a => a.Admin_Adminc12Servicio).WithMany(b => b.Admin_Adminc31TarifasServRecargo).HasForeignKey(c => c.NIdServicio12).WillCascadeOnDelete(false); // FK_ADMINC_31_TARIFAS_SERV_RECARGOS_ADMINC_12_SERVICIOS
        }
    }

}
// </auto-generated>
