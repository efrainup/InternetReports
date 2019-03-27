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

    // SIR_355_PREVALIDADORES_CLIENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir355PrevalidadoresClienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir355PrevalidadoresCliente>
    {
        public SIR_Sir355PrevalidadoresClienteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir355PrevalidadoresClienteConfiguration(string schema)
        {
            ToTable("SIR_355_PREVALIDADORES_CLIENTES", schema);
            HasKey(x => x.NIdServPre247);

            Property(x => x.NIdServPre247).HasColumnName(@"nIdServPre247").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir355PrevalidadoresCliente).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_355_PREVALIDADORES_CLIENTES_ADMINC_07_CLIENTES
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir355PrevalidadoresCliente).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_355_PREVALIDADORES_CLIENTES_cat_clientes
            HasRequired(a => a.SIR_Sir247ServicioPrevalidacion).WithOptional(b => b.SIR_Sir355PrevalidadoresCliente).WillCascadeOnDelete(false); // FK_SIR_355_PREVALIDADORES_CLIENTES_SIR_247_SERVICIO_PREVALIDACION
        }
    }

}
// </auto-generated>
