using System;
using System.Collections.Generic;
using System.Text;

namespace DNC_DI.shared.Models
{
    public class Item : ModelBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
