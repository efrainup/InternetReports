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

    // SIR_752_CAT_SERVICIO_NOCONFORME
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir752CatServicioNoconformeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir752CatServicioNoconforme>
    {
        public SIR_Sir752CatServicioNoconformeConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir752CatServicioNoconformeConfiguration(string schema)
        {
            ToTable("SIR_752_CAT_SERVICIO_NOCONFORME", schema);
            HasKey(x => x.NIdCatServicioNoConforme752);

            Property(x => x.NIdCatServicioNoConforme752).HasColumnName(@"nIdCatServicioNoConforme752").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("datetime").IsRequired();
            Property(x => x.NStatusVig).HasColumnName(@"nStatusVig").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
