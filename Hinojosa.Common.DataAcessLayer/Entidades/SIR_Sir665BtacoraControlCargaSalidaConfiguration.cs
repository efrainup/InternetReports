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

    // SIR_665_BTACORA_CONTROL_CARGA_SALIDA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir665BtacoraControlCargaSalidaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir665BtacoraControlCargaSalida>
    {
        public SIR_Sir665BtacoraControlCargaSalidaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir665BtacoraControlCargaSalidaConfiguration(string schema)
        {
            ToTable("SIR_665_BTACORA_CONTROL_CARGA_SALIDA", schema);
            HasKey(x => new { x.NIdCargaSuelta66, x.NConsecutivo, x.DBitacora, x.NIdUsuario, x.NTipoUsuario, x.NEstatus });

            Property(x => x.NIdControlCargaSalida661).HasColumnName(@"nIdControlCargaSalida661").HasColumnType("int").IsOptional();
            Property(x => x.NIdCargaDet135).HasColumnName(@"nIdCargaDet135").HasColumnType("int").IsOptional();
            Property(x => x.NIdCargaSuelta66).HasColumnName(@"nIdCargaSuelta66").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NConsecutivo).HasColumnName(@"nConsecutivo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DBitacora).HasColumnName(@"dBitacora").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NTipoUsuario).HasColumnName(@"nTipoUsuario").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NEstatus).HasColumnName(@"nEstatus").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasOptional(a => a.SIR_Sir135CargaSueltaDetalle).WithMany(b => b.SIR_Sir665BtacoraControlCargaSalida).HasForeignKey(c => c.NIdCargaDet135).WillCascadeOnDelete(false); // FK_SIR_665_BTACORA_CONTROL_CARGA_SALIDA_SIR_135_CARGA_SUELTA_DETALLE
            HasOptional(a => a.SIR_Sir661ControlCargaSalida).WithMany(b => b.SIR_Sir665BtacoraControlCargaSalida).HasForeignKey(c => c.NIdControlCargaSalida661).WillCascadeOnDelete(false); // FK_SIR_665_BTACORA_CONTROL_CARGA_SALIDA_SIR_661_CONTROL_CARGA_SALIDA
            HasRequired(a => a.SIR_Sir66CargaSuelta).WithMany(b => b.SIR_Sir665BtacoraControlCargaSalida).HasForeignKey(c => c.NIdCargaSuelta66).WillCascadeOnDelete(false); // FK_SIR_665_BTACORA_CONTROL_CARGA_SALIDA_SIR_66_CARGA_SUELTA
        }
    }

}
// </auto-generated>