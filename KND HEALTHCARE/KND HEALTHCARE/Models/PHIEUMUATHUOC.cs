namespace KND_HEALTHCARE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUMUATHUOC")]
    public partial class PHIEUMUATHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUMUATHUOC()
        {
            CHITIETPHIEUMUATHUOCs = new HashSet<CHITIETPHIEUMUATHUOC>();
        }

        [Key]
        public int SOPHIEUMUA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYMUA { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [StringLength(11)]
        public string SDTKHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUMUATHUOC> CHITIETPHIEUMUATHUOCs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
