using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Product> initialProducts = new List<Product>
        {
            new Product { Name = "Папір", Quantity = 100 },
            new Product { Name = "Олівець", Quantity = 50 },
        };

        initialProducts.Add(new Product { Name = "Ручка", Quantity = 80 });

        foreach (var product in initialProducts)
        {
            product.Price = GetPriceFromDatabase(product.Name);
        }

        initialProducts.Sort((x, y) => y.Quantity.CompareTo(x.Quantity));
        initialProducts.Sort((x, y) => x.Name.CompareTo(y.Name));

        foreach (var product in initialProducts)
        {
            product.Category = GetCategoryFromDatabase(product.Name);
        }

        foreach (var product in initialProducts)
        {
            Console.WriteLine($"Назва: {product.Name}, Кількість: {product.Quantity}, Ціна: {product.Price}, Категорія: {product.Category}");
        }

        string categoryToSearch = "Канцелярські товари";
        var productsInCategory = initialProducts.FindAll(product => product.Category == categoryToSearch);
        Console.WriteLine($"Товари у категорії '{categoryToSearch}':");
        foreach (var product in productsInCategory)
        {
            Console.WriteLine($"Назва: {product.Name}, Кількість: {product.Quantity}, Ціна: {product.Price}");
        }
    }

    static decimal GetPriceFromDatabase(string productName)
    {
        return 10.0m;
    }

    static string GetCategoryFromDatabase(string productName)
    {
        return "Канцелярські товари";
    }

    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
