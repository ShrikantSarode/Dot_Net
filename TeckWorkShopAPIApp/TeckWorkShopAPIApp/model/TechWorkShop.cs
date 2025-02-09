using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeckWorkShopAPIApp.model
{
    [Table("TechWorkShop")]
    public class TechWorkShop
    {
        [Key]
        public int workShopId { get; set; }

        [Required]
        [StringLength(50)]
        public string workShopName { get; set; }

        [Required]
        public DateTime date { get; set; }

        [Required]
        public decimal price { get; set; }

        [Required]
        public int trainerId { get; set; }


    }
}
