using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaClaroDom.Model.Models
{
    public class Prices
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Descount { get; set; }
        public string color { get; set; }
        public bool IsDefaultProduct { get; set; }
    }
}
