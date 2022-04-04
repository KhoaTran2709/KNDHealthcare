namespace KND_HEALTHCARE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOC")]
    public partial class THUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOC()
        {
            CHITIETBIENBANs = new HashSet<CHITIETBIENBAN>();
            CHITIETPHIEUDATMUAs = new HashSet<CHITIETPHIEUDATMUA>();
            CHITIETPHIEUMUATHUOCs = new HashSet<CHITIETPHIEUMUATHUOC>();
        }

        [Key]
        public int MATHUOC { get; set; }

        [StringLength(100)]
        public string TENTHUOC { get; set; }

        [StringLength(20)]
        public string DVT { get; set; }

        public int? DONGIA { get; set; }

        public int? SOLUONGTON { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSANXUAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HANSUDUNG { get; set; }

        [StringLength(200)]
        public string HINHTHUOC { get; set; }

        [StringLength(500)]
        public string MOTA { get; set; }

        public int? MALOAITHUOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBIENBAN> CHITIETBIENBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUDATMUA> CHITIETPHIEUDATMUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUMUATHUOC> CHITIETPHIEUMUATHUOCs { get; set; }

        public virtual LOAITHUOC LOAITHUOC { get; set; }
    }
}
