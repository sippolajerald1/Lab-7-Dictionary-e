using System.Security.Cryptography.X509Certificates;

namespace Lab_7_Dictionary_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> FoodList = new Dictionary<int, string>();
            Dictionary<string, int> RestarauntList = new Dictionary<string, int>();
            Dictionary<string, double> PriceList = new Dictionary<string, double>();

            // adding foods
            FoodList.Add(2, "Cheeseburger");
            FoodList.Add(1, "Pizza");
            FoodList.Add(4, "Taco");
            FoodList.Add(3, "Banana");
            FoodList.Add(5, "Rasberries");

            Console.WriteLine("FoodList Keys");
            Dictionary<int, string>.KeyCollection keys = FoodList.Keys;
            foreach (int key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }
            Console.WriteLine();

            Console.WriteLine("FoodList Values");
            Dictionary<int, string>.ValueCollection values = FoodList.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("FoodList Key/Value Pairs");
            foreach (KeyValuePair<int, string> kvp in FoodList)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }

            Console.WriteLine();

            Console.WriteLine(("Food list Key/Value Pairs"));
            foreach (KeyValuePair<int, string> kvp in FoodList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
                Console.WriteLine();
                // changing values
                FoodList[1] = "Pizza";
                FoodList[2] = "CheeseBurger";
                FoodList.Remove(3);
            }
                Console.WriteLine("Revised FoodList Key/Value Pairs");
                foreach (KeyValuePair<int, string> kvp in FoodList)
                { 
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
                }

                Console.WriteLine();

                // Adding Restaraunts
                RestarauntList.Add("BurgerKing", 7);
                RestarauntList.Add("PizzaHut", 6);
                RestarauntList.Add("TacoBell", 8);
                RestarauntList.Add("DairyQueen", 10);
                RestarauntList.Add("Glenns", 9);
                bool addrestaraunt = true;
                while (addrestaraunt)
                {
                    Console.WriteLine("Enter the name of the restaraunt you wish to add");
                    string restName = Console.ReadLine();
                    if (RestarauntList.ContainsKey(restName))
                    {
                        RestarauntList.Remove(restName);
                    }
                    Console.WriteLine("Enter the food number you wish to add (11+)");
                    int restnum = int.Parse(Console.ReadLine());
                    RestarauntList.Add(restName, restnum);
                    Console.WriteLine("The reastaraunt has been added");
                    Console.WriteLine("Add another? (y for yes, any key for no)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                        continue;
                    else
                        addrestaraunt = false;

                }
                Console.WriteLine($"There are  {RestarauntList.Count} restaraunts in your list");
                foreach (KeyValuePair<string, int> kvp2 in RestarauntList)
                {
                    Console.WriteLine($"Food Restaurant Name: {kvp2.Key}  Number: {kvp2.Value}");
                }
                Console.WriteLine();

                // adding price

                PriceList.Add("Hamburger", 7.50);
                PriceList.Add("Pizza", 20.00);
                PriceList.Add("Taco", 3.00);
                PriceList.Add("Banana", 5.00);
                PriceList.Add("Rasberries", 2.00);

                // Price list formatted output
                Console.WriteLine("Prices for different foods");
                foreach (KeyValuePair<string, double> kvp3 in PriceList)
                {
                    Console.WriteLine($"Position: {kvp3.Key}  Price: " + String.Format("{0:C}", kvp3.Value));
                }

                Console.WriteLine();
                Console.WriteLine($"The number of food items are: {PriceList.Count}");






            }

        }
    
}
