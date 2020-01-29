using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PtixiakiReservations.Models.ViewModels
{
    public class ShopViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public int thesis { get; set; }
        public double rating { get; set; }
        public string TimeOpen { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public IFormFile Photo { get; set; }
    }
}
