using System;
using System.Collections.Generic;
using System.Text;

namespace DNC_DI.shared.Models
{
    public class Order : ModelBase
    {
        public DateTime CreateDate { get; set; }
        public string OrderNumber { get; set; }
        public List<Item> Items { get; set; }
    }
}
