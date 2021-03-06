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

    // Sis_prg_avi_con
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPrgAviConConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisPrgAviCon>
    {
        public SisPrgAviConConfiguration()
            : this("dbo")
        {
        }

        public SisPrgAviConConfiguration(string schema)
        {
            ToTable("Sis_prg_avi_con", schema);
            HasKey(x => x.Descripcion);

            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SqlQuery).HasColumnName(@"Sql_query").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"Fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.FecUltMod).HasColumnName(@"Fec_ult_mod").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"Id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdUsrMod).HasColumnName(@"Id_usr_mod").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
