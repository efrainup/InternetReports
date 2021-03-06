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

    // SIR_786_HISTORICO_CONVERTIDOR_UNIDADES_PARTIDA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir786HistoricoConvertidorUnidadesPartidaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir786HistoricoConvertidorUnidadesPartida>
    {
        public SIR_Sir786HistoricoConvertidorUnidadesPartidaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir786HistoricoConvertidorUnidadesPartidaConfiguration(string schema)
        {
            ToTable("SIR_786_HISTORICO_CONVERTIDOR_UNIDADES_PARTIDA", schema);
            HasKey(x => x.NIdHistorico786);

            Property(x => x.NIdHistorico786).HasColumnName(@"nIdHistorico786").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdUMedFact785).HasColumnName(@"nIdUMedFact785").HasColumnType("int").IsOptional();
            Property(x => x.NCantidadUmf).HasColumnName(@"nCantidadUMF").HasColumnType("decimal").IsOptional().HasPrecision(15,3);
            Property(x => x.NIdFacturaPartida11).HasColumnName(@"nIdFacturaPartida11").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
