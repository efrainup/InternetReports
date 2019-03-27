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

    // SIR_813_DODA_CONT_PEDIMENTO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir813DodaContPedimentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir813DodaContPedimento>
    {
        public SIR_Sir813DodaContPedimentoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir813DodaContPedimentoConfiguration(string schema)
        {
            ToTable("SIR_813_DODA_CONT_PEDIMENTO", schema);
            HasKey(x => new { x.NIdDodaped810, x.NIdDodaCont811 });

            Property(x => x.NIdDodaped810).HasColumnName(@"nIdDODAPED810").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdContenedor76).HasColumnName(@"nIdContenedor76").HasColumnType("int").IsOptional();
            Property(x => x.NIdDodaCont811).HasColumnName(@"nIdDODACont811").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasOptional(a => a.SIR_Sir76Contenedore).WithMany(b => b.SIR_Sir813DodaContPedimento).HasForeignKey(c => c.NIdContenedor76).WillCascadeOnDelete(false); // FK_SIR_813_DODA_CONT_PEDIMENTO_SIR_76_CONTENEDORES
            HasRequired(a => a.SIR_Sir810DodaPedimento).WithMany(b => b.SIR_Sir813DodaContPedimento).HasForeignKey(c => c.NIdDodaped810).WillCascadeOnDelete(false); // FK_SIR_813_DODA_CONT_PEDIMENTO_SIR_810_DODA_PEDIMENTOS
            HasRequired(a => a.SIR_Sir811DodaContenedore).WithMany(b => b.SIR_Sir813DodaContPedimento).HasForeignKey(c => c.NIdDodaCont811).WillCascadeOnDelete(false); // FK_SIR_813_DODA_CONT_PEDIMENTO_SIR_811_DODA_CONTENEDORES
        }
    }

}
// </auto-generated>