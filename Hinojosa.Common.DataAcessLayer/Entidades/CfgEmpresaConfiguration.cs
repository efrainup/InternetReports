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

    // cfg_empresa
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgEmpresaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CfgEmpresa>
    {
        public CfgEmpresaConfiguration()
            : this("dbo")
        {
        }

        public CfgEmpresaConfiguration(string schema)
        {
            ToTable("cfg_empresa", schema);
            HasKey(x => x.IdCmp);

            Property(x => x.IdCmp).HasColumnName(@"id_cmp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NoEmpresa).HasColumnName(@"No_Empresa").HasColumnType("int").IsRequired();
            Property(x => x.NombrePf).HasColumnName(@"Nombre_PF").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Calle).HasColumnName(@"Calle").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Colonia).HasColumnName(@"Colonia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Ciudad).HasColumnName(@"Ciudad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Cp).HasColumnName(@"CP").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Tel1).HasColumnName(@"Tel1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Tel2).HasColumnName(@"Tel2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Email).HasColumnName(@"email").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Url).HasColumnName(@"url").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Rfc).HasColumnName(@"rfc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Server).HasColumnName(@"server").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Db).HasColumnName(@"db").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Arch).HasColumnName(@"arch").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RazSoc).HasColumnName(@"raz_soc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.CMcp).HasColumnName(@"c_mcp").HasColumnType("tinyint").IsRequired();
            Property(x => x.TipPersona).HasColumnName(@"tip_persona").HasColumnType("tinyint").IsRequired();
            Property(x => x.Curp).HasColumnName(@"curp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(18);
            Property(x => x.Noint).HasColumnName(@"noint").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Noext).HasColumnName(@"noext").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Entrecalles).HasColumnName(@"entrecalles").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(256);
            Property(x => x.Delegacion).HasColumnName(@"delegacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fax).HasColumnName(@"fax").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Logo).HasColumnName(@"logo").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.Direccion).HasColumnName(@"Direccion").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.CRh).HasColumnName(@"c_RH").HasColumnType("tinyint").IsRequired();
            Property(x => x.CAct).HasColumnName(@"c_act").HasColumnType("tinyint").IsRequired();
            Property(x => x.Rgb).HasColumnName(@"RGB").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9);
            Property(x => x.IdCli).HasColumnName(@"id_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdProv).HasColumnName(@"id_prov").HasColumnType("int").IsRequired();
            Property(x => x.GrpMcp).HasColumnName(@"grp_mcp").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpPat).HasColumnName(@"id_emp_pat").HasColumnType("int").IsRequired();
            Property(x => x.IdEmpRep).HasColumnName(@"id_emp_rep").HasColumnType("int").IsRequired();
            Property(x => x.Cedula).HasColumnName(@"cedula").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.IdCliTabAr).HasColumnName(@"id_cli_tab_ar").HasColumnType("bigint").IsRequired();
            Property(x => x.IdTipEsq).HasColumnName(@"id_tip_esq").HasColumnType("int").IsRequired();
            Property(x => x.IdRelDa).HasColumnName(@"id_rel_da").HasColumnType("int").IsRequired();
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsRequired();
            Property(x => x.IdEdo).HasColumnName(@"id_edo").HasColumnType("int").IsRequired();
            Property(x => x.Clave).HasColumnName(@"clave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.PlanHtml).HasColumnName(@"plan_html").HasColumnType("text").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.Cert).HasColumnName(@"cert").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Licencia).HasColumnName(@"licencia").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Cals).HasColumnName(@"cals").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.LlaveCert).HasColumnName(@"llave_cert").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.DbMcp).HasColumnName(@"db_mcp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PlanCfdi).HasColumnName(@"plan_cfdi").HasColumnType("text").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.CfdExp).HasColumnName(@"cfd_exp").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.PlanAvisos).HasColumnName(@"plan_avisos").HasColumnType("text").IsRequired().IsUnicode(false).HasMaxLength(2147483647);
            Property(x => x.Exp).HasColumnName(@"exp").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.RegPat).HasColumnName(@"reg_pat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.CPagCfd).HasColumnName(@"c_pag_cfd").HasColumnType("int").IsRequired();
            Property(x => x.CDonat).HasColumnName(@"c_donat").HasColumnType("tinyint").IsRequired();
            Property(x => x.AutDonat).HasColumnName(@"aut_donat").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FecDonat).HasColumnName(@"fec_donat").HasColumnType("datetime").IsRequired();
            Property(x => x.NumEscritura).HasColumnName(@"num_escritura").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.FchEscritura).HasColumnName(@"fch_escritura").HasColumnType("datetime").IsRequired();
            Property(x => x.DatNotariales).HasColumnName(@"dat_notariales").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.NumExpCon).HasColumnName(@"num_exp_con").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdMun).HasColumnName(@"id_mun").HasColumnType("int").IsRequired();
            Property(x => x.IdLoc).HasColumnName(@"id_loc").HasColumnType("int").IsRequired();
            Property(x => x.IdCp).HasColumnName(@"id_cp").HasColumnType("int").IsRequired();
            Property(x => x.IdCol).HasColumnName(@"id_col").HasColumnType("int").IsRequired();
            Property(x => x.CConsSdo).HasColumnName(@"c_cons_sdo").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
