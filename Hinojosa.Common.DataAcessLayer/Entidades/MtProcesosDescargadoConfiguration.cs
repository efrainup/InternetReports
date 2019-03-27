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

    // MT_ProcesosDescargados
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MtProcesosDescargadoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MtProcesosDescargado>
    {
        public MtProcesosDescargadoConfiguration()
            : this("dbo")
        {
        }

        public MtProcesosDescargadoConfiguration(string schema)
        {
            ToTable("MT_ProcesosDescargados", schema);
            HasKey(x => x.NIdDescarga);

            Property(x => x.NIdDescarga).HasColumnName(@"nIdDescarga").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SProceso).HasColumnName(@"sProceso").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NTipoOperacion).HasColumnName(@"nTipoOperacion").HasColumnType("int").IsRequired();
            Property(x => x.DFechaTwb).HasColumnName(@"dFechaTWB").HasColumnType("datetime").IsOptional();
            Property(x => x.SArchivo).HasColumnName(@"sArchivo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SDirectorio).HasColumnName(@"sDirectorio").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.SRuta).HasColumnName(@"sRuta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.DFechaRegistro).HasColumnName(@"dFechaRegistro").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaArchivo).HasColumnName(@"dFechaArchivo").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
