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

    // SIR_574_CLIENTE_CARACTERISTICAS_GENERALES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir574ClienteCaracteristicasGeneraleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir574ClienteCaracteristicasGenerale>
    {
        public SIR_Sir574ClienteCaracteristicasGeneraleConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir574ClienteCaracteristicasGeneraleConfiguration(string schema)
        {
            ToTable("SIR_574_CLIENTE_CARACTERISTICAS_GENERALES", schema);
            HasKey(x => x.NIdClieCaracGen574);

            Property(x => x.NIdClieCaracGen574).HasColumnName(@"nIdClieCaracGen574").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired();
            Property(x => x.NIdClie07).HasColumnName(@"nIdClie07").HasColumnType("int").IsOptional();
            Property(x => x.SCaracteristica).HasColumnName(@"sCaracteristica").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.BOcultaRfcExportacion).HasColumnName(@"bOcultaRFCExportacion").HasColumnType("bit").IsOptional();
            Property(x => x.BGeneraArchivoContigencia).HasColumnName(@"bGeneraArchivoContigencia").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatCliente).WithMany(b => b.SIR_Sir574ClienteCaracteristicasGenerale).HasForeignKey(c => c.NIdCliente).WillCascadeOnDelete(false); // FK_SIR_574_CLIENTE_CARACTERISTICAS_GENERALES_cat_clientes
        }
    }

}
// </auto-generated>
