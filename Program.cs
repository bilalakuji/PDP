namespace PDP
{
    class Program
    {
        static List<string> products = new List<string>();
        static void Main()
        {
            while (true)
            {
                DisplayScreen();
                int userDecision;
                if (!int.TryParse(Console.ReadLine(), out userDecision))
                {
                    Console.WriteLine("\nInvalid input. Please enter a number.\n");
                    continue;
                }

                switch (userDecision)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DeleteProduct();
                        break;
                    case 3:
                        ViewProducts();
                        break;
                    case 4:
                        Console.WriteLine("\nBye!");
                        return;
                    default:
                        Console.WriteLine("\nPlease pick a number between 1 and 4.\n");
                        break;
                }
            }
        }

        static void DisplayScreen()
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. Delete a product");
            Console.WriteLine("3. View your products");
            Console.WriteLine("4. Exit");
            Console.Write("Your Entry: ");
        }

        static void AddProduct()
        {
            Console.Write("\nEnter the name of the product you wish to add: ");
            string name = Console.ReadLine();

            products.Add(name);

            Console.WriteLine("\nAdding your item now...");
            Thread.Sleep(2000);

            Console.WriteLine($"\n'{name}' has been added to your inventory.\n");

            if (products.Count == 1)
            {
                Console.WriteLine($"You now have {products.Count} item in your inventory.\n");
                Thread.Sleep(1000);
            }
            else if (products.Count > 1)
            {
                Console.WriteLine($"You now have {products.Count} items in your inventory.\n");
                Thread.Sleep(1000);
            }
        }

        static void DeleteProduct()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("\nYour inventory is empty.\n");
                return;
            }

            Console.Write("\nEnter the name of the product you wish to delete: ");
            string delete = Console.ReadLine();

            Console.WriteLine("\nDeleting your item now...");
            Thread.Sleep(2000);

            if (products.Remove(delete))
            {
                Console.WriteLine($"\n'{delete}' has been removed from your inventory.\n");
                if (products.Count == 1)
                {
                    Console.WriteLine($"You now have {products.Count} item in your inventory.\n");
                }
                else if (products.Count > 1)
                {
                    Console.WriteLine($"You now have {products.Count} items in your inventory.\n");
                }
                else
                {
                    Console.WriteLine("Inventory Empty.");
                }
            }
            else
            {
                Console.WriteLine($"\n'{delete}' is not found in your inventory.\n");
            }
        }

        static void ViewProducts()
        {
            Console.WriteLine("\nLoading your products now...\n");
            Thread.Sleep(2000);

            foreach (var product in products)
            {
                if (products.Count > 0)
                {
                    Console.WriteLine($"{product}\n");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Empty Inventory.");
                }
            }
        }
    }
}