namespace Lab5_Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(10)]
        public string  MSSV { get; set; }

        [StringLength(100)]
        public string TenSinhVien { get; set; }

        public decimal? DiemTrungBinh { get; set; }

        [StringLength(10)]
        public string MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
