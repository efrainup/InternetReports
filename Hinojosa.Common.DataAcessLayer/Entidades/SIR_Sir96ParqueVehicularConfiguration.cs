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

    // SIR_96_PARQUE_VEHICULAR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir96ParqueVehicularConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir96ParqueVehicular>
    {
        public SIR_Sir96ParqueVehicularConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir96ParqueVehicularConfiguration(string schema)
        {
            ToTable("SIR_96_PARQUE_VEHICULAR", schema);
            HasKey(x => x.NIdVeh96);

            Property(x => x.NIdVeh96).HasColumnName(@"nIdVeh96").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SNumSerie).HasColumnName(@"sNumSerie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SNumEconomico).HasColumnName(@"sNumEconomico").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdTipVeh108).HasColumnName(@"nIdTipVeh108").HasColumnType("int").IsRequired();
            Property(x => x.NIdMarca109).HasColumnName(@"nIdMarca109").HasColumnType("int").IsRequired();
            Property(x => x.SModelo).HasColumnName(@"sModelo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NAnio).HasColumnName(@"nAnio").HasColumnType("smallint").IsRequired();
            Property(x => x.SPlacas).HasColumnName(@"sPlacas").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SNumMotor).HasColumnName(@"sNumMotor").HasColumnType("varbinary").IsRequired().HasMaxLength(50);
            Property(x => x.NPeso).HasColumnName(@"nPeso").HasColumnType("decimal").IsRequired().HasPrecision(7,2);
            Property(x => x.NNumEjes).HasColumnName(@"nNumEjes").HasColumnType("tinyint").IsRequired();
            Property(x => x.NAlto).HasColumnName(@"nAlto").HasColumnType("decimal").IsOptional().HasPrecision(7,2);
            Property(x => x.NAncho).HasColumnName(@"nAncho").HasColumnType("decimal").IsOptional().HasPrecision(7,2);
            Property(x => x.NLargo).HasColumnName(@"nLargo").HasColumnType("decimal").IsOptional().HasPrecision(7,2);
            Property(x => x.NCarga).HasColumnName(@"nCarga").HasColumnType("decimal").IsOptional().HasPrecision(7,2);
            Property(x => x.SRutaFoto).HasColumnName(@"sRutaFoto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NVolumen).HasColumnName(@"nVolumen").HasColumnType("decimal").IsOptional().HasPrecision(7,2);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir96ParqueVehicular).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_96_PADRON_VEHICULAR_cat_usr_ed
            HasRequired(a => a.SIR_Sir108TiposVehiculo).WithMany(b => b.SIR_Sir96ParqueVehicular).HasForeignKey(c => c.NIdTipVeh108).WillCascadeOnDelete(false); // FK_SIR_96_PADRON_VEHICULAR_SIR_108_TIPOS_VEHICULOS
            HasRequired(a => a.SIR_Sir109MarcasVehiculo).WithMany(b => b.SIR_Sir96ParqueVehicular).HasForeignKey(c => c.NIdMarca109).WillCascadeOnDelete(false); // FK_SIR_96_PADRON_VEHICULAR_SIR_109_MARCAS_VEHICULOS
        }
    }

}
// </auto-generated>
