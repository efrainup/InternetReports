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

    // SIR_13_HISTORIAL_PARIDAD
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir13HistorialParidadConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir13HistorialParidad>
    {
        public SIR_Sir13HistorialParidadConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir13HistorialParidadConfiguration(string schema)
        {
            ToTable("SIR_13_HISTORIAL_PARIDAD", schema);
            HasKey(x => x.NIdHistoParidad13);

            Property(x => x.NIdHistoParidad13).HasColumnName(@"nIdHistoParidad13").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPais01).HasColumnName(@"nIdPais01").HasColumnType("int").IsRequired();
            Property(x => x.DFechaFactor).HasColumnName(@"dFechaFactor").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NValorFactor).HasColumnName(@"nValorFactor").HasColumnType("decimal").IsOptional().HasPrecision(10,9);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir13HistorialParidad).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_13_HISTORIAL_PARIDAD_cat_usr_ed
            HasRequired(a => a.SIR_Sir01Pais).WithMany(b => b.SIR_Sir13HistorialParidad).HasForeignKey(c => c.NIdPais01).WillCascadeOnDelete(false); // FK_SIR_13_HISTORIAL_PARIDAD_SIR_01_PAISES
        }
    }

}
// </auto-generated>
