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

    // sis_ped_identificadores
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedIdentificadoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisPedIdentificadore>
    {
        public SisPedIdentificadoreConfiguration()
            : this("dbo")
        {
        }

        public SisPedIdentificadoreConfiguration(string schema)
        {
            ToTable("sis_ped_identificadores", schema);
            HasKey(x => new { x.IdPedIdentificador, x.IdPedimento });

            Property(x => x.IdPedIdentificador).HasColumnName(@"id_ped_identificador").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPed).HasColumnName(@"id_ped").HasColumnType("int").IsOptional();
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Complemento1).HasColumnName(@"complemento1").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Complemento2).HasColumnName(@"complemento2").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Complemento3).HasColumnName(@"complemento3").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsOptional();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsOptional();
            Property(x => x.IdPedimento).HasColumnName(@"id_pedimento").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
