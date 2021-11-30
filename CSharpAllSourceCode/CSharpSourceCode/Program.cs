using System;

namespace CSharpSourceCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Products[10];

            var aBook = new Book();
            aBook.Name = "C# programming";
            aBook.Description = "Something";
            aBook.Price = 125;
            aBook.Author = "M. Steve";

            var anElectronics = new Electronics();
            anElectronics.Name = "Camera";
            anElectronics.Description = "Smart DSLR";
            anElectronics.Price = 50000.3456;
            anElectronics.BrandName = "Cannon";

            products[0] = aBook;
            products[1] = anElectronics;

            Print(aBook);
            Print(anElectronics);
        }

        static void Print(Products product)
        {
            Console.WriteLine($"Name = {product.Name}");
            Console.WriteLine($"Description = {product.Description}");
            Console.WriteLine($"Price = {product.FormatPrice()}");
            Console.WriteLine($"Discount = {product.CalculateDiscount()}");

            if (product is Book)
            {
                var book = product as Book;
                Console.WriteLine($"Author = {book.Author}");
            }
            else if (product is Electronics)
            {
                var electronics = product as Electronics;
                Console.WriteLine($"BranName = {electronics.BrandName}");
            }
        }
    }
    
}
