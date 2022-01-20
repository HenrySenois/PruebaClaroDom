using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaClaroDom.Model.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpiredDate { get; set; }
        public virtual ICollection<Prices> Prices { get; set; }
    
    }
}
