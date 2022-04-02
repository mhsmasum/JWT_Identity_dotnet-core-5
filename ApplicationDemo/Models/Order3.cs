using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Models
{
    public class Order3
    {
        [Key]
        public int Id { get; set; }
   
        public decimal OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
       

       
        public ICollection<Order3Detail> OrderDetails { get; set; }
    }
}
