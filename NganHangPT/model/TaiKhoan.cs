namespace NganHangPT.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(9)]
        public string SOTK { get; set; }

        [Required]
        [StringLength(9)]
        public string CMND { get; set; }

        [Column(TypeName = "money")]
        public decimal SODU { get; set; }

        [StringLength(10)]
        public string MACN { get; set; }

        public virtual ChiNhanh ChiNhanh { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
