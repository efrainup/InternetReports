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

    // sis_edos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisEdoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisEdo>
    {
        public SisEdoConfiguration()
            : this("dbo")
        {
        }

        public SisEdoConfiguration(string schema)
        {
            ToTable("sis_edos", schema);
            HasKey(x => x.IdSisEdo);

            Property(x => x.IdSisEdo).HasColumnName(@"id_sis_edo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CIni).HasColumnName(@"c_ini").HasColumnType("tinyint").IsRequired();
            Property(x => x.CFin).HasColumnName(@"c_fin").HasColumnType("tinyint").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
        }
    }

}
// </auto-generated>
