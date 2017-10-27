using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Otlob.Models
{
    public class Pharamacy
    {
        public int Id { get; set; }
        public string Name_ar { get; set; }
        public string Name_en { get; set; }
        public int state_id { get; set; }
        public string Address_ar { get; set; }
        public string Address_en { get; set; }
        public string Telephone { get; set; }
    }
}