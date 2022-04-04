namespace KND_HEALTHCARE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDATMUA")]
    public partial class PHIEUDATMUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATMUA()
        {
            CHITIETPHIEUDATMUAs = new HashSet<CHITIETPHIEUDATMUA>();
            CHITIETPHIEUDATMUAs1 = new HashSet<CHITIETPHIEUDATMUA>();
        }

        [Key]
        public int SOPHIEUDAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYMUA { get; set; }

        [Column(TypeName = "money")]
        public decimal? THANHTIEN { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        public int? MANCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUDATMUA> CHITIETPHIEUDATMUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUDATMUA> CHITIETPHIEUDATMUAs1 { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
