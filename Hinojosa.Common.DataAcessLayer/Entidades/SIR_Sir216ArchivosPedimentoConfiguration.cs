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

    // SIR_216_ARCHIVOS_PEDIMENTO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir216ArchivosPedimentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir216ArchivosPedimento>
    {
        public SIR_Sir216ArchivosPedimentoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir216ArchivosPedimentoConfiguration(string schema)
        {
            ToTable("SIR_216_ARCHIVOS_PEDIMENTO", schema);
            HasKey(x => x.NIdArchM3216);

            Property(x => x.NIdArchM3216).HasColumnName(@"nIdArchM3216").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.SDirectorio).HasColumnName(@"sDirectorio").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsRequired();
            Property(x => x.DFechaCreacion).HasColumnName(@"dFechaCreacion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
            Property(x => x.SClaveResul828).HasColumnName(@"sClaveResul828").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir216ArchivosPedimento).HasForeignKey(c => c.NIdUsuario).WillCascadeOnDelete(false); // FK_SIR_216_ARCHIVOSM3_cat_usr
            HasMany(t => t.SIR_Sir149Pedimento).WithMany(t => t.SIR_Sir216ArchivosPedimento).Map(m =>
            {
                m.ToTable("SIR_217_PEDIMENTO_ARCHIVOM3", "SIR");
                m.MapLeftKey("nIdArchM3216");
                m.MapRightKey("nIdPedimento149");
            });
        }
    }

}
// </auto-generated>
