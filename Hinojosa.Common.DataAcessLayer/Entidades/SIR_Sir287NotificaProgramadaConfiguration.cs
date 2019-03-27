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

    // SIR_287_NOTIFICA_PROGRAMADAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir287NotificaProgramadaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir287NotificaProgramada>
    {
        public SIR_Sir287NotificaProgramadaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir287NotificaProgramadaConfiguration(string schema)
        {
            ToTable("SIR_287_NOTIFICA_PROGRAMADAS", schema);
            HasKey(x => x.NIdProgramacion287);

            Property(x => x.NIdProgramacion287).HasColumnName(@"nIdProgramacion287").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdEvento285).HasColumnName(@"nIdEvento285").HasColumnType("int").IsRequired();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir287NotificaProgramada).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_287_NOTIFICA_PROGRAMADAS_cat_clientes
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir287NotificaProgramada).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_287_NOTIFICA_PROGRAMADAS_cat_usr_ed
            HasRequired(a => a.SIR_Sir285NotificaEvento).WithMany(b => b.SIR_Sir287NotificaProgramada).HasForeignKey(c => c.NIdEvento285).WillCascadeOnDelete(false); // FK_SIR_287_NOTIFICA_PROGRAMADAS_SIR_285_NOTIFICA_EVENTOS
        }
    }

}
// </auto-generated>
