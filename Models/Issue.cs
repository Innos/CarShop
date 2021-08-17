using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Issue
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Description { get; set; }

        [Required]
        public bool IsFixed { get; set; }

        [ForeignKey("Car")]
        public string CarId { get; set; }

        public Car Car { get; set; }
    }
}
