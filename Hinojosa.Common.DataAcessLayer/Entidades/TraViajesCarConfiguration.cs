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

    // tra_viajes_car
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TraViajesCarConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TraViajesCar>
    {
        public TraViajesCarConfiguration()
            : this("dbo")
        {
        }

        public TraViajesCarConfiguration(string schema)
        {
            ToTable("tra_viajes_car", schema);
            HasKey(x => x.IdViajeCar);

            Property(x => x.IdViajeCar).HasColumnName(@"id_viaje_car").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdViaje).HasColumnName(@"id_viaje").HasColumnType("int").IsRequired();
            Property(x => x.NoEntrega).HasColumnName(@"no_entrega").HasColumnType("int").IsRequired();
            Property(x => x.NoPart).HasColumnName(@"no_part").HasColumnType("int").IsRequired();
            Property(x => x.TipOpe).HasColumnName(@"tip_ope").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdCarga).HasColumnName(@"id_carga").HasColumnType("int").IsRequired();
            Property(x => x.IdTipMercancia).HasColumnName(@"id_tip_mercancia").HasColumnType("int").IsRequired();
            Property(x => x.Mercancia).HasColumnName(@"mercancia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.IdTipClas).HasColumnName(@"id_tip_clas").HasColumnType("int").IsRequired();
            Property(x => x.IdTipContenedor).HasColumnName(@"id_tip_contenedor").HasColumnType("int").IsRequired();
            Property(x => x.Contenedor).HasColumnName(@"contenedor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Sello).HasColumnName(@"sello").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.IdTipEmpaque).HasColumnName(@"id_tip_empaque").HasColumnType("int").IsRequired();
            Property(x => x.Poliza).HasColumnName(@"poliza").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Aa).HasColumnName(@"aa").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Patente).HasColumnName(@"patente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Aduana).HasColumnName(@"aduana").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Seccion).HasColumnName(@"seccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Pedimento).HasColumnName(@"pedimento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Booking).HasColumnName(@"booking").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.FecAa).HasColumnName(@"fec_aa").HasColumnType("datetime").IsRequired();
            Property(x => x.Buque).HasColumnName(@"buque").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Referencia).HasColumnName(@"referencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Volumen).HasColumnName(@"volumen").HasColumnType("float").IsRequired();
            Property(x => x.Peso).HasColumnName(@"peso").HasColumnType("float").IsRequired();
            Property(x => x.Valor).HasColumnName(@"valor").HasColumnType("float").IsRequired();
            Property(x => x.CantPorte).HasColumnName(@"cant_porte").HasColumnType("float").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.DesPro).HasColumnName(@"des_pro").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(160);
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("int").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.PrecioBse).HasColumnName(@"precio_bse").HasColumnType("float").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("float").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDoc).HasColumnName(@"id_doc").HasColumnType("int").IsRequired();
            Property(x => x.IdDocDet).HasColumnName(@"id_doc_det").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>