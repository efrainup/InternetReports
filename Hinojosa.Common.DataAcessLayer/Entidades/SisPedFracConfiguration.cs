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

    // sis_ped_frac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedFracConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisPedFrac>
    {
        public SisPedFracConfiguration()
            : this("dbo")
        {
        }

        public SisPedFracConfiguration(string schema)
        {
            ToTable("sis_ped_frac", schema);
            HasKey(x => x.IdPedFrac);

            Property(x => x.IdPedFrac).HasColumnName(@"id_ped_frac").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdPed).HasColumnName(@"id_ped").HasColumnType("int").IsRequired();
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.PrePag).HasColumnName(@"pre_pag").HasColumnType("float").IsRequired();
            Property(x => x.ValorAdu).HasColumnName(@"valor_adu").HasColumnType("float").IsRequired();
            Property(x => x.ValorDolares).HasColumnName(@"valor_dolares").HasColumnType("float").IsRequired();
            Property(x => x.CantUmc).HasColumnName(@"cant_umc").HasColumnType("float").IsRequired();
            Property(x => x.Umc).HasColumnName(@"umc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CantUmt).HasColumnName(@"cant_umt").HasColumnType("float").IsRequired();
            Property(x => x.Umt).HasColumnName(@"umt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Fraccion).HasColumnName(@"fraccion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
        }
    }

}
// </auto-generated>