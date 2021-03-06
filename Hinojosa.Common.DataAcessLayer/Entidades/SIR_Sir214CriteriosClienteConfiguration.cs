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

    // SIR_214_CRITERIOS_CLIENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir214CriteriosClienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir214CriteriosCliente>
    {
        public SIR_Sir214CriteriosClienteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir214CriteriosClienteConfiguration(string schema)
        {
            ToTable("SIR_214_CRITERIOS_CLIENTES", schema);
            HasKey(x => new { x.NIdCriterio212, x.NIdCliente, x.DFechaEdicion, x.NIdUsuarioEd });

            Property(x => x.NIdCriterio212).HasColumnName(@"nIdCriterio212").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.CatCliente).WithMany(b => b.SIR_Sir214CriteriosCliente).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_214_CRITERIOS_CLIENTES_cat_clientes
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir214CriteriosCliente).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_214_CRITERIOS_CLIENTES_cat_usr
            HasRequired(a => a.SIR_Sir212CriteriosCobro).WithMany(b => b.SIR_Sir214CriteriosCliente).HasForeignKey(c => c.NIdCriterio212).WillCascadeOnDelete(false); // FK_SIR_214_CRITERIOS_CLIENTES_SIR_212_CRITERIOS_COBRO
        }
    }

}
// </auto-generated>
