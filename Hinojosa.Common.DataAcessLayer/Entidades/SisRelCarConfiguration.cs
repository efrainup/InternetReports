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

    // sis_rel_car
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelCarConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRelCar>
    {
        public SisRelCarConfiguration()
            : this("dbo")
        {
        }

        public SisRelCarConfiguration(string schema)
        {
            ToTable("sis_rel_car", schema);
            HasKey(x => new { x.Id, x.IdCar, x.IdTip, x.IdRelCar });

            Property(x => x.IdRelCar).HasColumnName(@"id_rel_car").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCar).HasColumnName(@"id_car").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.Valor1).HasColumnName(@"valor1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(513);
            Property(x => x.Valor2).HasColumnName(@"Valor2").HasColumnType("int").IsRequired();
            Property(x => x.Valor3).HasColumnName(@"Valor3").HasColumnType("float").IsRequired();
            Property(x => x.Valor4).HasColumnName(@"Valor4").HasColumnType("float").IsRequired();
            Property(x => x.Valor5).HasColumnName(@"Valor5").HasColumnType("datetime").IsRequired();
            Property(x => x.Valor6).HasColumnName(@"Valor6").HasColumnType("bit").IsRequired();
            Property(x => x.Valor7).HasColumnName(@"Valor7").HasColumnType("text").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.IdTip).HasColumnName(@"id_tip").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdSisRelCarTip).HasColumnName(@"id_sis_rel_car_tip").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
