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

    // SIR_316_ARCHIVOS_KEY_AA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir316ArchivosKeyAaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir316ArchivosKeyAa>
    {
        public SIR_Sir316ArchivosKeyAaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir316ArchivosKeyAaConfiguration(string schema)
        {
            ToTable("SIR_316_ARCHIVOS_KEY_AA", schema);
            HasKey(x => new { x.NIdEmpleado, x.NIdPatente70 });

            Property(x => x.NIdEmpleado).HasColumnName(@"nIdEmpleado").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdPatente70).HasColumnName(@"nIdPatente70").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SRutaKey).HasColumnName(@"sRutaKey").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(120);
            Property(x => x.VClaveSecreta).HasColumnName(@"vClaveSecreta").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.BClaveAa).HasColumnName(@"bClaveAA").HasColumnType("bit").IsRequired();
            Property(x => x.BClaveMandatario).HasColumnName(@"bClaveMandatario").HasColumnType("bit").IsRequired();
            Property(x => x.SUsuarioCove).HasColumnName(@"sUsuarioCOVE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.VPasswordCove).HasColumnName(@"vPasswordCOVE").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.BPidePalabraSecreta).HasColumnName(@"bPidePalabraSecreta").HasColumnType("bit").IsOptional();
            Property(x => x.NTipoKeyFiel).HasColumnName(@"nTipoKeyFIEL").HasColumnType("tinyint").IsOptional();
            Property(x => x.SUsuarioDoda).HasColumnName(@"sUsuarioDODA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.VPasswordDoda).HasColumnName(@"vPasswordDODA").HasColumnType("varbinary(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatEmp).WithMany(b => b.SIR_Sir316ArchivosKeyAa).HasForeignKey(c => c.NIdEmpleado).WillCascadeOnDelete(false); // FK_SIR_316_ARCHIVOS_KEY_AA_cat_emp
            HasRequired(a => a.SIR_Sir70Patente).WithMany(b => b.SIR_Sir316ArchivosKeyAa).HasForeignKey(c => c.NIdPatente70).WillCascadeOnDelete(false); // FK_SIR_316_ARCHIVOS_KEY_AA_SIR_70_PATENTES
        }
    }

}
// </auto-generated>
