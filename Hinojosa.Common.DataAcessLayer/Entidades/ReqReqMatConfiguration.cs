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

    // req_req_mat
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ReqReqMatConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReqReqMat>
    {
        public ReqReqMatConfiguration()
            : this("dbo")
        {
        }

        public ReqReqMatConfiguration(string schema)
        {
            ToTable("req_req_mat", schema);
            HasKey(x => x.IdReqMat);

            Property(x => x.IdReqMat).HasColumnName(@"id_req_mat").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpSol).HasColumnName(@"id_emp_sol").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpDir).HasColumnName(@"id_emp_dir").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpApr).HasColumnName(@"id_emp_apr").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecDoc).HasColumnName(@"fec_doc").HasColumnType("datetime").IsRequired();
            Property(x => x.FecReq).HasColumnName(@"fec_req").HasColumnType("datetime").IsRequired();
            Property(x => x.FecApr).HasColumnName(@"fec_apr").HasColumnType("datetime").IsRequired();
            Property(x => x.Sub).HasColumnName(@"sub").HasColumnType("float").IsRequired();
            Property(x => x.Imps).HasColumnName(@"imps").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.CRec).HasColumnName(@"c_rec").HasColumnType("tinyint").IsRequired();
            Property(x => x.CLib).HasColumnName(@"c_lib").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdSesion).HasColumnName(@"id_sesion").HasColumnType("int").IsRequired();
            Property(x => x.FecRegLibCot).HasColumnName(@"fec_reg_lib_cot").HasColumnType("datetime").IsRequired();
            Property(x => x.IdEmpLibCot).HasColumnName(@"id_emp_lib_cot").HasColumnType("int").IsRequired();
            Property(x => x.FecRegLibApr).HasColumnName(@"fec_reg_lib_apr").HasColumnType("datetime").IsRequired();
            Property(x => x.IdEmpLibApr).HasColumnName(@"id_emp_lib_apr").HasColumnType("int").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
        }
    }

}
// </auto-generated>
