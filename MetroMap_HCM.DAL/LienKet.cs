using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMap_HCM.DAL
{
    [Table("LienKet")]
    public partial class LienKet
    {
        [Key]
        public int ID { get; set; }

        [StringLength(10)]
        [Column("MaGa1")]
        public string MaGa1 { get; set; }

        [StringLength(10)]
        [Column("MaGa2")]
        public string MaGa2 { get; set; }

        public double? KhoangCach { get; set; } 

        [ForeignKey("MaGa1")]
        [InverseProperty("LienKetAsGa1")]
        public virtual Ga Ga1 { get; set; }

        [ForeignKey("MaGa2")]
        [InverseProperty("LienKetAsGa2")]
        public virtual Ga Ga2 { get; set; }

    }
}
