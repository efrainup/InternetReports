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

    // SIR_05_MEDIOS_TRANSPORTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir05MediosTransporteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir05MediosTransporte>
    {
        public SIR_Sir05MediosTransporteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir05MediosTransporteConfiguration(string schema)
        {
            ToTable("SIR_05_MEDIOS_TRANSPORTE", schema);
            HasKey(x => x.NIdMedioTrans05);

            Property(x => x.NIdMedioTrans05).HasColumnName(@"nIdMedioTrans05").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NClave).HasColumnName(@"nClave").HasColumnType("tinyint").IsRequired();
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdTipoTrafico25).HasColumnName(@"nIdTipoTrafico25").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
            Property(x => x.NRegistro).HasColumnName(@"nRegistro").HasColumnType("int").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir25TiposTrafico).WithMany(b => b.SIR_Sir05MediosTransporte).HasForeignKey(c => c.NIdTipoTrafico25).WillCascadeOnDelete(false); // FK_SIR_05_MEDIOS_TRANSPORTE_SIR_25_TIPOS_TRAFICO
        }
    }

}
// </auto-generated>
