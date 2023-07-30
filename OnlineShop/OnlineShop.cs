using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class OnlineShop
    {
        List<Product> Products;
        List<Member> Members;
        List<Cart> Carts;

        public OnlineShop()
        {
          Products = new List<Product>();    
            Members = new List<Member>();   
                Carts = new List<Cart>();   
        } 

        // For Product
        public void DisplayProducts()
        {
            Console.WriteLine("Product : ");
        }
        public void AddProduct(Product product)
        {
            Console.WriteLine("Product Add successfully ");
        }
        public void RemoveProduct(Product product)
        {
            Console.WriteLine("Product Remove successfully ");
        }
        // For Member
        public void AddMember(Member member)
        {
            Console.WriteLine("Product Add successfully ");
        }
        // For Shopping Cart
        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart : ");
        }
        public void AddToCart(Cart cart)
        {
            Console.WriteLine("The product has been successfully Add from the shopping cart.");
        }
        public void RemoveToCart(Cart cart)
        {
            Console.WriteLine("The product has been successfully removed from the shopping cart.");
        }
    }
}
