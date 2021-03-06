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

    // cat_almac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatAlmacConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatAlmac>
    {
        public CatAlmacConfiguration()
            : this("dbo")
        {
        }

        public CatAlmacConfiguration(string schema)
        {
            ToTable("cat_almac", schema);
            HasKey(x => x.IdAlmac);

            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.CConsignacion).HasColumnName(@"c_consignacion").HasColumnType("tinyint").IsRequired();
            Property(x => x.Tip).HasColumnName(@"tip").HasColumnType("tinyint").IsRequired();
            Property(x => x.Codigo).HasColumnName(@"codigo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdOtrSis).HasColumnName(@"id_otr_sis").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.CCtbInv).HasColumnName(@"c_ctb_inv").HasColumnType("int").IsRequired();
            Property(x => x.Resp).HasColumnName(@"resp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdZon).HasColumnName(@"id_zon").HasColumnType("int").IsRequired();
            Property(x => x.Tel1).HasColumnName(@"tel1").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Calle).HasColumnName(@"calle").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Noext).HasColumnName(@"noext").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Noint).HasColumnName(@"noint").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.EntreCalles).HasColumnName(@"entre_calles").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Col).HasColumnName(@"col").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Del).HasColumnName(@"del").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ciudad).HasColumnName(@"ciudad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Cp).HasColumnName(@"cp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsRequired();
            Property(x => x.IdEdo).HasColumnName(@"id_edo").HasColumnType("int").IsRequired();
            Property(x => x.CTran).HasColumnName(@"c_tran").HasColumnType("tinyint").IsRequired();
            Property(x => x.CVta).HasColumnName(@"c_vta").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdAlmEnv).HasColumnName(@"id_alm_env").HasColumnType("int").IsRequired();
            Property(x => x.CConsigProv).HasColumnName(@"c_consig_prov").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Contacto).HasColumnName(@"contacto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Email).HasColumnName(@"email").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.CMrp).HasColumnName(@"c_mrp").HasColumnType("tinyint").IsRequired();
            Property(x => x.FchAlta).HasColumnName(@"fch_alta").HasColumnType("datetime").IsRequired();
            Property(x => x.FchUltMod).HasColumnName(@"fch_ult_mod").HasColumnType("datetime").IsRequired();
            HasMany(t => t.SIR_Sir71SucursalPatenteAduana).WithMany(t => t.CatAlmacs).Map(m =>
            {
                m.ToTable("SIR_117_ALMACENES_SUCPATADU", "SIR");
                m.MapLeftKey("nIdAlmacen");
                m.MapRightKey("nIdSucPatAdu71");
            });
        }
    }

}
// </auto-generated>
