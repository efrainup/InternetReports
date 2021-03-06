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

    // The table 'cat_emp2' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // cat_emp2
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmp2
    {
        [Display(Name = "Emple numero")]
        public double? EmpleNumero { get; set; } // emple_numero

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple nombre")]
        public string EmpleNombre { get; set; } // emple_nombre (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple paterno")]
        public string EmplePaterno { get; set; } // emple_paterno (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple materno")]
        public string EmpleMaterno { get; set; } // emple_materno (length: 255)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha nacimiento")]
        public System.DateTime? FechaNacimiento { get; set; } // fecha_nacimiento

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // rfc (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Curp")]
        public string Curp { get; set; } // curp (length: 255)

        [Display(Name = "Sexo")]
        public double? Sexo { get; set; } // sexo

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Reg imss")]
        public string RegImss { get; set; } // reg_imss (length: 255)

        [DataType(DataType.DateTime)]
        [Display(Name = "Emple fingreso")]
        public System.DateTime? EmpleFingreso { get; set; } // emple_fingreso

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple calle")]
        public string EmpleCalle { get; set; } // emple_calle (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple num ext")]
        public string EmpleNumExt { get; set; } // emple_num_ext (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple num int")]
        public string EmpleNumInt { get; set; } // emple_num_int (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple colonia")]
        public string EmpleColonia { get; set; } // emple_colonia (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple municipio")]
        public string EmpleMunicipio { get; set; } // emple_municipio (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple codigo")]
        public string EmpleCodigo { get; set; } // emple_codigo (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Emple telefono")]
        public string EmpleTelefono { get; set; } // emple_telefono (length: 255)
    }

}
// </auto-generated>
