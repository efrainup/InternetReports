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

    // gas_cor_enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class GasCorEncConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GasCorEnc>
    {
        public GasCorEncConfiguration()
            : this("dbo")
        {
        }

        public GasCorEncConfiguration(string schema)
        {
            ToTable("gas_cor_enc", schema);
            HasKey(x => x.IdGasCorEnc);

            Property(x => x.IdGasCorEnc).HasColumnName(@"id_gas_cor_enc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdMovInv).HasColumnName(@"id_mov_inv").HasColumnType("int").IsRequired();
            Property(x => x.FechaCor).HasColumnName(@"fecha_cor").HasColumnType("datetime").IsRequired();
            Property(x => x.Codgas).HasColumnName(@"codgas").HasColumnType("int").IsRequired();
            Property(x => x.NumTurno).HasColumnName(@"num_turno").HasColumnType("int").IsRequired();
            Property(x => x.NumCorte).HasColumnName(@"num_corte").HasColumnType("int").IsRequired();
            Property(x => x.Nrotur).HasColumnName(@"nrotur").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.IdSisExt).HasColumnName(@"id_sis_ext").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
