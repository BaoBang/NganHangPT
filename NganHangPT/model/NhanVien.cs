namespace NganHangPT.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            GD_ChuyenTien = new List<GD_ChuyenTien>();
            GD_GoiRut = new List<GD_GoiRut>();
        }

        [Required]
        [StringLength(50)]
        public string HOTEN { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        [Key]
        [StringLength(9)]
        public string MANV { get; set; }

        [StringLength(3)]
        public string PHAI { get; set; }

        [StringLength(12)]
        public string SODT { get; set; }

        [StringLength(10)]
        public string MACN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_ChuyenTien> GD_ChuyenTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_GoiRut> GD_GoiRut { get; set; }
    }
}
