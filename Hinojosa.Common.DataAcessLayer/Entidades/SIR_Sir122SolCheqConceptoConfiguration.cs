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

    // SIR_122_SOL_CHEQ_CONCEPTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir122SolCheqConceptoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir122SolCheqConcepto>
    {
        public SIR_Sir122SolCheqConceptoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir122SolCheqConceptoConfiguration(string schema)
        {
            ToTable("SIR_122_SOL_CHEQ_CONCEPTOS", schema);
            HasKey(x => x.NIdConcepto122);

            Property(x => x.NIdConcepto122).HasColumnName(@"nIdConcepto122").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdSolCheque120).HasColumnName(@"nIdSolCheque120").HasColumnType("int").IsRequired();
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.NIdProducto).HasColumnName(@"nIdProducto").HasColumnType("int").IsOptional();
            Property(x => x.SFactura).HasColumnName(@"sFactura").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("decimal").IsRequired().HasPrecision(12,3);
            Property(x => x.DFechaFactura).HasColumnName(@"dFechaFactura").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdRevalidacion50).HasColumnName(@"nIdRevalidacion50").HasColumnType("int").IsOptional();
            Property(x => x.NIdRefDetalle).HasColumnName(@"nIdRefDetalle").HasColumnType("int").IsOptional();
            Property(x => x.NIdConcepto).HasColumnName(@"nIdConcepto").HasColumnType("int").IsOptional();
            Property(x => x.NEntidadAplica).HasColumnName(@"nEntidadAplica").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc28ConceptosCuenta).WithMany(b => b.SIR_Sir122SolCheqConcepto).HasForeignKey(c => c.NIdConcepto).WillCascadeOnDelete(false); // FK_SIR_122_SOL_CHEQ_CONCEPTOS_ADMINC_28_CONCEPTOS_CUENTAS
            HasOptional(a => a.CatPro).WithMany(b => b.SIR_Sir122SolCheqConcepto).HasForeignKey(c => c.NIdProducto).WillCascadeOnDelete(false); // FK_SIR_122_SOL_CHEQ_CONCEPTOS_cat_pro
            HasOptional(a => a.SIR_Sir50Revalidacion).WithMany(b => b.SIR_Sir122SolCheqConcepto).HasForeignKey(c => c.NIdRevalidacion50).WillCascadeOnDelete(false); // FK_SIR_122_SOL_CHEQ_CONCEPTOS_SIR_50_REVALIDACION
            HasOptional(a => a.SisRefDet).WithMany(b => b.SIR_Sir122SolCheqConcepto).HasForeignKey(c => c.NIdRefDetalle).WillCascadeOnDelete(false); // FK_SIR_122_SOL_CHEQ_CONCEPTOS_sis_ref_det
            HasRequired(a => a.SIR_Sir120SolicitudCheque).WithMany(b => b.SIR_Sir122SolCheqConcepto).HasForeignKey(c => c.NIdSolCheque120).WillCascadeOnDelete(false); // FK_SIR_122_SOL_CHEQ_CONCEPTOS_SIR_120_SOLICITUD_CHEQUES
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir122SolCheqConcepto).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_122_SOL_CHEQ_CONCEPTOS_SIR_60_REFERENCIAS
        }
    }

}
// </auto-generated>
