using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlNabaa_Store.Models
{
    public class ProductsModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Company { get; set; }
        [Required]

        public string GraphicCard { get; set; }
        [Required]

        public string RAM { get; set; }
        [Required]

        public string CPU { get; set; }
        [Required]

        public string HARD { get; set; }
        [Required]

        public string Type { get; set; }
        [Required]

        public decimal Price { get; set; }
    }

}
