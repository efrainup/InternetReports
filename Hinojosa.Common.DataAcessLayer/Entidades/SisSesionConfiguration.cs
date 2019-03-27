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

    // sis_sesion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisSesionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisSesion>
    {
        public SisSesionConfiguration()
            : this("dbo")
        {
        }

        public SisSesionConfiguration(string schema)
        {
            ToTable("sis_sesion", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.CmpVer).HasColumnName(@"cmp_ver").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.FecAct).HasColumnName(@"fec_act").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.NomEquipo).HasColumnName(@"nom_equipo").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(50);
            Property(x => x.Ip).HasColumnName(@"ip").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(15);
            Property(x => x.PartAbi).HasColumnName(@"part_abi").HasColumnType("int").IsRequired();
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired();
            Property(x => x.Crpst).HasColumnName(@"crpst").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>