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

    // SIR_170_OBSERV_SOL_TRANSPORTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir170ObservSolTransporteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir170ObservSolTransporte>
    {
        public SIR_Sir170ObservSolTransporteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir170ObservSolTransporteConfiguration(string schema)
        {
            ToTable("SIR_170_OBSERV_SOL_TRANSPORTE", schema);
            HasKey(x => x.NIdObSolTrans170);

            Property(x => x.NIdObSolTrans170).HasColumnName(@"nIdObSolTrans170").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdSolTrans169).HasColumnName(@"nIdSolTrans169").HasColumnType("int").IsRequired();
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir170ObservSolTransporte).HasForeignKey(c => c.NIdUsuario).WillCascadeOnDelete(false); // FK_SIR_170 _OBSERV_SOL_TRANSPORTE_cat_usr
            HasRequired(a => a.SIR_Sir169SolicitudTransporte).WithMany(b => b.SIR_Sir170ObservSolTransporte).HasForeignKey(c => c.NIdSolTrans169).WillCascadeOnDelete(false); // FK_SIR_170 _OBSERV_SOL_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE
        }
    }

}
// </auto-generated>
