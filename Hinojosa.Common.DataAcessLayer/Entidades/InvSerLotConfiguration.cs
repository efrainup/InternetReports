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

    // inv_ser_lot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvSerLotConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InvSerLot>
    {
        public InvSerLotConfiguration()
            : this("dbo")
        {
        }

        public InvSerLotConfiguration(string schema)
        {
            ToTable("inv_ser_lot", schema);
            HasKey(x => x.IdSerLot);

            Property(x => x.IdSerLot).HasColumnName(@"id_ser_lot").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.IdAlmac).HasColumnName(@"id_almac").HasColumnType("int").IsRequired();
            Property(x => x.NumLot).HasColumnName(@"num_lot").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.NumSer).HasColumnName(@"num_ser").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Existencia).HasColumnName(@"existencia").HasColumnType("float").IsRequired();
            Property(x => x.Tipo).HasColumnName(@"tipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecElab).HasColumnName(@"fec_elab").HasColumnType("datetime").IsRequired();
            Property(x => x.FecCad).HasColumnName(@"fec_cad").HasColumnType("datetime").IsRequired();
            Property(x => x.IdCert).HasColumnName(@"id_cert").HasColumnType("int").IsRequired();
            Property(x => x.CPed).HasColumnName(@"c_ped").HasColumnType("tinyint").IsRequired();
            Property(x => x.NumPed).HasColumnName(@"num_ped").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Aduana).HasColumnName(@"aduana").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FechaPed).HasColumnName(@"fecha_ped").HasColumnType("datetime").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.Apartado).HasColumnName(@"apartado").HasColumnType("float").IsRequired();
            Property(x => x.Disponible).HasColumnName(@"disponible").HasColumnType("float").IsRequired();
            Property(x => x.IdMtoSerLot).HasColumnName(@"id_mto_ser_lot").HasColumnType("int").IsRequired();
            Property(x => x.NumSerFin).HasColumnName(@"num_ser_fin").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.IdPed).HasColumnName(@"id_ped").HasColumnType("int").IsRequired();
            Property(x => x.CImp).HasColumnName(@"c_imp").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nlargo).HasColumnName(@"nlargo").HasColumnType("float").IsRequired();
            Property(x => x.Nancho).HasColumnName(@"nancho").HasColumnType("float").IsRequired();
            Property(x => x.Nespesor).HasColumnName(@"nespesor").HasColumnType("float").IsRequired();
            Property(x => x.Nvolumen).HasColumnName(@"nvolumen").HasColumnType("float").IsRequired();
            Property(x => x.Narea).HasColumnName(@"narea").HasColumnType("float").IsRequired();
            Property(x => x.Npeso).HasColumnName(@"npeso").HasColumnType("float").IsRequired();
            Property(x => x.SMarca).HasColumnName(@"sMarca").HasColumnType("nvarchar").IsRequired().HasMaxLength(80);
            Property(x => x.SSerieProv).HasColumnName(@"sSerieProv").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.TipoPed).HasColumnName(@"tipo_ped").HasColumnType("tinyint").IsRequired();
            Property(x => x.CostoLote).HasColumnName(@"costo_lote").HasColumnType("float").IsRequired();
            Property(x => x.SEtiqueta).HasColumnName(@"sEtiqueta").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.SEtiqueta2).HasColumnName(@"sEtiqueta2").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.SEtiqueta3).HasColumnName(@"sEtiqueta3").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.SEtiqueta4).HasColumnName(@"sEtiqueta4").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);

            // Foreign keys
            HasRequired(a => a.CatAlmac).WithMany(b => b.InvSerLots).HasForeignKey(c => c.IdAlmac).WillCascadeOnDelete(false); // FK_inv_ser_lot_cat_almac
            HasRequired(a => a.CatPro).WithMany(b => b.InvSerLots).HasForeignKey(c => c.IdPro).WillCascadeOnDelete(false); // FK_inv_ser_lot_cat_pro
        }
    }

}
// </auto-generated>
