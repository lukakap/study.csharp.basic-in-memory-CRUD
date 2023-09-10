using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUDOperations;

public class Operations
{
    private int _id = 0;
    private List<Product> _products = new List<Product>();

    public Operations() {
        
    }

    public bool Add()
    {
        Console.WriteLine("Insert Product Information: ");
        Console.Write("Name - ");
        var name = Console.ReadLine();
        if (name is null) 
        {
            Console.WriteLine("Invalid Value for Name!");
            return false;
        }

        double price;
        Console.Write("Price - ");
        if (!double.TryParse(Console.ReadLine(), out price))
        {
            Console.WriteLine("Invalid Value for Price!");
            return false;
        }

        _products.Add(new Product (_id.ToString(), name, price ));
        _id++;

        return true;
    }

    public void Delete()
    {
        Console.Write("Id of product you want to delete: ");
        var id = Console.ReadLine();
        if (id == null) { return; }

        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
            Console.WriteLine($"DELETED PRODUCT: {product.ToString()}");
        }
    }

    public void Update()
    {
        Console.Write("Id of product you want to update: ");
        var id = Console.ReadLine();
        if (id == null) { return; }

        var product = _products.FirstOrDefault(p =>p.Id == id);
        if (product != null)
        {
            Console.WriteLine("type new values of each field. if you don't want to change just press enter");

            Console.Write("Name - ");
            var name = Console.ReadLine();

            Console.Write("Price - ");
            double price;
            var priceString = Console.ReadLine();

            if (!string.IsNullOrEmpty(priceString))
            {
                if (double.TryParse(priceString, out price))
                {
                    product.Price = price;
                }
            }
            else if (!string.IsNullOrEmpty(name))
            {
                product.Name = name;
            }
        }
    }

    public void Read()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void Search()
    {
        Console.Write("Name of the product you want to search: ");
        var name = Console.ReadLine();

        if (!string.IsNullOrEmpty(name)) 
        { 
            var searchedProduct = (from product in _products
                                      where product.Name == name
                                      select product).FirstOrDefault();
            if (searchedProduct != null)
            {
                Console.WriteLine($"Found Product : {searchedProduct} ");
            }
            else
            { 
                Console.WriteLine("Product Can not be found ");
            }
        }
    }

}

