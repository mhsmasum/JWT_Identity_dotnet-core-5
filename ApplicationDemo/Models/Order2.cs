using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Models
{
    public class Order2
    {
       [Key]
        public int Id { get; set; }

        public virtual ICollection<OrderItem2> OrderItems2 { get; set; }
    }
}
