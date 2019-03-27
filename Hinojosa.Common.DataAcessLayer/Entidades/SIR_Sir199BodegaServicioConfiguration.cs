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

    // SIR_199_BODEGA_SERVICIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir199BodegaServicioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir199BodegaServicio>
    {
        public SIR_Sir199BodegaServicioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir199BodegaServicioConfiguration(string schema)
        {
            ToTable("SIR_199_BODEGA_SERVICIOS", schema);
            HasKey(x => x.NIdBodServ199);

            Property(x => x.NIdBodServ199).HasColumnName(@"nIdBodServ199").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdServicio).HasColumnName(@"nIdServicio").HasColumnType("int").IsRequired();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaSolicitud).HasColumnName(@"dFechaSolicitud").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.DFechaInicio).HasColumnName(@"dFechaInicio").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaTermino).HasColumnName(@"dFechaTermino").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NCantidad).HasColumnName(@"nCantidad").HasColumnType("int").IsRequired();
            Property(x => x.SFactura).HasColumnName(@"sFactura").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.DFechaFacturacion).HasColumnName(@"dFechaFacturacion").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdEntrada156).HasColumnName(@"nIdEntrada156").HasColumnType("int").IsRequired();
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.BAplicaPrecEspecial).HasColumnName(@"bAplicaPrecEspecial").HasColumnType("bit").IsRequired();
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("decimal").IsOptional().HasPrecision(13,3);

            // Foreign keys
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir199BodegaServicio).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_199_BODEGA_SERVICIOS_SIR_60_REFERENCIAS
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir199BodegaServicio).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_199_BODEGA_SERVICIOS_cat_usr_ed
            HasRequired(a => a.SIR_Sir156EntradasBodega).WithMany(b => b.SIR_Sir199BodegaServicio).HasForeignKey(c => c.NIdEntrada156).WillCascadeOnDelete(false); // FK_SIR_199_BODEGA_SERVICIOS_SIR_156_ENTRADAS_BODEGAS
        }
    }

}
// </auto-generated>
