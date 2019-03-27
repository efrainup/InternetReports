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

    // ctb_asi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbAsiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CtbAsi>
    {
        public CtbAsiConfiguration()
            : this("dbo")
        {
        }

        public CtbAsiConfiguration(string schema)
        {
            ToTable("ctb_asi", schema);
            HasKey(x => x.IdAsiDet);

            Property(x => x.IdAsiDet).HasColumnName(@"id_asi_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdAsi).HasColumnName(@"id_asi").HasColumnType("int").IsRequired();
            Property(x => x.NumAsi).HasColumnName(@"num_asi").HasColumnType("int").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NoPart).HasColumnName(@"no_part").HasColumnType("int").IsRequired();
            Property(x => x.CarAbo).HasColumnName(@"car_abo").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipObj).HasColumnName(@"id_tip_obj").HasColumnType("int").IsRequired();
            Property(x => x.IdTipRub).HasColumnName(@"id_tip_rub").HasColumnType("int").IsRequired();
            Property(x => x.IdCampo).HasColumnName(@"id_campo").HasColumnType("int").IsRequired();
            Property(x => x.Orden).HasColumnName(@"orden").HasColumnType("int").IsRequired();
            Property(x => x.Bloque).HasColumnName(@"bloque").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
