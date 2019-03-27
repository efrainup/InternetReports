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

    // SIR_809_DODA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir809DodaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir809Doda>
    {
        public SIR_Sir809DodaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir809DodaConfiguration(string schema)
        {
            ToTable("SIR_809_DODA", schema);
            HasKey(x => x.NIdDoda809);

            Property(x => x.NIdDoda809).HasColumnName(@"nIdDODA809").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NFolio).HasColumnName(@"nFolio").HasColumnType("int").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired();
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.SNumTransaccion).HasColumnName(@"sNumTransaccion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SNumIntegracion).HasColumnName(@"sNumIntegracion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DFechaTransaccion).HasColumnName(@"dFechaTransaccion").HasColumnType("datetime").IsOptional();
            Property(x => x.NTipoRepresentante).HasColumnName(@"nTipoRepresentante").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdRepresentante).HasColumnName(@"nIdRepresentante").HasColumnType("int").IsRequired();
            Property(x => x.NTipoMovimiento).HasColumnName(@"nTipoMovimiento").HasColumnType("tinyint").IsRequired();
            Property(x => x.SIdentificador).HasColumnName(@"sIdentificador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SCaat).HasColumnName(@"sCAAT").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.SFastId).HasColumnName(@"sFastID").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NEstatus).HasColumnName(@"nEstatus").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
            Property(x => x.BEsSaai).HasColumnName(@"bEsSAAI").HasColumnType("bit").IsOptional();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsOptional();
            Property(x => x.NTipoDocumentos).HasColumnName(@"nTipoDocumentos").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdDetalleEnvio814).HasColumnName(@"nIdDetalleEnvio814").HasColumnType("int").IsOptional();
            Property(x => x.NIdTransportista).HasColumnName(@"nIdTransportista").HasColumnType("int").IsOptional();
            Property(x => x.BEsPita).HasColumnName(@"bEsPita").HasColumnType("bit").IsOptional();
            Property(x => x.SNumeroGafeteUnico).HasColumnName(@"sNumeroGafeteUnico").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(24);

            // Foreign keys
            HasRequired(a => a.CatEmp).WithMany(b => b.SIR_Sir809Doda).HasForeignKey(c => c.NIdRepresentante).WillCascadeOnDelete(false); // FK_SIR_809_DODA_cat_emp
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir809Doda).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_809_DODA_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>
