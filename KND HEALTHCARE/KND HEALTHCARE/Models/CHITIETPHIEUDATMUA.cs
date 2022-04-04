namespace KND_HEALTHCARE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUDATMUA")]
    public partial class CHITIETPHIEUDATMUA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATHUOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOPHIEUDAT { get; set; }

        public int? SOLUONGMUA { get; set; }

        public virtual THUOC THUOC { get; set; }

        public virtual PHIEUDATMUA PHIEUDATMUA { get; set; }

        public virtual PHIEUDATMUA PHIEUDATMUA1 { get; set; }
    }
}
