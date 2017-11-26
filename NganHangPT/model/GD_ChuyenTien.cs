namespace NganHangPT.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GD_ChuyenTien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAGD { get; set; }

        [Required]
        [StringLength(9)]
        public string SOTK_CHUYEN { get; set; }

        public DateTime NGAYGD { get; set; }

        [Column(TypeName = "money")]
        public decimal SOTIEN { get; set; }

        [Required]
        [StringLength(9)]
        public string SOTK_NHAN { get; set; }

        [StringLength(9)]
        public string MANV { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
