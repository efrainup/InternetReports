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

    // SIR_563_SELLOS_EQUIPO_EDESPACHO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir563SellosEquipoEdespachoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir563SellosEquipoEdespacho>
    {
        public SIR_Sir563SellosEquipoEdespachoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir563SellosEquipoEdespachoConfiguration(string schema)
        {
            ToTable("SIR_563_SELLOS_EQUIPO_EDESPACHO", schema);
            HasKey(x => x.NIdSellosEquipoEDespacho563);

            Property(x => x.NIdSellosEquipoEDespacho563).HasColumnName(@"nIdSellosEquipoEDespacho563").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNumEquipoEDespacho562).HasColumnName(@"nIdNumEquipoEDespacho562").HasColumnType("int").IsRequired();
            Property(x => x.SSello).HasColumnName(@"sSello").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(36);

            // Foreign keys
            HasRequired(a => a.SIR_Sir562NumEquipoEdespacho).WithMany(b => b.SIR_Sir563SellosEquipoEdespacho).HasForeignKey(c => c.NIdNumEquipoEDespacho562).WillCascadeOnDelete(false); // FK_SIR_563_SELLOS_EQUIPO_EDESPACHO_SIR_562_NUM_EQUIPO_EDESPACHO
        }
    }

}
// </auto-generated>
