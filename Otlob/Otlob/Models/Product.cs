using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Otlob.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name_ar { get; set; }
        public string Name_en { get; set; }
        public string ActiveIngredient_ar { get; set; }
        public string ActiveIngredient_en { get; set; }
        public string Manufacturer_ar { get; set; }
        public string Manufacturer_en { get; set; }
        public string ProductType_ar { get; set; }
        public string ProductType_en { get; set; }
        public string description_en { get; set; }
        public string description_ar { get; set; }
        public string Image { get; set; }
    }
}