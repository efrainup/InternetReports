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

    // SIR_812_DODA_CONTENEDORES_CANDADO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir812DodaContenedoresCandadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir812DodaContenedoresCandado>
    {
        public SIR_Sir812DodaContenedoresCandadoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir812DodaContenedoresCandadoConfiguration(string schema)
        {
            ToTable("SIR_812_DODA_CONTENEDORES_CANDADO", schema);
            HasKey(x => new { x.NIdDodaCont811, x.SCandado });

            Property(x => x.NIdDodaCont811).HasColumnName(@"nIdDODACont811").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdSello107).HasColumnName(@"nIdSello107").HasColumnType("int").IsOptional();
            Property(x => x.SCandado).HasColumnName(@"sCandado").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasOptional(a => a.SIR_Sir107ContenedorSello).WithMany(b => b.SIR_Sir812DodaContenedoresCandado).HasForeignKey(c => c.NIdSello107).WillCascadeOnDelete(false); // FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_107_CONTENEDOR_SELLOS
            HasRequired(a => a.SIR_Sir811DodaContenedore).WithMany(b => b.SIR_Sir812DodaContenedoresCandado).HasForeignKey(c => c.NIdDodaCont811).WillCascadeOnDelete(false); // FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_811_DODA_CONTENEDORES
        }
    }

}
// </auto-generated>
