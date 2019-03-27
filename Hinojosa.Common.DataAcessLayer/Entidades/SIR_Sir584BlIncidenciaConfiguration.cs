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

    // SIR_584_BL_INCIDENCIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir584BlIncidenciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir584BlIncidencia>
    {
        public SIR_Sir584BlIncidenciaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir584BlIncidenciaConfiguration(string schema)
        {
            ToTable("SIR_584_BL_INCIDENCIAS", schema);
            HasKey(x => new { x.NIdIncidencia583, x.NIdBl74, x.NIdReferencia60 });

            Property(x => x.NIdIncidencia583).HasColumnName(@"nIdIncidencia583").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdBl74).HasColumnName(@"nIdBL74").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir583CatalogoIncidencia).WithMany(b => b.SIR_Sir584BlIncidencia).HasForeignKey(c => c.NIdIncidencia583); // FK_SIR_584_BL_INCIDENCIAS_SIR_583_CATALOGO_INCIDENCIAS
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir584BlIncidencia).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_584_BL_INCIDENCIAS_SIR_60_REFERENCIAS
            HasRequired(a => a.SIR_Sir74ConocimientosMaritimo).WithMany(b => b.SIR_Sir584BlIncidencia).HasForeignKey(c => c.NIdBl74).WillCascadeOnDelete(false); // FK_SIR_584_BL_INCIDENCIAS_SIR_74_CONOCIMIENTOS_MARITIMOS
        }
    }

}
// </auto-generated>
