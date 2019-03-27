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

    // SIR_301_ARCHIVOS_001
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir301Archivos001Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir301Archivos001>
    {
        public SIR_Sir301Archivos001Configuration()
            : this("SIR")
        {
        }

        public SIR_Sir301Archivos001Configuration(string schema)
        {
            ToTable("SIR_301_ARCHIVOS_001", schema);
            HasKey(x => x.NIdArchivo001);

            Property(x => x.NIdArchivo001).HasColumnName(@"nIdArchivo001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SNombreArchivo).HasColumnName(@"sNombreArchivo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.DArchivo).HasColumnName(@"dArchivo").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.NIdPatente70).HasColumnName(@"nIdPatente70").HasColumnType("int").IsOptional();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir70Patente).WithMany(b => b.SIR_Sir301Archivos001).HasForeignKey(c => c.NIdPatente70).WillCascadeOnDelete(false); // FK_SIR_301_ARCHIVOS_001_SIR_70_PATENTES
        }
    }

}
// </auto-generated>