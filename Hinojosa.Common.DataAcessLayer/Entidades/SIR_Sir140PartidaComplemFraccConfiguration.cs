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

    // SIR_140_PARTIDA_COMPLEM_FRACC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir140PartidaComplemFraccConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir140PartidaComplemFracc>
    {
        public SIR_Sir140PartidaComplemFraccConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir140PartidaComplemFraccConfiguration(string schema)
        {
            ToTable("SIR_140_PARTIDA_COMPLEM_FRACC", schema);
            HasKey(x => x.NIdComplFracc140);

            Property(x => x.NIdComplFracc140).HasColumnName(@"nIdComplFracc140").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NSubdivision).HasColumnName(@"nSubdivision").HasColumnType("smallint").IsOptional();
            Property(x => x.SCodigoProd).HasColumnName(@"sCodigoProd").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SMarcaProd).HasColumnName(@"sMarcaProd").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SModeloProd).HasColumnName(@"sModeloProd").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(80);
            Property(x => x.SObservacion).HasColumnName(@"sObservacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(120);
            Property(x => x.NValorMciaNoOrig).HasColumnName(@"nValorMciaNoOrig").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NMontoIgiMcia).HasColumnName(@"nMontoIGIMcia").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NIdMoneda03).HasColumnName(@"nIdMoneda03").HasColumnType("int").IsOptional();
            Property(x => x.NTotalEuacan).HasColumnName(@"nTotalEUACAN").HasColumnType("decimal").IsOptional().HasPrecision(12,2);
            Property(x => x.NMontoExento).HasColumnName(@"nMontoExento").HasColumnType("decimal").IsOptional().HasPrecision(12,3);
            Property(x => x.NPruebaSuficiente).HasColumnName(@"nPruebaSuficiente").HasColumnType("tinyint").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();

            // Foreign keys
            HasOptional(a => a.SIR_Sir03Moneda).WithMany(b => b.SIR_Sir140PartidaComplemFracc).HasForeignKey(c => c.NIdMoneda03).WillCascadeOnDelete(false); // FK_SIR_140_PARTIDA_COMPLEM_FRACC_SIR_03_MONEDAS
            HasRequired(a => a.CatUsr).WithMany(b => b.SIR_Sir140PartidaComplemFracc).HasForeignKey(c => c.NIdUsuarioEd).WillCascadeOnDelete(false); // FK_SIR_140_PARTIDA_COMPLEM_FRACC_cat_usr_ed
        }
    }

}
// </auto-generated>
