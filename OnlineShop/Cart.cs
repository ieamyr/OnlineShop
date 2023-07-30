using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Cart : OnlineShop
    {
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string ProductName { get; set; }
        public virtual Product Products { get; set; }
        public string MemberEmail { get; set; }
        public virtual Member Members { get; set; }
        public Cart() { }
    }
}
