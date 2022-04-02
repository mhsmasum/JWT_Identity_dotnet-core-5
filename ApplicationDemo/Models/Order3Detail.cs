using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Models
{
    public class Order3Detail
    {
        [Key]
        public int Id { get; set; }
        public int Order3Id { get; set; }
        public int ProductId { get; set; }
       
       
      
        public virtual Order3 Order { get; set; }
        public  Product Product { get; set; }
    }
}
