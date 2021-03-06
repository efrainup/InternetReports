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

    // SIR_562_NUM_EQUIPO_EDESPACHO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir562NumEquipoEdespachoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir562NumEquipoEdespacho>
    {
        public SIR_Sir562NumEquipoEdespachoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir562NumEquipoEdespachoConfiguration(string schema)
        {
            ToTable("SIR_562_NUM_EQUIPO_EDESPACHO", schema);
            HasKey(x => x.NIdNumEquipoEDespacho562);

            Property(x => x.NIdNumEquipoEDespacho562).HasColumnName(@"nIdNumEquipoEDespacho562").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdBlsEDespacho561).HasColumnName(@"nIdBlsEDespacho561").HasColumnType("int").IsRequired();
            Property(x => x.SInialesEquipo).HasColumnName(@"sInialesEquipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SNumEquipo).HasColumnName(@"sNumEquipo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);

            // Foreign keys
            HasRequired(a => a.SIR_Sir561BlsEdespacho).WithMany(b => b.SIR_Sir562NumEquipoEdespacho).HasForeignKey(c => c.NIdBlsEDespacho561).WillCascadeOnDelete(false); // FK_SIR_562_NUM_EQUIPO_EDESPACHO_SIR_561_BLS_EDESPACHO
        }
    }

}
// </auto-generated>
