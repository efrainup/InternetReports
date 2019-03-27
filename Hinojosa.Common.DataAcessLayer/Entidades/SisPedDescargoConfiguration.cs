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

    // sis_ped_descargos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedDescargoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisPedDescargo>
    {
        public SisPedDescargoConfiguration()
            : this("dbo")
        {
        }

        public SisPedDescargoConfiguration(string schema)
        {
            ToTable("sis_ped_descargos", schema);
            HasKey(x => x.IdDescargo);

            Property(x => x.IdDescargo).HasColumnName(@"id_descargo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPed).HasColumnName(@"id_ped").HasColumnType("int").IsRequired();
            Property(x => x.NumPatente).HasColumnName(@"num_patente").HasColumnType("int").IsRequired();
            Property(x => x.NumDocumento).HasColumnName(@"num_documento").HasColumnType("int").IsRequired();
            Property(x => x.CveAduana).HasColumnName(@"cve_aduana").HasColumnType("int").IsRequired();
            Property(x => x.IdPedimento).HasColumnName(@"id_pedimento").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
