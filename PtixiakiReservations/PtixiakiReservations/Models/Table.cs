using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PtixiakiReservations.Models
{
    public class Table
    {
        public int ID { get; set; }

        public decimal x { get; set; }
        public decimal y { get; set; }
        public int people { get; set; }      
        public string Name { get; set; }

        public bool Available { get; set; }
        public int shopID { get; set; }
        [ForeignKey("shopID")]
        public Shops shop { get; set; }

    }
}
