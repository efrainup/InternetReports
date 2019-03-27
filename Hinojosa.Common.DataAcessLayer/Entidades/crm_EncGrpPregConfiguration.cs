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

    // enc_grp_preg
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_EncGrpPregConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<crm_EncGrpPreg>
    {
        public crm_EncGrpPregConfiguration()
            : this("crm")
        {
        }

        public crm_EncGrpPregConfiguration(string schema)
        {
            ToTable("enc_grp_preg", schema);
            HasKey(x => x.IdGrpPreg);

            Property(x => x.IdGrpPreg).HasColumnName(@"id_grp_preg").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.InstrGrp).HasColumnName(@"instr_grp").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.IdTipGrp).HasColumnName(@"id_tip_grp").HasColumnType("int").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>