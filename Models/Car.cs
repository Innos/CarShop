using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Car
    {
        //By default "Id" is going to be picked as primary key, this is just an alternate way
        [Key]
        public string Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int PictureUrl { get; set; }


        [Required]
        [RegularExpression("[A-Z]{2}[0-9]{4}[A-Z]{2}", ErrorMessage = "Must be a valid Plate number")]
        public string PlateNumber { get; set; }

        [ForeignKey("Owner")]
        public string OwnerId { get; set; }

        public User Owner { get; set; }
    }
}
