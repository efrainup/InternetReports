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

    // GT_Procesos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class GtProcesoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GtProceso>
    {
        public GtProcesoConfiguration()
            : this("dbo")
        {
        }

        public GtProcesoConfiguration(string schema)
        {
            ToTable("GT_Procesos", schema);
            HasKey(x => x.NIdProcesoGt);

            Property(x => x.NIdProcesoGt).HasColumnName(@"nIdProcesoGT").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SReferencia).HasColumnName(@"sReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("int").IsRequired();
            Property(x => x.NIdCliente).HasColumnName(@"nIdCliente").HasColumnType("int").IsRequired();
            Property(x => x.SCodProceso).HasColumnName(@"sCodProceso").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SNumProceso).HasColumnName(@"sNumProceso").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BActivo).HasColumnName(@"bActivo").HasColumnType("bit").IsRequired();
            Property(x => x.DFechaAlta).HasColumnName(@"dFechaAlta").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
