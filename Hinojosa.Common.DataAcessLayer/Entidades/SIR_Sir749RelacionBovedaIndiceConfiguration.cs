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

    // SIR_749_RELACION_BOVEDA_INDICE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir749RelacionBovedaIndiceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir749RelacionBovedaIndice>
    {
        public SIR_Sir749RelacionBovedaIndiceConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir749RelacionBovedaIndiceConfiguration(string schema)
        {
            ToTable("SIR_749_RELACION_BOVEDA_INDICE", schema);
            HasKey(x => x.NIdRelBovVal749);

            Property(x => x.NIdRelBovVal749).HasColumnName(@"nIdRelBovVal749").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdBoveda599).HasColumnName(@"nIdBoveda599").HasColumnType("int").IsRequired();
            Property(x => x.NIdIndiceBoveda598).HasColumnName(@"nIdIndiceBoveda598").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir598IndicesBoveda).WithMany(b => b.SIR_Sir749RelacionBovedaIndice).HasForeignKey(c => c.NIdIndiceBoveda598).WillCascadeOnDelete(false); // FK_SIR_749_RELACION_BOVEDA_SIR_598_INDICES_BOVEDAS
            HasRequired(a => a.SIR_Sir599Boveda).WithMany(b => b.SIR_Sir749RelacionBovedaIndice).HasForeignKey(c => c.NIdBoveda599).WillCascadeOnDelete(false); // FK_SIR_749_RELACION_BOVEDA_INDICE_SIR_599_BOVEDAS
        }
    }

}
// </auto-generated>
