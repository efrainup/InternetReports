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

    // tmp_ctb_acu_cli
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TmpCtbAcuCliConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TmpCtbAcuCli>
    {
        public TmpCtbAcuCliConfiguration()
            : this("dbo")
        {
        }

        public TmpCtbAcuCliConfiguration(string schema)
        {
            ToTable("tmp_ctb_acu_cli", schema);
            HasKey(x => new { x.IdPer, x.IdCta, x.IdEmp, x.IdCli });

            Property(x => x.IdPer).HasColumnName(@"id_per").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCta).HasColumnName(@"id_cta").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdEmp).HasColumnName(@"id_emp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SalIni).HasColumnName(@"sal_ini").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Cargos).HasColumnName(@"cargos").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Abonos).HasColumnName(@"abonos").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.CamNet).HasColumnName(@"cam_net").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.SalFin).HasColumnName(@"sal_fin").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>
