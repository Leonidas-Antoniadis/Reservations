using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PtixiakiReservations.Models
{
    public class Reservations
    {    
        public int ID { get; set; }
        public int people { get; set; }

        public string userId { get; set; }
        [ForeignKey("userId")]
        public ApplicationUser ApplicationUser { get; set; }
        public int shopId { get; set; }
        [ForeignKey("shopId")]
        public Shops shop { get; set; }
        public DateTime date { get; set; }
    }
}
