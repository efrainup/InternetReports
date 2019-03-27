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

    // ADMINC_21_TARIFAS_INSUMOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc21TarifasInsumoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Adminc21TarifasInsumo>
    {
        public Admin_Adminc21TarifasInsumoConfiguration()
            : this("Admin")
        {
        }

        public Admin_Adminc21TarifasInsumoConfiguration(string schema)
        {
            ToTable("ADMINC_21_TARIFAS_INSUMOS", schema);
            HasKey(x => x.NIdTarifaIns21);

            Property(x => x.NIdTarifaIns21).HasColumnName(@"nIdTarifaIns21").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdInsumo20).HasColumnName(@"nIdInsumo20").HasColumnType("int").IsRequired();
            Property(x => x.NPrecio).HasColumnName(@"nPrecio").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.DInicio).HasColumnName(@"dInicio").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.DFin).HasColumnName(@"dFin").HasColumnType("smalldatetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Admin_Adminc20Insumo).WithMany(b => b.Admin_Adminc21TarifasInsumo).HasForeignKey(c => c.NIdInsumo20).WillCascadeOnDelete(false); // FK_ADMINC_21_TARIFAS_INSUMOS_ADMINC_20_INSUMOS
        }
    }

}
// </auto-generated>
