namespace KND_HEALTHCARE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BIENBANHUYTHUOC")]
    public partial class BIENBANHUYTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BIENBANHUYTHUOC()
        {
            CHITIETBIENBANs = new HashSet<CHITIETBIENBAN>();
        }

        [Key]
        public int MABB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYLAPBB { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        public bool? TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBIENBAN> CHITIETBIENBANs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
