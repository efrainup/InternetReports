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

    // Sis_prg_avi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPrgAviConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisPrgAvi>
    {
        public SisPrgAviConfiguration()
            : this("dbo")
        {
        }

        public SisPrgAviConfiguration(string schema)
        {
            ToTable("Sis_prg_avi", schema);
            HasKey(x => x.IdAvi);

            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"Fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.FecUltMod).HasColumnName(@"Fec_ult_mod").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"Id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdUsrMod).HasColumnName(@"Id_usr_mod").HasColumnType("int").IsRequired();
            Property(x => x.IdAvi).HasColumnName(@"Id_avi").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TipAvi).HasColumnName(@"Tip_avi").HasColumnType("int").IsRequired();
            Property(x => x.Hbl).HasColumnName(@"hbl").HasColumnType("bit").IsRequired();
            Property(x => x.PrgBasCmp).HasColumnName(@"Prg_bas_cmp").HasColumnType("bit").IsRequired();
            Property(x => x.CodAvi).HasColumnName(@"Cod_avi").HasColumnType("nvarchar").IsRequired().HasMaxLength(30);
            Property(x => x.DesAvi).HasColumnName(@"Des_avi").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.TipInt).HasColumnName(@"Tip_int").HasColumnType("int").IsRequired();
            Property(x => x.CEnv).HasColumnName(@"C_env").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.CExpira).HasColumnName(@"C_expira").HasColumnType("bit").IsRequired();
            Property(x => x.FecIni).HasColumnName(@"Fec_ini").HasColumnType("datetime").IsRequired();
            Property(x => x.FecFin).HasColumnName(@"Fec_fin").HasColumnType("datetime").IsRequired();
            Property(x => x.NoEje).HasColumnName(@"No_eje").HasColumnType("int").IsRequired();
            Property(x => x.DiaSem).HasColumnName(@"Dia_sem").HasColumnType("nvarchar").IsRequired().HasMaxLength(7);
            Property(x => x.DiaMes).HasColumnName(@"Dia_mes").HasColumnType("int").IsRequired();
            Property(x => x.Mes).HasColumnName(@"Mes").HasColumnType("int").IsRequired();
            Property(x => x.El).HasColumnName(@"El").HasColumnType("int").IsRequired();
            Property(x => x.DiaSmn).HasColumnName(@"Dia_smn").HasColumnType("int").IsRequired();
            Property(x => x.PrxEje).HasColumnName(@"Prx_eje").HasColumnType("datetime").IsRequired();
            Property(x => x.StrQuery).HasColumnName(@"Str_query").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.IdCmp).HasColumnName(@"Id_cmp").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.CmpFec).HasColumnName(@"Cmp_fec").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.IdPln).HasColumnName(@"Id_pln").HasColumnType("int").IsRequired();
            Property(x => x.IdSisAvisos).HasColumnName(@"Id_sis_avisos").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
