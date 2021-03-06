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

    // vta_mov_caj
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaMovCajConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VtaMovCaj>
    {
        public VtaMovCajConfiguration()
            : this("dbo")
        {
        }

        public VtaMovCajConfiguration(string schema)
        {
            ToTable("vta_mov_caj", schema);
            HasKey(x => x.IdMov);

            Property(x => x.IdMov).HasColumnName(@"id_mov").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCaja).HasColumnName(@"id_caja").HasColumnType("int").IsRequired();
            Property(x => x.IdCorte).HasColumnName(@"id_corte").HasColumnType("int").IsRequired();
            Property(x => x.IdTipoDoc).HasColumnName(@"id_tipo_doc").HasColumnType("int").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdAplicaDoc).HasColumnName(@"id_aplica_doc").HasColumnType("int").IsRequired();
            Property(x => x.Cargo).HasColumnName(@"cargo").HasColumnType("float").IsRequired();
            Property(x => x.Abono).HasColumnName(@"abono").HasColumnType("float").IsRequired();
            Property(x => x.Saldo).HasColumnName(@"saldo").HasColumnType("float").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.IdSuc).HasColumnName(@"id_suc").HasColumnType("int").IsRequired();
            Property(x => x.IdCierre).HasColumnName(@"id_cierre").HasColumnType("int").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.@Ref).HasColumnName(@"ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.NumDocCli).HasColumnName(@"num_doc_cli").HasColumnType("int").IsRequired();
            Property(x => x.IdBcoAux).HasColumnName(@"id_bco_aux").HasColumnType("int").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCpt).HasColumnName(@"id_cpt").HasColumnType("int").IsRequired();
            Property(x => x.IdTipTrn).HasColumnName(@"id_tip_trn").HasColumnType("int").IsRequired();
            Property(x => x.IdSisCnl).HasColumnName(@"id_sis_cnl").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.CatCaja).WithMany(b => b.VtaMovCajs).HasForeignKey(c => c.IdCaja).WillCascadeOnDelete(false); // FK_vta_mov_caj_cat_cajas
            HasRequired(a => a.CatUsr).WithMany(b => b.VtaMovCajs).HasForeignKey(c => c.IdUsr).WillCascadeOnDelete(false); // FK_vta_mov_caj_cat_usr
        }
    }

}
// </auto-generated>
