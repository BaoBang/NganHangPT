namespace NganHangPT.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            TaiKhoans = new List<TaiKhoan>();
        }

        [Required]
        [StringLength(50)]
        public string HOTEN { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        [Key]
        [StringLength(9)]
        public string CMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYCAP { get; set; }

        [StringLength(12)]
        public string SODT { get; set; }

        [StringLength(3)]
        public string PHAI { get; set; }

        [StringLength(10)]
        public string MACN { get; set; }

        public virtual ChiNhanh ChiNhanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
