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

    // SIR_14_TINTERTERMINALES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir14TinterterminaleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir14Tinterterminale>
    {
        public SIR_Sir14TinterterminaleConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir14TinterterminaleConfiguration(string schema)
        {
            ToTable("SIR_14_TINTERTERMINALES", schema);
            HasKey(x => x.NIdTransf14);

            Property(x => x.NIdTransf14).HasColumnName(@"nIdTransf14").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.SNumReferencia).HasColumnName(@"sNumReferencia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(64);
            Property(x => x.NIdReporte93).HasColumnName(@"nIdReporte93").HasColumnType("int").IsOptional();
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaElaboracion).HasColumnName(@"dFechaElaboracion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.SCantidad).HasColumnName(@"sCantidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SUnidad).HasColumnName(@"sUnidad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(800);
            Property(x => x.NPeso).HasColumnName(@"nPeso").HasColumnType("decimal").IsOptional().HasPrecision(14,3);
            Property(x => x.SNombreBarco).HasColumnName(@"sNombreBarco").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(120);
            Property(x => x.SNombreTerminal).HasColumnName(@"sNombreTerminal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SNombrePuerto).HasColumnName(@"sNombrePuerto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.DFechaDescarga).HasColumnName(@"dFechaDescarga").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.SAtencion).HasColumnName(@"sAtencion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SGuia).HasColumnName(@"sGuia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.NTerminalDestino).HasColumnName(@"nTerminalDestino").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir14Tinterterminale).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_14_TINTERTERMINALES_SIR_60_REFERENCIAS
            HasOptional(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.SIR_Sir14Tinterterminale).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_SIR_14_TINTERTERMINALES_SIR_71_SUCURSAL_PATENTE_ADUANA
            HasOptional(a => a.SIR_Sir93Reporte).WithMany(b => b.SIR_Sir14Tinterterminale).HasForeignKey(c => c.NIdReporte93).WillCascadeOnDelete(false); // FK_SIR_14_TINTERTERMINALES_SIR_93_REPORTES
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir14Tinterterminale).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_14_TINTERTERMINALES_cat_usr_ed
        }
    }

}
// </auto-generated>
