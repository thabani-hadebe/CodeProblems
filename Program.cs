using System;
using System.Collections.Generic;
using static CodeProblems.ProductModel;

namespace CodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Smart POS: please enter the product details. Press Q when you are done: ");
            try
            {
                List<ProductModel> Products = new List<ProductModel>();
                var Escape = ' ';
                while (Escape != 'Q')
                {
                    Console.WriteLine("Please enter the product name: ");
                    var ItemName = Console.ReadLine();
                    if (ItemName.ToUpper() == "Q")
                    {
                        Escape = 'Q';
                        Console.WriteLine("Done");
                        return;
                    }

                    Console.WriteLine("Please enter the product price:");
                    var ItemPrice = Console.ReadLine();
                    if (ItemPrice.ToUpper() == "Q")
                    {
                        Escape = 'Q';
                        Console.WriteLine("Done");
                        return;
                    }

                    Console.WriteLine("Please enter the product quanity:");
                    var ItemQuantity = Console.ReadLine();
                    if (ItemQuantity.ToUpper() == "Q")
                    {
                        Escape = 'Q';
                        Console.WriteLine("Done");
                        return;
                    }
                    Console.WriteLine("Please enter the product Type:");
                    //books, food, and medical products
                    Console.WriteLine("1 - Books");
                    Console.WriteLine("2 - Food");
                    Console.WriteLine("3 - Medical Products");
                    Console.WriteLine("4 - Other");
                    var Type = Console.ReadLine();
                    if (Type.ToUpper() == "Q")
                    {
           
                        Escape = 'Q';
                        Console.WriteLine("Done");
                        return;
                    }

                    Console.WriteLine("Are you sure you want to add more items to the basket?");
                    Console.WriteLine("1- Yes");
                    Console.WriteLine("2- No");
                    var Done = Console.ReadLine();
                    if (Done  == "1")
                    {
                        switch (Type)
                        {
                            case "1":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.BOOK,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;
                            case "2":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.FOOD,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;
                            case "3":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.MEDICAL_PRODUCT,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;
                            case "4":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.OTHER,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;

                            default:
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.OTHER,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;

                        }
                    }
                    else
                    {
                        switch (Type)
                        {
                            case "1":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.BOOK,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;
                            case "2":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.FOOD,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;
                            case "3":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.MEDICAL_PRODUCT,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;
                            case "4":
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.OTHER,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;

                            default:
                                Products.Add(new ProductModel
                                {
                                    Quantity = int.Parse(ItemQuantity),
                                    ItemName = ItemName,
                                    ItemType = ProductType.OTHER,
                                    Price = int.Parse(ItemPrice)
                                });
                                break;

                        }
                        Console.WriteLine("");
                        foreach (ProductModel Item in Products)
                        {
                            Console.WriteLine(Item.Quantity + " " + Item.ItemName + " " + Item.Price);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Sales Tax: "+ CalculateSalesTax(Products));
                        Console.WriteLine("Total Amount: "+ CalculateTotal(Products));
                        return;
                    }
                    

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured when capturing the items. Please try again");
            }
        }

        private static double CalculateSalesTax(IList<ProductModel> Products)
        {
            var totalTax = 0.0;
            foreach (ProductModel Item in Products)
            {
                if (Item.ItemType == ProductType.OTHER) {
                    totalTax += (Item.Price * Item.Quantity) * 0.1;
                }
            }
            return totalTax;
        }
        private static double CalculateTotal(IList<ProductModel> Products)
        {
            var total = 0.0;
            foreach (ProductModel Item in Products)
            {
                total += (Item.Price * Item.Quantity);
            }
            return total;
        }
    }
}
