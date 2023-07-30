using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add member
            Member member = new Member();
            member.Name = "Ali";
            member.Email = "IeaMyr.ir@Gmail.com";
            member.AddMember(member);

            // Add Product 
            Product product = new Product();
            product.Name = "A52";
            product.Quantity = 10;
            product.AddProduct(product);

            // Add Cart 
            Cart cart = new Cart();
            cart.DateCreated = DateTime.Now;
            cart.ProductName = product.Name;
            cart.Quantity = 1;
            cart.MemberEmail = member.Email;
            cart.AddToCart(cart);
        }
    }
}
