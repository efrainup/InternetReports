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

    // trazabilidad_doctos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TrazabilidadDocto
    {
        [Required]
        [Display(Name = "Id traz doc")]
        public int IdTrazDoc { get; set; } // id_traz_doc (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Display(Name = "Id tip doc origen")]
        public int? IdTipDocOrigen { get; set; } // id_tip_doc_origen

        [Display(Name = "Tabla origen")]
        public string TablaOrigen { get; set; } // tabla_origen

        [Display(Name = "Campo origen")]
        public string CampoOrigen { get; set; } // campo_origen

        [Display(Name = "Campos origen mostrables")]
        public string CamposOrigenMostrables { get; set; } // campos_origen_mostrables

        [Display(Name = "Id tip doc des")]
        public int? IdTipDocDes { get; set; } // id_tip_doc_des

        [Display(Name = "Tabla destino")]
        public string TablaDestino { get; set; } // tabla_destino

        [Display(Name = "Campo destino")]
        public string CampoDestino { get; set; } // campo_destino

        [Display(Name = "Campos destino mostrables")]
        public string CamposDestinoMostrables { get; set; } // campos_destino_mostrables

        [Display(Name = "Id flujo")]
        public int? IdFlujo { get; set; } // id_flujo

        [Display(Name = "Descripcion flujo")]
        public string DescripcionFlujo { get; set; } // DescripcionFlujo

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        [Display(Name = "Consultadetalleorigen")]
        public string Consultadetalleorigen { get; set; } // consultadetalleorigen

        [Display(Name = "Consultadetalledestino")]
        public string Consultadetalledestino { get; set; } // consultadetalledestino
    }

}
// </auto-generated>