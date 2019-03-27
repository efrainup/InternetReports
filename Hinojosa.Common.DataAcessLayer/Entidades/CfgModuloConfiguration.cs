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

    // cfg_modulos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgModuloConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CfgModulo>
    {
        public CfgModuloConfiguration()
            : this("dbo")
        {
        }

        public CfgModuloConfiguration(string schema)
        {
            ToTable("cfg_modulos", schema);
            HasKey(x => x.IdMod);

            Property(x => x.IdMod).HasColumnName(@"id_mod").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NumMod).HasColumnName(@"num_mod").HasColumnType("int").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Llave).HasColumnName(@"llave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Referencia).HasColumnName(@"referencia").HasColumnType("text").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.Codigo).HasColumnName(@"codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CtlPer).HasColumnName(@"ctl_per").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdRecIni).HasColumnName(@"id_rec_ini").HasColumnType("int").IsRequired();
            Property(x => x.IdSistFk).HasColumnName(@"id_sist_fk").HasColumnType("int").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
            Property(x => x.IdModPad).HasColumnName(@"id_mod_pad").HasColumnType("int").IsRequired();
            Property(x => x.IdSol).HasColumnName(@"id_sol").HasColumnType("int").IsOptional();
            Property(x => x.CveMod).HasColumnName(@"cve_mod").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
        }
    }

}
// </auto-generated>
