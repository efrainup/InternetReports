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

    // SIR_186_ORDENES_REMISIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir186OrdenesRemisioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir186OrdenesRemisione>
    {
        public SIR_Sir186OrdenesRemisioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir186OrdenesRemisioneConfiguration(string schema)
        {
            ToTable("SIR_186_ORDENES_REMISIONES", schema);
            HasKey(x => x.NIdRemision186);

            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NFolio).HasColumnName(@"nFolio").HasColumnType("int").IsRequired();
            Property(x => x.SInstrucciones).HasColumnName(@"sInstrucciones").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NIdSolTrans169).HasColumnName(@"nIdSolTrans169").HasColumnType("int").IsOptional();
            Property(x => x.NIdRemision186).HasColumnName(@"nIdRemision186").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Foreign keys
            HasOptional(a => a.SIR_Sir169SolicitudTransporte).WithMany(b => b.SIR_Sir186OrdenesRemisione).HasForeignKey(c => c.NIdSolTrans169).WillCascadeOnDelete(false); // FK_SIR_186_ORDENES_REMISIONES_SIR_169_SOLICITUD_TRANSPORTE
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir186OrdenesRemisione).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_186_ORDENES_REMISIONES_cat_usr
        }
    }

}
// </auto-generated>
