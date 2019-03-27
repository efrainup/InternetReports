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

    // Monitor_Facturas3ros
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MonitorFacturas3RosConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MonitorFacturas3Ros>
    {
        public MonitorFacturas3RosConfiguration()
            : this("dbo")
        {
        }

        public MonitorFacturas3RosConfiguration(string schema)
        {
            ToTable("Monitor_Facturas3ros", schema);
            HasKey(x => x.NIdMonitor);

            Property(x => x.NIdMonitor).HasColumnName(@"nIdMonitor").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.NIdProducto).HasColumnName(@"nIdProducto").HasColumnType("int").IsRequired();
            Property(x => x.NIdProveedor).HasColumnName(@"nIdProveedor").HasColumnType("int").IsRequired();
            Property(x => x.BFactura).HasColumnName(@"bFactura").HasColumnType("bit").IsOptional();
            Property(x => x.SNumFactura).HasColumnName(@"sNumFactura").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NEstado).HasColumnName(@"nEstado").HasColumnType("int").IsOptional();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("int").IsRequired();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
