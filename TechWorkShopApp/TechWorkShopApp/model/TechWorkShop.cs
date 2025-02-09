using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeckWorkShopAPIApp.model
{
    [Table("TechWorkShop")]
    public class TechWorkShop
    {
        [Key]
        public int workShopId { get; set; }

       
        [StringLength(50)]
        public string workShopName { get; set; }

       
        public DateTime date { get; set; }

        public decimal price { get; set; }

        
        public int trainerId { get; set; }


    }
}
