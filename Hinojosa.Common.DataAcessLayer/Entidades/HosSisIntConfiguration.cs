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

    // hos_sis_int
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HosSisIntConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HosSisInt>
    {
        public HosSisIntConfiguration()
            : this("dbo")
        {
        }

        public HosSisIntConfiguration(string schema)
        {
            ToTable("hos_sis_int", schema);
            HasKey(x => x.IdInt);

            Property(x => x.IdInt).HasColumnName(@"id_int").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdRef).HasColumnName(@"id_ref").HasColumnType("int").IsRequired();
            Property(x => x.IdAut).HasColumnName(@"id_aut").HasColumnType("int").IsRequired();
            Property(x => x.IdFacPac).HasColumnName(@"id_fac_pac").HasColumnType("int").IsRequired();
            Property(x => x.IdFacEmp).HasColumnName(@"id_fac_emp").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.MontoMax).HasColumnName(@"monto_max").HasColumnType("float").IsRequired();
            Property(x => x.Deducible).HasColumnName(@"deducible").HasColumnType("float").IsRequired();
            Property(x => x.Coaseguro).HasColumnName(@"coaseguro").HasColumnType("float").IsRequired();
            Property(x => x.MontoCgm).HasColumnName(@"monto_cgm").HasColumnType("float").IsRequired();
            Property(x => x.ImptosCgm).HasColumnName(@"imptos_cgm").HasColumnType("float").IsRequired();
            Property(x => x.TotalCgm).HasColumnName(@"total_cgm").HasColumnType("float").IsRequired();
            Property(x => x.TopeAut).HasColumnName(@"tope_aut").HasColumnType("float").IsRequired();
            Property(x => x.TopeCpt).HasColumnName(@"tope_cpt").HasColumnType("float").IsRequired();
            Property(x => x.DedMonto).HasColumnName(@"ded_monto").HasColumnType("float").IsRequired();
            Property(x => x.DedImpto).HasColumnName(@"ded_impto").HasColumnType("float").IsRequired();
            Property(x => x.DedTotal).HasColumnName(@"ded_total").HasColumnType("float").IsRequired();
            Property(x => x.CoaMonto).HasColumnName(@"coa_monto").HasColumnType("float").IsRequired();
            Property(x => x.CoaImpto).HasColumnName(@"coa_impto").HasColumnType("float").IsRequired();
            Property(x => x.CoaTotal).HasColumnName(@"coa_total").HasColumnType("float").IsRequired();
            Property(x => x.PacCptMonto).HasColumnName(@"pac_cpt_monto").HasColumnType("float").IsRequired();
            Property(x => x.PacCptImpto).HasColumnName(@"pac_cpt_impto").HasColumnType("float").IsRequired();
            Property(x => x.PacCptTotal).HasColumnName(@"pac_cpt_total").HasColumnType("float").IsRequired();
            Property(x => x.EmpCptMonto).HasColumnName(@"emp_cpt_monto").HasColumnType("float").IsRequired();
            Property(x => x.EmpCptImpto).HasColumnName(@"emp_cpt_impto").HasColumnType("float").IsRequired();
            Property(x => x.EmpCptTotal).HasColumnName(@"emp_cpt_total").HasColumnType("float").IsRequired();
            Property(x => x.PacMonto).HasColumnName(@"pac_monto").HasColumnType("float").IsRequired();
            Property(x => x.PacImpto).HasColumnName(@"pac_impto").HasColumnType("float").IsRequired();
            Property(x => x.PacTotal).HasColumnName(@"pac_total").HasColumnType("float").IsRequired();
            Property(x => x.EmpMonto).HasColumnName(@"emp_monto").HasColumnType("float").IsRequired();
            Property(x => x.EmpImpto).HasColumnName(@"emp_impto").HasColumnType("float").IsRequired();
            Property(x => x.EmpTotal).HasColumnName(@"emp_total").HasColumnType("float").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.FecMod).HasColumnName(@"fec_mod").HasColumnType("datetime").IsRequired();
            Property(x => x.IdSucSol).HasColumnName(@"id_suc_sol").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>