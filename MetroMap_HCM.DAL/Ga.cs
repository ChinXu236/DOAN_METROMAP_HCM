using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMap_HCM.DAL
{
    [Table("Ga")]
    public partial class Ga
    {
        public Ga()
        {
            LichTrinhs = new HashSet<LichTrinh>();
            LienKetAsGa1 = new HashSet<LienKet>();
            LienKetAsGa2 = new HashSet<LienKet>();
        }

        [Key]
        [StringLength(10)]
        public string MaGa { get; set; }

        [StringLength(100)]
        public string TenGa { get; set; }

        [StringLength(10)]
        public string MaTuyen { get; set; }

        public int? ThuTu { get; set; }

        [ForeignKey(nameof(MaTuyen))]
        public virtual Tuyen Tuyen { get; set; }

        public virtual ICollection<LichTrinh> LichTrinhs { get; set; }

        // ✅ 2 hướng liên kết đến bảng LienKet
        [InverseProperty(nameof(LienKet.Ga1))]
        public virtual ICollection<LienKet> LienKetAsGa1 { get; set; }

        [InverseProperty(nameof(LienKet.Ga2))]
        public virtual ICollection<LienKet> LienKetAsGa2 { get; set; }
    }
}
