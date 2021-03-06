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

    // SIR_469_DIVISIONES_SUCPATADU
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir469DivisionesSucpataduConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir469DivisionesSucpatadu>
    {
        public SIR_Sir469DivisionesSucpataduConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir469DivisionesSucpataduConfiguration(string schema)
        {
            ToTable("SIR_469_DIVISIONES_SUCPATADU", schema);
            HasKey(x => x.NIdSucPatAdu71);

            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SDivision).HasColumnName(@"sDivision").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithOptional(b => b.SIR_Sir469DivisionesSucpatadu).WillCascadeOnDelete(false); // FK_SIR_468_ENUM_CLAVE_DOCTOS_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>
