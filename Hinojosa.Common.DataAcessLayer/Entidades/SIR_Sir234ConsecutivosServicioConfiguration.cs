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

    // SIR_234_CONSECUTIVOS_SERVICIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir234ConsecutivosServicioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir234ConsecutivosServicio>
    {
        public SIR_Sir234ConsecutivosServicioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir234ConsecutivosServicioConfiguration(string schema)
        {
            ToTable("SIR_234_CONSECUTIVOS_SERVICIOS", schema);
            HasKey(x => x.NIdConsec234);

            Property(x => x.NIdConsec234).HasColumnName(@"nIdConsec234").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdBodIns200).HasColumnName(@"nIdBodIns200").HasColumnType("int").IsOptional();
            Property(x => x.NIdBodServ199).HasColumnName(@"nIdBodServ199").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir199BodegaServicio).WithMany(b => b.SIR_Sir234ConsecutivosServicio).HasForeignKey(c => c.NIdBodServ199).WillCascadeOnDelete(false); // FK_SIR_234_CONSECUTIVOS_SERVICIOS_SIR_199_BODEGA_SERVICIOS
            HasOptional(a => a.SIR_Sir200BodegaInsumo).WithMany(b => b.SIR_Sir234ConsecutivosServicio).HasForeignKey(c => c.NIdBodIns200).WillCascadeOnDelete(false); // FK_SIR_234_CONSECUTIVOS_SERVICIOS_SIR_200_BODEGA_INSUMOS
        }
    }

}
// </auto-generated>
