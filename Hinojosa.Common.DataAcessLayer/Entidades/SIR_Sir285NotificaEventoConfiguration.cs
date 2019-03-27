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

    // SIR_285_NOTIFICA_EVENTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir285NotificaEventoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir285NotificaEvento>
    {
        public SIR_Sir285NotificaEventoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir285NotificaEventoConfiguration(string schema)
        {
            ToTable("SIR_285_NOTIFICA_EVENTOS", schema);
            HasKey(x => x.NIdEvento285);

            Property(x => x.NIdEvento285).HasColumnName(@"nIdEvento285").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdCatEvento282).HasColumnName(@"nIdCatEvento282").HasColumnType("int").IsRequired();
            Property(x => x.NOrden).HasColumnName(@"nOrden").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir282NotificaCategoria).WithMany(b => b.SIR_Sir285NotificaEvento).HasForeignKey(c => c.NIdCatEvento282).WillCascadeOnDelete(false); // FK_SIR_285_NOTIFICA_EVENTOS_SIR_282_NOTIFICA_CATEGORIAS
        }
    }

}
// </auto-generated>