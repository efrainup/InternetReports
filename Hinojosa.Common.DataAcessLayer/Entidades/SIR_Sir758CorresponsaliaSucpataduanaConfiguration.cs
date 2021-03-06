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

    // SIR_758_CORRESPONSALIA_SUCPATADUANA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir758CorresponsaliaSucpataduanaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir758CorresponsaliaSucpataduana>
    {
        public SIR_Sir758CorresponsaliaSucpataduanaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir758CorresponsaliaSucpataduanaConfiguration(string schema)
        {
            ToTable("SIR_758_CORRESPONSALIA_SUCPATADUANA", schema);
            HasKey(x => x.NIdCorrespSucPatAdu758);

            Property(x => x.NIdCorrespSucPatAdu758).HasColumnName(@"nIdCorrespSucPatAdu758").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClaveCorresponsalia).HasColumnName(@"sClaveCorresponsalia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SCorresponsalia).HasColumnName(@"sCorresponsalia").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired();
            Property(x => x.SRutaDeposito).HasColumnName(@"sRutaDeposito").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);

            // Foreign keys
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithOptional(b => b.SIR_Sir758CorresponsaliaSucpataduana).WillCascadeOnDelete(false); // FK_SIR_758_CORRESPONSALIA_SUCPATADUANA_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>
