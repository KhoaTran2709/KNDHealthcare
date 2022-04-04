namespace KND_HEALTHCARE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUMUATHUOC")]
    public partial class CHITIETPHIEUMUATHUOC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATHUOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOPHIEUMUA { get; set; }

        public int? SOLUONGMUA { get; set; }

        public int? DONGIATHUOC { get; set; }

        public virtual PHIEUMUATHUOC PHIEUMUATHUOC { get; set; }

        public virtual THUOC THUOC { get; set; }
    }
}
