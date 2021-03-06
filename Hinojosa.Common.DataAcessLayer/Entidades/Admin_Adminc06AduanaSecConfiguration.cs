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

    // ADMINC_06_ADUANA_SEC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc06AduanaSecConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Adminc06AduanaSec>
    {
        public Admin_Adminc06AduanaSecConfiguration()
            : this("Admin")
        {
        }

        public Admin_Adminc06AduanaSecConfiguration(string schema)
        {
            ToTable("ADMINC_06_ADUANA_SEC", schema);
            HasKey(x => x.NIdAduSec06);

            Property(x => x.NIdAduSec06).HasColumnName(@"nIdAduSec06").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SClaveAduana).HasColumnName(@"sClaveAduana").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.SClaveSeccion).HasColumnName(@"sClaveSeccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.SNombreAduana).HasColumnName(@"sNombreAduana").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(220);
            Property(x => x.SNombreCorto).HasColumnName(@"sNombreCorto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BStatus).HasColumnName(@"bStatus").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
