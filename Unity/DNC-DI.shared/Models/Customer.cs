using System;
using System.Collections.Generic;
using System.Text;

namespace DNC_DI.shared.Models
{
    public class Customer : ModelBase
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}
