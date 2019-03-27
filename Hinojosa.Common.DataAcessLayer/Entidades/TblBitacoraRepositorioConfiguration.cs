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

    // tbl_bitacora_repositorio
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblBitacoraRepositorioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblBitacoraRepositorio>
    {
        public TblBitacoraRepositorioConfiguration()
            : this("dbo")
        {
        }

        public TblBitacoraRepositorioConfiguration(string schema)
        {
            ToTable("tbl_bitacora_repositorio", schema);
            HasKey(x => x.IdBitArchEsc);

            Property(x => x.IdBitArchEsc).HasColumnName(@"id_bit_arch_esc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdUsrReg).HasColumnName(@"id_usr_reg").HasColumnType("int").IsOptional();
            Property(x => x.NombreArchivo).HasColumnName(@"nombre_archivo").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsOptional();
            Property(x => x.IdRepoEsc).HasColumnName(@"id_repo_esc").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
