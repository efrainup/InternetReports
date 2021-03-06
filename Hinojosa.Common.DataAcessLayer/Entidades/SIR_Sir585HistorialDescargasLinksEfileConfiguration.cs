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

    // SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir585HistorialDescargasLinksEfileConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir585HistorialDescargasLinksEfile>
    {
        public SIR_Sir585HistorialDescargasLinksEfileConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir585HistorialDescargasLinksEfileConfiguration(string schema)
        {
            ToTable("SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE", schema);
            HasKey(x => x.NIdHistorialLinksEfile585);

            Property(x => x.NIdHistorialLinksEfile585).HasColumnName(@"nIdHistorialLinksEfile585").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdDoctoArchivo35).HasColumnName(@"nIdDoctoArchivo35").HasColumnType("int").IsRequired();
            Property(x => x.DFechaDescarga).HasColumnName(@"dFechaDescarga").HasColumnType("datetime").IsOptional();
            Property(x => x.BDescargado).HasColumnName(@"bDescargado").HasColumnType("bit").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir585HistorialDescargasLinksEfile).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_ADMINC_07_CLIENTES
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir585HistorialDescargasLinksEfile).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_cat_clientes
            HasRequired(a => a.SIR_Sir35DocumentosArchivo).WithMany(b => b.SIR_Sir585HistorialDescargasLinksEfile).HasForeignKey(c => c.NIdDoctoArchivo35).WillCascadeOnDelete(false); // FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_SIR_35_DOCUMENTOS_ARCHIVOS
        }
    }

}
// </auto-generated>
