using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Models
{
    public class OderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
       

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
