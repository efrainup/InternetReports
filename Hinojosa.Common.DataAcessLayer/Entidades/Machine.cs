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

    // Machines
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Machine
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Machine alias")]
        public string MachineAlias { get; set; } // MachineAlias (length: 20)

        [Required]
        [Display(Name = "Connect type")]
        public int ConnectType { get; set; } // ConnectType

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Ip")]
        public string Ip { get; set; } // IP (length: 20)

        [Display(Name = "Serial port")]
        public int? SerialPort { get; set; } // SerialPort

        [Display(Name = "Port")]
        public int? Port { get; set; } // Port

        [Display(Name = "Baudrate")]
        public int? Baudrate { get; set; } // Baudrate

        [Required]
        [Display(Name = "Machine number")]
        public int MachineNumber { get; set; } // MachineNumber

        [Display(Name = "Is host")]
        public bool? IsHost { get; set; } // IsHost

        [Display(Name = "Enabled")]
        public bool? Enabled { get; set; } // Enabled

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Comm password")]
        public string CommPassword { get; set; } // CommPassword (length: 12)

        [Display(Name = "Uil anguage")]
        public short? UiLanguage { get; set; } // UILanguage

        [Display(Name = "Date format")]
        public short? DateFormat { get; set; } // DateFormat

        [Display(Name = "In out record warn")]
        public short? InOutRecordWarn { get; set; } // InOutRecordWarn

        [Display(Name = "Idle")]
        public short? Idle { get; set; } // Idle

        [Display(Name = "Voice")]
        public short? Voice { get; set; } // Voice

        [Display(Name = "Managercount")]
        public short? Managercount { get; set; } // managercount

        [Display(Name = "Usercount")]
        public short? Usercount { get; set; } // usercount

        [Display(Name = "Fingercount")]
        public short? Fingercount { get; set; } // fingercount

        [Display(Name = "Secret count")]
        public short? SecretCount { get; set; } // SecretCount

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Firmware version")]
        public string FirmwareVersion { get; set; } // FirmwareVersion (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Product type")]
        public string ProductType { get; set; } // ProductType (length: 20)

        [Display(Name = "Lock control")]
        public short? LockControl { get; set; } // LockControl

        [Display(Name = "Purpose")]
        public short? Purpose { get; set; } // Purpose

        [Display(Name = "Produce kind")]
        public int? ProduceKind { get; set; } // ProduceKind

        [MaxLength(16)]
        [StringLength(16)]
        [Display(Name = "Device netmask")]
        public string DeviceNetmask { get; set; } // DeviceNetmask (length: 16)

        [MaxLength(16)]
        [StringLength(16)]
        [Display(Name = "Device getway")]
        public string DeviceGetway { get; set; } // DeviceGetway (length: 16)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Sn")]
        public string Sn { get; set; } // sn (length: 40)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Photo stamp")]
        public string PhotoStamp { get; set; } // PhotoStamp (length: 20)

        [Display(Name = "Is if change config server 2")]
        public int? IsIfChangeConfigServer2 { get; set; } // IsIfChangeConfigServer2

        [Required]
        [Display(Name = "C usa nom")]
        public byte CUsaNom { get; set; } // c_usa_nom

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Url]
        [Display(Name = "Url")]
        public string Url { get; set; } // url (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Short name")]
        public string ShortName { get; set; } // shortName (length: 5)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Last update date")]
        public System.DateTime LastUpdateDate { get; set; } // lastUpdateDate

        public Machine()
        {
            SerialPort = 1;
            Port = 1;
            MachineNumber = 1;
            UiLanguage = -1;
            DateFormat = -1;
            InOutRecordWarn = -1;
            Idle = -1;
            Voice = -1;
            Managercount = -1;
            Usercount = -1;
            Fingercount = -1;
            SecretCount = -1;
            LockControl = -1;
            Purpose = 1;
            ProduceKind = 1;
            IsIfChangeConfigServer2 = 0;
            CUsaNom = 0;
            Url = "";
            ShortName = "";
        }
    }

}
// </auto-generated>