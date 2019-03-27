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

    // The table 'usuario_mabe_remesas_detalle' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // usuario_mabe_remesas_detalle
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class UsuarioMabeRemesasDetalle
    {
        [Display(Name = "Trafico")]
        public string Trafico { get; set; } // trafico

        [Display(Name = "Peso")]
        public decimal? Peso { get; set; } // peso

        [Display(Name = "Num parte")]
        public string NumParte { get; set; } // Num_Parte

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Factura")]
        public string Factura { get; set; } // factura (length: 45)

        [Display(Name = "Valor factura")]
        public decimal? ValorFactura { get; set; } // valor_factura

        [Display(Name = "Cantidad")]
        public decimal? Cantidad { get; set; } // cantidad

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Unidad medida")]
        public string UnidadMedida { get; set; } // unidad_medida (length: 45)

        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; } // observaciones

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Orden compra")]
        public string OrdenCompra { get; set; } // orden_compra (length: 45)

        [Display(Name = "Notas")]
        public string Notas { get; set; } // notas

        [Display(Name = "Permisos")]
        public string Permisos { get; set; } // permisos

        [Display(Name = "Impuestos especiales")]
        public string ImpuestosEspeciales { get; set; } // impuestos_especiales

        [Display(Name = "Tasa igi")]
        public decimal? TasaIgi { get; set; } // tasa_igi

        [Display(Name = "Tasa usa mex")]
        public decimal? TasaUsaMex { get; set; } // tasa_usa_mex

        [Display(Name = "Tasa can")]
        public decimal? TasaCan { get; set; } // tasa_can

        [Display(Name = "Fraccion")]
        public string Fraccion { get; set; } // fraccion

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion

        [Display(Name = "Cc producto")]
        public string CcProducto { get; set; } // cc_producto

        [Display(Name = "Cc pais")]
        public string CcPais { get; set; } // cc_pais

        [Display(Name = "Cc empresa")]
        public string CcEmpresa { get; set; } // cc_empresa

        [Display(Name = "Cc cuota")]
        public string CcCuota { get; set; } // cc_cuota

        [Display(Name = "Cc po")]
        public string CcPo { get; set; } // cc_po

        [Display(Name = "Erycia co")]
        public string EryciaCo { get; set; } // erycia_co

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Erycia num control")]
        public string EryciaNumControl { get; set; } // erycia_num_control (length: 45)

        [Display(Name = "Pais origen activo")]
        public string PaisOrigenActivo { get; set; } // pais_origen_activo

        [Display(Name = "Pais origen mercancia")]
        public string PaisOrigenMercancia { get; set; } // pais_origen_mercancia

        [Display(Name = "Pais procedencia")]
        public string PaisProcedencia { get; set; } // pais_procedencia

        [Display(Name = "Planta")]
        public string Planta { get; set; } // planta

        [Display(Name = "Tipo discrepancia")]
        public string TipoDiscrepancia { get; set; } // tipo_discrepancia

        [Display(Name = "Cantidad discrepancia")]
        public int? CantidadDiscrepancia { get; set; } // cantidad_discrepancia

        [Display(Name = "Observacion discrepancia")]
        public string ObservacionDiscrepancia { get; set; } // observacion_discrepancia

        [Display(Name = "Observa 1")]
        public string Observa1 { get; set; } // observa1

        [Display(Name = "Observa 2")]
        public string Observa2 { get; set; } // observa2

        [Display(Name = "Observa 3")]
        public string Observa3 { get; set; } // observa3

        [Display(Name = "Dias almacen")]
        public int? DiasAlmacen { get; set; } // dias_almacen

        [Display(Name = "Caja directa")]
        public string CajaDirecta { get; set; } // caja_directa

        [Display(Name = "Caja arribo")]
        public string CajaArribo { get; set; } // caja_arribo

        [Display(Name = "Id")]
        public int? Id { get; set; } // id

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Procesado")]
        public string Procesado { get; set; } // procesado (length: 10)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec proced")]
        public System.DateTime? FecProced { get; set; } // fec_proced

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; } // referencia (length: 20)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec factura")]
        public System.DateTime? FecFactura { get; set; } // fec_factura

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Incoterm")]
        public string Incoterm { get; set; } // incoterm (length: 20)

        [Display(Name = "Cove")]
        public string Cove { get; set; } // cove

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Moneda")]
        public string Moneda { get; set; } // moneda (length: 5)
    }

}
// </auto-generated>
