using System;
using System.ComponentModel.DataAnnotations;

namespace BarcodeSampleProject.Models
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Barcode_value { get; set; }


    }
}
