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

    // SIR_108_TIPOS_VEHICULOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir108TiposVehiculoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir108TiposVehiculo>
    {
        public SIR_Sir108TiposVehiculoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir108TiposVehiculoConfiguration(string schema)
        {
            ToTable("SIR_108_TIPOS_VEHICULOS", schema);
            HasKey(x => x.NIdTipVeh108);

            Property(x => x.NIdTipVeh108).HasColumnName(@"nIdTipVeh108").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir108TiposVehiculo).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_108_TIPOS_VEHICULOS_cat_usr_ed
        }
    }

}
// </auto-generated>