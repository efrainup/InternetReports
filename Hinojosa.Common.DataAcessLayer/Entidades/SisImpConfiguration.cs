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

    // sis_imp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisImpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisImp>
    {
        public SisImpConfiguration()
            : this("dbo")
        {
        }

        public SisImpConfiguration(string schema)
        {
            ToTable("sis_imp", schema);
            HasKey(x => x.IdImp);

            Property(x => x.IdImp).HasColumnName(@"id_imp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.OriImp).HasColumnName(@"ori_imp").HasColumnType("nvarchar").IsRequired().HasMaxLength(30);
            Property(x => x.DesImp).HasColumnName(@"des_imp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Fmto).HasColumnName(@"fmto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Copias).HasColumnName(@"copias").HasColumnType("int").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Control).HasColumnName(@"control").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.StatusDoc).HasColumnName(@"status_doc").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdBcoAux).HasColumnName(@"id_bco_aux").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr2).HasColumnName(@"id_usr2").HasColumnType("int").IsRequired();
            Property(x => x.FecReg2).HasColumnName(@"fec_reg2").HasColumnType("datetime").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
