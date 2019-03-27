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

    // SIR_57_DAT_CLIENTE_FACT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir57DatClienteFactConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir57DatClienteFact>
    {
        public SIR_Sir57DatClienteFactConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir57DatClienteFactConfiguration(string schema)
        {
            ToTable("SIR_57_DAT_CLIENTE_FACT", schema);
            HasKey(x => x.NIdDatClienteFact57);

            Property(x => x.NIdDatClienteFact57).HasColumnName(@"nIdDatClienteFact57").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired();
            Property(x => x.DFechaCreacion).HasColumnName(@"dFechaCreacion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatCliente).WithMany(b => b.SIR_Sir57DatClienteFact).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_57_DAT_CLIENTE_FACT_cat_clientes
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir57DatClienteFact).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_57_DAT_CLIENTE_FACT_cat_usr_ed
        }
    }

}
// </auto-generated>