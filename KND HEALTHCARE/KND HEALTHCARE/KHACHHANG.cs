namespace KND_HEALTHCARE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            PHIEUMUATHUOCs = new HashSet<PHIEUMUATHUOC>();
        }

        [Key]
        [StringLength(11)]
        public string SDTKHACHHANG { get; set; }

        [StringLength(100)]
        public string TENKHACHHANG { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUATHUOC> PHIEUMUATHUOCs { get; set; }
    }
}
