namespace KND_HEALTHCARE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETBIENBAN")]
    public partial class CHITIETBIENBAN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MABB { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATHUOC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYHUY { get; set; }

        public int? SOLUONGHUY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HSD { get; set; }

        public virtual BIENBANHUYTHUOC BIENBANHUYTHUOC { get; set; }

        public virtual THUOC THUOC { get; set; }
    }
}
