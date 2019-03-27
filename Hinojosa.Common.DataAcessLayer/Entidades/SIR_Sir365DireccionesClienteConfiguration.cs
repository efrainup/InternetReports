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

    // SIR_365_DIRECCIONES_CLIENTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir365DireccionesClienteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir365DireccionesCliente>
    {
        public SIR_Sir365DireccionesClienteConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir365DireccionesClienteConfiguration(string schema)
        {
            ToTable("SIR_365_DIRECCIONES_CLIENTE", schema);
            HasKey(x => x.NIdDirCliente365);

            Property(x => x.NIdDirCliente365).HasColumnName(@"nIdDirCliente365").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsOptional();
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.SDireccion).HasColumnName(@"sDireccion").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.SCalle).HasColumnName(@"sCalle").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SColonia).HasColumnName(@"sColonia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SCp).HasColumnName(@"sCP").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SNumInterior).HasColumnName(@"sNumInterior").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SNumExterior).HasColumnName(@"sNumExterior").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.SCiudad).HasColumnName(@"sCiudad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.NIdEntFed02).HasColumnName(@"nIdEntFed02").HasColumnType("int").IsOptional();
            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc07Cliente).WithMany(b => b.SIR_Sir365DireccionesCliente).HasForeignKey(c => c.NIdClie07).WillCascadeOnDelete(false); // FK_SIR_365_DIRECCIONES_CLIENTE_ADMINC_07_CLIENTES
            HasOptional(a => a.CatCliente).WithMany(b => b.SIR_Sir365DireccionesCliente).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_365_DIRECCIONES_CLIENTE_cat_clientes
        }
    }

}
// </auto-generated>