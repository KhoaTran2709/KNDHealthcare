namespace KND_HEALTHCARE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BIENBANHUYTHUOCs = new HashSet<BIENBANHUYTHUOC>();
            PHIEUDATMUAs = new HashSet<PHIEUDATMUA>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(100)]
        public string TENNV { get; set; }

        public bool? GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(11)]
        public string SDTNV { get; set; }

        [StringLength(15)]
        public string CHUCVU { get; set; }

        [StringLength(200)]
        public string HINHNV { get; set; }

        [StringLength(64)]
        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENBANHUYTHUOC> BIENBANHUYTHUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATMUA> PHIEUDATMUAs { get; set; }
    }
}
