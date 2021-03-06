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

    // SIR_783_PARTES_DOS_HISTORICO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir783PartesDosHistoricoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir783PartesDosHistorico>
    {
        public SIR_Sir783PartesDosHistoricoConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir783PartesDosHistoricoConfiguration(string schema)
        {
            ToTable("SIR_783_PARTES_DOS_HISTORICO", schema);
            HasKey(x => new { x.NIdParteDos150, x.NDocumento, x.SDatosVehiculo, x.BDespachado, x.DFechaEdicion, x.NIdUsuarioEd, x.DFechaGeneracionHistorico, x.NIdUsuarioGeneraHistorico, x.NIdPedimento149, x.NTipoHistorico });

            Property(x => x.NIdParteDos150).HasColumnName(@"nIdParteDos150").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NDocumento).HasColumnName(@"nDocumento").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SDatosVehiculo).HasColumnName(@"sDatosVehiculo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(800).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SRegla233).HasColumnName(@"sRegla233").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(14);
            Property(x => x.BDespachado).HasColumnName(@"bDespachado").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFechaGeneracionHistorico).HasColumnName(@"dFechaGeneracionHistorico").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdUsuarioGeneraHistorico).HasColumnName(@"nIdUsuarioGeneraHistorico").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdPedimento149).HasColumnName(@"nIdPedimento149").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SCandadosOficiales).HasColumnName(@"sCandadosOficiales").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NIdRepLegal).HasColumnName(@"nIdRepLegal").HasColumnType("int").IsOptional();
            Property(x => x.NIdRepLegal02).HasColumnName(@"nIdRepLegal02").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsu01).HasColumnName(@"nIdUsu01").HasColumnType("int").IsOptional();
            Property(x => x.BRegla1911).HasColumnName(@"bRegla_1_9_11").HasColumnType("bit").IsOptional();
            Property(x => x.NIdBl74).HasColumnName(@"nIdBl74").HasColumnType("int").IsOptional();
            Property(x => x.NTipoHistorico).HasColumnName(@"nTipoHistorico").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
