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

    // SIRA_37_NUM_REGISTROS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira37NumRegistroConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira37NumRegistro>
    {
        public SIRAdmin_Sira37NumRegistroConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira37NumRegistroConfiguration(string schema)
        {
            ToTable("SIRA_37_NUM_REGISTROS", schema);
            HasKey(x => x.NIdNumReg37);

            Property(x => x.NIdNumReg37).HasColumnName(@"nIdNumReg37").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SNumero).HasColumnName(@"sNumero").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.NTipoArchivo).HasColumnName(@"nTipoArchivo").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
