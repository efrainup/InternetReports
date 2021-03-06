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

    // SIR_833_REL_PARTIDA_GUIAALMEX
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir833RelPartidaGuiaalmexConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir833RelPartidaGuiaalmex>
    {
        public SIR_Sir833RelPartidaGuiaalmexConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir833RelPartidaGuiaalmexConfiguration(string schema)
        {
            ToTable("SIR_833_REL_PARTIDA_GUIAALMEX", schema);
            HasKey(x => new { x.NIdGuia832, x.NIdFacturaPartida11 });

            Property(x => x.NIdGuia832).HasColumnName(@"nIdGuia832").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdFacturaPartida11).HasColumnName(@"nIdFacturaPartida11").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir11FacturasPartida).WithMany(b => b.SIR_Sir833RelPartidaGuiaalmex).HasForeignKey(c => c.NIdFacturaPartida11).WillCascadeOnDelete(false); // FK_SIR_833_REL_PARTIDA_GUIAALMEX_SIR_11_FACTURAS_PARTIDAS
            HasRequired(a => a.SIR_Sir832GuiasAlmex).WithMany(b => b.SIR_Sir833RelPartidaGuiaalmex).HasForeignKey(c => c.NIdGuia832).WillCascadeOnDelete(false); // FK_SIR_833_REL_PARTIDA_GUIAALMEX_SIR_832_GUIAS_ALMEX
        }
    }

}
// </auto-generated>
