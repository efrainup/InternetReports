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

    // tra_viajes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TraViajeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TraViaje>
    {
        public TraViajeConfiguration()
            : this("dbo")
        {
        }

        public TraViajeConfiguration(string schema)
        {
            ToTable("tra_viajes", schema);
            HasKey(x => x.IdViaje);

            Property(x => x.IdViaje).HasColumnName(@"id_viaje").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipDoc).HasColumnName(@"id_tip_doc").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.NumDoc).HasColumnName(@"num_doc").HasColumnType("int").IsRequired();
            Property(x => x.FecIni).HasColumnName(@"fec_ini").HasColumnType("datetime").IsRequired();
            Property(x => x.FecFin).HasColumnName(@"fec_fin").HasColumnType("datetime").IsRequired();
            Property(x => x.IdMda).HasColumnName(@"id_mda").HasColumnType("int").IsRequired();
            Property(x => x.Tc).HasColumnName(@"tc").HasColumnType("float").IsRequired();
            Property(x => x.Oper).HasColumnName(@"oper").HasColumnType("tinyint").IsRequired();
            Property(x => x.ReqEsp).HasColumnName(@"req_esp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Cant).HasColumnName(@"cant").HasColumnType("float").IsRequired();
            Property(x => x.Peso).HasColumnName(@"peso").HasColumnType("float").IsRequired();
            Property(x => x.IdRuta).HasColumnName(@"id_ruta").HasColumnType("int").IsRequired();
            Property(x => x.TipOpeProv).HasColumnName(@"TipOpeProv").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdOperador).HasColumnName(@"id_operador").HasColumnType("int").IsRequired();
            Property(x => x.Cmt).HasColumnName(@"cmt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.Valor).HasColumnName(@"valor").HasColumnType("float").IsRequired();
            Property(x => x.Importe).HasColumnName(@"importe").HasColumnType("float").IsRequired();
            Property(x => x.Imptos).HasColumnName(@"imptos").HasColumnType("float").IsRequired();
            Property(x => x.Total).HasColumnName(@"total").HasColumnType("float").IsRequired();
            Property(x => x.ImporteBse).HasColumnName(@"importe_bse").HasColumnType("float").IsRequired();
            Property(x => x.ImptosBse).HasColumnName(@"imptos_bse").HasColumnType("float").IsRequired();
            Property(x => x.TotalBse).HasColumnName(@"total_bse").HasColumnType("float").IsRequired();
            Property(x => x.CFacturado).HasColumnName(@"c_facturado").HasColumnType("tinyint").IsRequired();
            Property(x => x.CPagada).HasColumnName(@"c_pagada").HasColumnType("tinyint").IsRequired();
            Property(x => x.CLiquidado).HasColumnName(@"c_liquidado").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdNota).HasColumnName(@"id_nota").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
            Property(x => x.IdUsr).HasColumnName(@"id_usr").HasColumnType("int").IsRequired();
            Property(x => x.OpCom).HasColumnName(@"op_com").HasColumnType("tinyint").IsRequired();
            Property(x => x.PtgCom).HasColumnName(@"ptg_com").HasColumnType("float").IsRequired();
            Property(x => x.MontoCom).HasColumnName(@"monto_com").HasColumnType("float").IsRequired();
            Property(x => x.IdBcoDoc).HasColumnName(@"id_bco_doc").HasColumnType("int").IsOptional();
            Property(x => x.Expediente).HasColumnName(@"expediente").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IdVehiculo).HasColumnName(@"id_vehiculo").HasColumnType("int").IsRequired();
            Property(x => x.IdOperadorCatalogo).HasColumnName(@"id_operador_catalogo").HasColumnType("int").IsRequired();
            Property(x => x.RutaOrigen).HasColumnName(@"ruta_origen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.RutaDestino).HasColumnName(@"ruta_destino").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.RutaKilometraje).HasColumnName(@"ruta_kilometraje").HasColumnType("float").IsRequired();
            Property(x => x.RutaTiempo).HasColumnName(@"ruta_tiempo").HasColumnType("float").IsRequired();
            Property(x => x.RutaTiempoMuerto).HasColumnName(@"ruta_tiempo_muerto").HasColumnType("float").IsRequired();
            Property(x => x.RutaJsonRuta).HasColumnName(@"ruta_JSONRuta").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.StatusViaje).HasColumnName(@"status_viaje").HasColumnType("int").IsRequired();
            Property(x => x.CierreViaje).HasColumnName(@"cierre_viaje").HasColumnType("datetime").IsRequired();
            Property(x => x.TiempoReal).HasColumnName(@"tiempo_real").HasColumnType("int").IsRequired();
            Property(x => x.MontoDistancia).HasColumnName(@"monto_distancia").HasColumnType("float").IsRequired();
            Property(x => x.MontoRuta).HasColumnName(@"monto_ruta").HasColumnType("float").IsRequired();
            Property(x => x.InicioViaje).HasColumnName(@"inicio_viaje").HasColumnType("datetime").IsRequired();
            Property(x => x.IdTipViaje).HasColumnName(@"id_tip_viaje").HasColumnType("int").IsRequired();
            Property(x => x.CInterno).HasColumnName(@"c_interno").HasColumnType("bit").IsRequired();
            Property(x => x.IdOperador2).HasColumnName(@"id_operador2").HasColumnType("int").IsRequired();
            Property(x => x.IdUltimoEvento).HasColumnName(@"id_ultimo_evento").HasColumnType("int").IsRequired();
            Property(x => x.UltimoEventoFec).HasColumnName(@"ultimo_evento_fec").HasColumnType("datetime").IsRequired();
            Property(x => x.UltimoEvento).HasColumnName(@"ultimo_evento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.UltimaDireccion).HasColumnName(@"ultima_direccion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.UltimaUbicacion).HasColumnName(@"ultima_ubicacion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.UltimaActualizacion).HasColumnName(@"ultima_actualizacion").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
