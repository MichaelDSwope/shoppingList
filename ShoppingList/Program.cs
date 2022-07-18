using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace ShoppingList
{
    class program
    {
        static Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>();

        public static void BuildMenu()
        {
            MenuItem menuItem0 = new MenuItem()
            //need to convert Price to decimal
            {
                ID = 100,
                Item = "lettuce",
                Price = 1.15m
            };
            MenuItem menuItem1 = new MenuItem()
            {
                ID = 101,
                Item = "bacon",
                Price = 2.25m
            };
            MenuItem menuItem2 = new MenuItem()
            {
                ID = 102,
                Item = "pickle",
                Price = 1.00m
            };
            MenuItem menuItem3 = new MenuItem()
            {
                ID = 103,
                Item = "buns",
                Price = 1.05m
            };
            MenuItem menuItem4 = new MenuItem()
            {
                ID = 104,
                Item = "mayo",
                Price = 2.05m
            };
            MenuItem menuItem5 = new MenuItem()
            {
                ID = 105,
                Item = "chicken",
                Price = 2.95m
            };
            MenuItem menuItem6 = new MenuItem()
            {
                ID = 106,
                Item = "sweet onion",
                Price = 2.75m
            };
            MenuItem menuItem7 = new MenuItem()
            {
                ID = 107,
                Item = "cheese",
                Price = 2.05m
            };

            
          
            // items ordered in columns after sum


            menuItems.Add(menuItem0.Item, menuItem0.Price);
            menuItems.Add(menuItem1.Item, menuItem1.Price);
            menuItems.Add(menuItem2.Item, menuItem2.Price);
            menuItems.Add(menuItem3.Item, menuItem3.Price);
            menuItems.Add(menuItem4.Item, menuItem4.Price);
            menuItems.Add(menuItem5.Item, menuItem5.Price);
            menuItems.Add(menuItem6.Item, menuItem6.Price);
            menuItems.Add(menuItem7.Item, menuItem7.Price);
            
        }

        public static void DisplayMenu()
        {
            foreach(var menuItem in menuItems)
            {
                Console.WriteLine("{0} ---- ${1}", menuItem.Key, menuItem.Value);
            }
        }
       
        public static bool ItemIsOnMenu(string userEntry)
        {
            //return menuItems.ContainsKey(userEntry);
            foreach(var item in menuItems)
            {
                if(item.Key == userEntry)
                {  
                    return true;
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            BuildMenu();
            DisplayMenu();

            
            List<string> shoppingList = new List<string>();
            bool addMoreToOrder = true;
            decimal totalPrice = 0m;
            while(addMoreToOrder)
            {

                //ask what user wants to order
                
                bool itemIsOnMenu = false;
                while (!itemIsOnMenu)
                {
                    Console.WriteLine("Enter an item please.");
                    //accept input
                    string userEntry = Console.ReadLine();

                    //validate that name is on menu
                    itemIsOnMenu = ItemIsOnMenu(userEntry);
                    //if not on menu, error message and display menu again
                    if (!itemIsOnMenu)
                    {
                        Console.WriteLine("Incorrect item!");
                    }
                    else
                    {
                        shoppingList.Add(userEntry);
                    }
                }

                Console.WriteLine("would you like to add more to your order?:  y/n");
                addMoreToOrder = Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase);

                ////if on menu, add to order
                //while (itemIsOnMenu)
                //{
                    
                //    Console.WriteLine("    ");
                //    Console.WriteLine(userEntry + ("+"));
                    

                //}

            }

            foreach(var shopping in shoppingList)
            {
                
                var price = menuItems[shopping];
                totalPrice += price;
                Console.WriteLine("{0} {1}", shopping, price);
            }
            Console.WriteLine("{0}", totalPrice);
            //ask if done, if not, loop

            //List<string> lsShopping = new List<string>();
            
            //lsShopping.Add("lettuce");
            //lsShopping.Add("bacon");
            //lsShopping.Add("pickle");
            //lsShopping.Add("buns");
            //lsShopping.Add("mayo");
            //lsShopping.Add("chicken");
            //lsShopping.Add("sweet onion");
            //lsShopping.Add("cheese");
        }
        
        //sum price of items ordered
        
        public class MenuItem
        {
            public int ID { get; set; }
            public string Item { get; set; }
            public decimal Price { get; set; }
        }
       
        
        //Console.WriteLine("{0}+{1} = {}" num1+num2=sum);

    }
}
