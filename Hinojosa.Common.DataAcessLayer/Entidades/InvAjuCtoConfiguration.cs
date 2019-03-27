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

    // inv_aju_cto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvAjuCtoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvAjuCto>
    {
        public InvAjuCtoConfiguration()
            : this("dbo")
        {
        }

        public InvAjuCtoConfiguration(string schema)
        {
            ToTable("inv_aju_cto", schema);
            HasKey(x => x.IdAjuCto);

            Property(x => x.IdAjuCto).HasColumnName(@"id_aju_cto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(25);
            Property(x => x.AjuTot).HasColumnName(@"aju_tot").HasColumnType("float").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdPol).HasColumnName(@"id_pol").HasColumnType("int").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCtaVar).HasColumnName(@"id_cta_var").HasColumnType("int").IsRequired();
            Property(x => x.IdPerIni).HasColumnName(@"id_per_ini").HasColumnType("int").IsRequired();
            Property(x => x.IdPerFin).HasColumnName(@"id_per_fin").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
