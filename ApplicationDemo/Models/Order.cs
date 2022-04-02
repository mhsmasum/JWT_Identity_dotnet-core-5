using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<OderItem> OderItems { get; set; }
    }
}
