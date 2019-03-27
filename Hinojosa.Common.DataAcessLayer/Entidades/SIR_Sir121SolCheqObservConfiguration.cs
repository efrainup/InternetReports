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

    // SIR_121_SOL_CHEQ_OBSERV
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir121SolCheqObservConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir121SolCheqObserv>
    {
        public SIR_Sir121SolCheqObservConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir121SolCheqObservConfiguration(string schema)
        {
            ToTable("SIR_121_SOL_CHEQ_OBSERV", schema);
            HasKey(x => x.NIdChequeObserv121);

            Property(x => x.NIdChequeObserv121).HasColumnName(@"nIdChequeObserv121").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdSolCheque120).HasColumnName(@"nIdSolCheque120").HasColumnType("int").IsRequired();
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsOptional();
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdUsuarioAdmin).HasColumnName(@"nIdUsuarioAdmin").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admina01Usuario).WithMany(b => b.SIR_Sir121SolCheqObserv).HasForeignKey(c => c.NIdUsuarioAdmin).WillCascadeOnDelete(false); // FK_SIR_121_SOL_CHEQ_OBSERV_ADMINA_01_USUARIOS
            HasOptional(a => a.CatUsr).WithMany(b => b.SIR_Sir121SolCheqObserv).HasForeignKey(c => c.NIdUsuario).WillCascadeOnDelete(false); // FK_SIR_121_SOL_CHEQ_OBSERV_cat_usr
            HasRequired(a => a.SIR_Sir120SolicitudCheque).WithMany(b => b.SIR_Sir121SolCheqObserv).HasForeignKey(c => c.NIdSolCheque120).WillCascadeOnDelete(false); // FK_SIR_121_SOL_CHEQ_OBSERV_SIR_120_SOLICITUD_CHEQUES
        }
    }

}
// </auto-generated>
