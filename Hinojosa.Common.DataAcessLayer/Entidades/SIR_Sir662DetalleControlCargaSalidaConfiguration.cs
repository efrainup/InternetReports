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

    // SIR_662_DETALLE_CONTROL_CARGA_SALIDA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir662DetalleControlCargaSalidaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir662DetalleControlCargaSalida>
    {
        public SIR_Sir662DetalleControlCargaSalidaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir662DetalleControlCargaSalidaConfiguration(string schema)
        {
            ToTable("SIR_662_DETALLE_CONTROL_CARGA_SALIDA", schema);
            HasKey(x => new { x.NIdControlCargaSalida661, x.NIdCargaDet135, x.NConsecutivo });

            Property(x => x.NIdControlCargaSalida661).HasColumnName(@"nIdControlCargaSalida661").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdCargaDet135).HasColumnName(@"nIdCargaDet135").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NConsecutivo).HasColumnName(@"nConsecutivo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DControlCarga).HasColumnName(@"dControlCarga").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsRequired();
            Property(x => x.NTipoUsuario).HasColumnName(@"nTipoUsuario").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir135CargaSueltaDetalle).WithMany(b => b.SIR_Sir662DetalleControlCargaSalida).HasForeignKey(c => c.NIdCargaDet135).WillCascadeOnDelete(false); // FK_SIR_662_DETALLE_CONTROL_CARGA_SALIDA_SIR_135_CARGA_SUELTA_DETALLE
            HasRequired(a => a.SIR_Sir661ControlCargaSalida).WithMany(b => b.SIR_Sir662DetalleControlCargaSalida).HasForeignKey(c => c.NIdControlCargaSalida661).WillCascadeOnDelete(false); // FK_SIR_662_DETALLE_CONTROL_CARGA_SALIDA_SIR_661_CONTROL_CARGA_SALIDA
        }
    }

}
// </auto-generated>
