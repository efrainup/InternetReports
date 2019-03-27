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

    // SIR_211_TLC_EXPORTACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir211TlcExportacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir211TlcExportacione>
    {
        public SIR_Sir211TlcExportacioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir211TlcExportacioneConfiguration(string schema)
        {
            ToTable("SIR_211_TLC_EXPORTACIONES", schema);
            HasKey(x => x.NIdTlcExp211);

            Property(x => x.NIdTlcExp211).HasColumnName(@"nIdTLCExp211").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPedimento149).HasColumnName(@"nIdPedimento149").HasColumnType("int").IsRequired();
            Property(x => x.NArticulo).HasColumnName(@"nArticulo").HasColumnType("int").IsRequired();
            Property(x => x.DImpuesto).HasColumnName(@"dImpuesto").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir211TlcExportacione).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_211_TLC_EXPORTACIONES_cat_usr_ed
            HasRequired(a => a.SIR_Sir149Pedimento).WithMany(b => b.SIR_Sir211TlcExportacione).HasForeignKey(c => c.NIdPedimento149).WillCascadeOnDelete(false); // FK_SIR_211_TLC_EXPORTACIONES_SIR_149_PEDIMENTO
        }
    }

}
// </auto-generated>
