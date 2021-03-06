namespace KND_HEALTHCARE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAITHUOC")]
    public partial class LOAITHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAITHUOC()
        {
            THUOCs = new HashSet<THUOC>();
        }

        [Key]
        public int MALOAITHUOC { get; set; }

        [StringLength(100)]
        public string TENLOAITHUOC { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        [StringLength(1)]
        public string MAKHO { get; set; }

        public virtual KHOTHUOC KHOTHUOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUOC> THUOCs { get; set; }
    }
}
