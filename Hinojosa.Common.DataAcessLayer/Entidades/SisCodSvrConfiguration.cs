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

    // sis_cod_svr
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisCodSvrConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisCodSvr>
    {
        public SisCodSvrConfiguration()
            : this("dbo")
        {
        }

        public SisCodSvrConfiguration(string schema)
        {
            ToTable("sis_cod_svr", schema);
            HasKey(x => x.IdCodSvr);

            Property(x => x.IdCodSvr).HasColumnName(@"id_cod_svr").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdRelClas).HasColumnName(@"id_rel_clas").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.FecAlta).HasColumnName(@"fec_alta").HasColumnType("datetime").IsRequired();
            Property(x => x.FecUltMov).HasColumnName(@"fec_ult_mov").HasColumnType("datetime").IsRequired();
            Property(x => x.IdRelCar).HasColumnName(@"id_rel_car").HasColumnType("int").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.Presup).HasColumnName(@"presup").HasColumnType("float").IsRequired();
            Property(x => x.IdClas1).HasColumnName(@"id_clas1").HasColumnType("int").IsRequired();
            Property(x => x.Codigo).HasColumnName(@"codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
