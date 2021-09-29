using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> product = new MyDictionary<string,int>();

            product.Add("Laptop", 1500);
            product.Add("Mouse", 500);
            product.Add("Keyboard", 750);


           
           
        }
    }
}
