using System;
using System.Collections.Generic;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            string selectFlower;
            Flowerstore flowerStore = new Flowerstore();
            Console.WriteLine("Select number to buy a flower " + flowerStore.flowerList[0] + flowerStore.flowerList[1]);
            
        }
    }
    class Flowerstore
    {
        public List<string> flowerList = new List<string>();
        List<string>cart = new List<string>();

        public Flowerstore() {
            flowerList.Add("Rose");

            flowerList.Add("Lotus");
        }
         public void addToCarl(string name)
        {
            cart.Add(name);
        }
         public void ShowCart()
        {
            if(cart.Count == 0)
            {
                Console.WriteLine("Cart is emtry");
            }
            else
            {
                Console.WriteLine("My Cart : ");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }
            
    }
}
