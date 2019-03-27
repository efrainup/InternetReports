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

    // tbl_log_contr
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblLogContrConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblLogContr>
    {
        public TblLogContrConfiguration()
            : this("dbo")
        {
        }

        public TblLogContrConfiguration(string schema)
        {
            ToTable("tbl_log_contr", schema);
            HasKey(x => x.IdLogContr);

            Property(x => x.IdLogContr).HasColumnName(@"id_log_contr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdUsuario1G).HasColumnName(@"id_usuario_1g").HasColumnType("int").IsRequired();
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsRequired();
            Property(x => x.IdVersion).HasColumnName(@"id_version").HasColumnType("int").IsRequired();
            Property(x => x.Version).HasColumnName(@"version").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired();
            Property(x => x.NomEquipo).HasColumnName(@"nom_equipo").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Ip).HasColumnName(@"ip").HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(x => x.IdTipEvt).HasColumnName(@"id_tip_evt").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCliTabAr).HasColumnName(@"id_cli_tab_ar").HasColumnType("int").IsRequired();
            Property(x => x.Servidor).HasColumnName(@"servidor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Basedatos).HasColumnName(@"basedatos").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
