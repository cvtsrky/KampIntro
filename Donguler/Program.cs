using System;

namespace Donguler
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            product.productName = "Monster Laptop";
            product.productPrice = 1200;
            product.productSellerName = "Monster";
            product.productDiscount = 35;

            Product product2 = new Product();
            product2.productName = "Lenovo Laptop";
            product2.productPrice = 1500;
            product2.productSellerName = "Lenovo";
            product2.productDiscount = 45;

            Product product3 = new Product();
            product3.productName = "Hp Laptop";
            product3.productPrice = 1350;
            product3.productSellerName = "Hp";
            product3.productDiscount = 25;

            Product[] products = new Product[] { product, product2, product3 };
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün adı: " + products[i].productName + "  Ürün fiyatı: " + products[i].productPrice + "  Ürün satıcısı: " + products[i].productSellerName + "  Ürün indirimi: " + products[i].productDiscount);
            }

        }
    }

    class Product
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productSellerName { get; set; }
        public double productDiscount { get; set; }

    }
}
