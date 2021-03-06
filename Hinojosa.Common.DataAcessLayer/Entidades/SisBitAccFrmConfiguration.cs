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

    // sis_bit_acc_frm
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitAccFrmConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisBitAccFrm>
    {
        public SisBitAccFrmConfiguration()
            : this("dbo")
        {
        }

        public SisBitAccFrmConfiguration(string schema)
        {
            ToTable("sis_bit_acc_frm", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsRequired();
            Property(x => x.Ip).HasColumnName(@"ip").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NomEqu).HasColumnName(@"nom_equ").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.IdRec).HasColumnName(@"id_rec").HasColumnType("int").IsRequired();
            Property(x => x.Frm).HasColumnName(@"frm").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
