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

    // SIR_432_SUCURSAL_CAUSAS_RETRASO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir432SucursalCausasRetrasoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir432SucursalCausasRetraso>
    {
        public SIR_Sir432SucursalCausasRetrasoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir432SucursalCausasRetrasoConfiguration(string schema)
        {
            ToTable("SIR_432_SUCURSAL_CAUSAS_RETRASO", schema);
            HasKey(x => x.NIdCausaRetraso429);

            Property(x => x.NIdCausaRetraso429).HasColumnName(@"nIdCausaRetraso429").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdSucursal12).HasColumnName(@"nIdSucursal12").HasColumnType("int").IsOptional();
            Property(x => x.NIdSucursal).HasColumnName(@"nIdSucursal").HasColumnType("int").IsOptional();
            Property(x => x.NDuracion).HasColumnName(@"nDuracion").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina12Sucursale).WithMany(b => b.SIR_Sir432SucursalCausasRetraso).HasForeignKey(c => c.NIdSucursal12).WillCascadeOnDelete(false); // FK_SIR_432_SUCURSAL_CAUSAS_RETRASO_ADMINA_12_SUCURSALES
            HasRequired(a => a.SIR_Sir429CausasDeRetraso).WithOptional(b => b.SIR_Sir432SucursalCausasRetraso).WillCascadeOnDelete(false); // FK_SIR_432_SUCURSAL_CAUSAS_RETRASO_SIR_429_CAUSAS_DE_RETRASO
        }
    }

}
// </auto-generated>
