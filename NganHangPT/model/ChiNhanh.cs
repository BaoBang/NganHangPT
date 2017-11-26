namespace NganHangPT.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiNhanh")]
    public partial class ChiNhanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiNhanh()
        {
            KhachHangs = new List<KhachHang>();
            TaiKhoans = new List<TaiKhoan>();
        }

        [Key]
        [StringLength(10)]
        public string MACN { get; set; }

        [Required]
        [StringLength(100)]
        public string TENCN { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(12)]
        public string SODT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
