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

    // cat_tra_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTraDocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatTraDoc>
    {
        public CatTraDocConfiguration()
            : this("dbo")
        {
        }

        public CatTraDocConfiguration(string schema)
        {
            ToTable("cat_tra_doc", schema);
            HasKey(x => x.IdTraDoc);

            Property(x => x.IdTraDoc).HasColumnName(@"id_tra_doc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdRec).HasColumnName(@"id_rec").HasColumnType("int").IsRequired();
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired();
            Property(x => x.IdTipDocumento).HasColumnName(@"id_tip_documento").HasColumnType("int").IsRequired();
            Property(x => x.IdCliFaDa).HasColumnName(@"id_cli_fa_da").HasColumnType("int").IsRequired();
            Property(x => x.IdPro).HasColumnName(@"id_pro").HasColumnType("int").IsRequired();
            Property(x => x.FecExp).HasColumnName(@"fec_exp").HasColumnType("date").IsRequired();
            Property(x => x.FecVen).HasColumnName(@"fec_ven").HasColumnType("date").IsRequired();
            Property(x => x.Folio).HasColumnName(@"folio").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.IdPeriodicidad).HasColumnName(@"id_periodicidad").HasColumnType("int").IsRequired();
            Property(x => x.Monto).HasColumnName(@"monto").HasColumnType("float").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Dias).HasColumnName(@"dias").HasColumnType("int").IsRequired();
            Property(x => x.Comentario).HasColumnName(@"comentario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.IdPais).HasColumnName(@"id_pais").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("int").IsRequired();
            Property(x => x.Mantenimiento).HasColumnName(@"mantenimiento").HasColumnType("float").IsRequired();
            Property(x => x.CArrendamiento).HasColumnName(@"c_arrendamiento").HasColumnType("bit").IsRequired();
            Property(x => x.CAplicaCosteo).HasColumnName(@"c_aplica_costeo").HasColumnType("bit").IsRequired();
            Property(x => x.IdUdm).HasColumnName(@"id_udm").HasColumnType("int").IsRequired();
            Property(x => x.Cantidad).HasColumnName(@"cantidad").HasColumnType("int").IsRequired();
            Property(x => x.Precio).HasColumnName(@"precio").HasColumnType("float").IsRequired();
            Property(x => x.CAplicaAnticipo).HasColumnName(@"c_aplica_anticipo").HasColumnType("bit").IsRequired();
            Property(x => x.CDoctoAdj).HasColumnName(@"c_docto_adj").HasColumnType("bit").IsRequired();
            Property(x => x.IdImpto).HasColumnName(@"id_impto").HasColumnType("int").IsRequired();
            Property(x => x.Impuesto).HasColumnName(@"impuesto").HasColumnType("float").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.CInterno).HasColumnName(@"c_interno").HasColumnType("bit").IsRequired();
            Property(x => x.TipCli).HasColumnName(@"tip_cli").HasColumnType("int").IsOptional();
            Property(x => x.IdVehiculo).HasColumnName(@"id_Vehiculo").HasColumnType("int").IsOptional();
            Property(x => x.TipoCalculo).HasColumnName(@"tipo_calculo").HasColumnType("int").IsOptional();
            Property(x => x.IdCliPro).HasColumnName(@"id_cli_pro").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
