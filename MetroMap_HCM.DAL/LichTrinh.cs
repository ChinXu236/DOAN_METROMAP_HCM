using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMap_HCM.DAL
{
    [Table("LichTrinh")]
    public partial class LichTrinh
    {
        [Key]
        public int ID { get; set; }

        [StringLength(10)]
        public string MaTuyen { get; set; }

        [StringLength(10)]
        public string MaGa { get; set; }

        public TimeSpan GioXuatPhat { get; set; }
        public int ThoiGianDenTiepTheo { get; set; }

        [ForeignKey("MaTuyen")]
        public virtual Tuyen Tuyen { get; set; }

        [ForeignKey("MaGa")]
        public virtual Ga Ga { get; set; }
    }
}
