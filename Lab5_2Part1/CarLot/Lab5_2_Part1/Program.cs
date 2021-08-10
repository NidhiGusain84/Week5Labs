using System;
using System.Collections.Generic;

namespace Lab5_2_Part1
{
    enum CarMake
    {
        Ford,
        Chevorlet,
        Chrysler,
        Honda,
        Toyota


    }
    class Program
    {
        static void Main(string[] args)
        {
           List<Car> myList =  ListCar();
            string response;

            Console.WriteLine("Welcome to my Car Emporium!\n");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{i + 1} {myList[i].ToString()}");
            }
            
            while(true)
            {
                Console.WriteLine("What would you like to do?\n1. Add a car\n2. Purchase a car\n3. Quit");
                Console.WriteLine("Please enter A or P or Q");

                 response = Console.ReadLine().ToUpper();

                while (response != "A" && response != "P" && response != "Q")
                {
                    Console.WriteLine("Please enter A or P or Q");
                    response = Console.ReadLine().ToUpper();
                }

                if (response == "A")
                {
                    AddCar(myList);
                }
                else if (response == "P")
                {
                    PurchaseCar(myList);
                }
                else
                {
                    break;
                }

               string userInput = Continue();

                if (userInput == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("\nGoodbye!");

            //test code
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{i + 1} {myList[i].ToString()}");
            }

        }

        public static List<Car> ListCar()
        {

            List<Car> myList = new List<Car>();

            NewCar nc = new NewCar(CarMake.Ford, "Mustang", 2015, 32000, true);
            myList.Add(nc);
            nc = new NewCar(CarMake.Chevorlet, "Equinox", 2020, 27500, false);
            myList.Add(nc);
            nc = new NewCar(CarMake.Chrysler, "Voyager", 2021, 28000, true);
            myList.Add(nc);
            nc = new NewCar(CarMake.Honda, "Odyssey", 2011, 35423, true);
            myList.Add(nc);
            nc = new NewCar(CarMake.Toyota, "Venza", 2021, 38354, false);
            myList.Add(nc);

            UsedCar uc = new UsedCar(CarMake.Honda, "Civic", 2014, 24054, 3, 18);
            myList.Add(uc);
            uc = new UsedCar(CarMake.Ford, "Escape", 2018, 22005, 2, 21);
            myList.Add(uc);
            uc = new UsedCar(CarMake.Chrysler, "Pacifica", 2016, 24054, 1, 19);
            myList.Add(uc);
            uc = new UsedCar(CarMake.Toyota, "Sienna", 2017, 31450, 2, 23);
            myList.Add(uc);
            uc = new UsedCar(CarMake.Chevorlet, "Sonic", 2013, 24054, 4, 20);
            myList.Add(uc);
            return myList;

        }

        public static void AddCar(List<Car> carsList)
        {
            Console.Write("\nWhat type of car do you want to add? New or Used?: ");
            string carCondition = Console.ReadLine().ToLower();
            while (carCondition != "new" && carCondition != "used")
            {
                Console.Write("\nPlease enter new or old: ");
                carCondition = Console.ReadLine().ToLower();
            }

            if (carCondition == "new")
            {
                AddNewCar(carsList);
            }
            else
            {
                AddUsedCar(carsList);
            }

        }

        public static void  AddNewCar(List<Car> cars)
        {
           
            Console.WriteLine("\nPlease enter car details.");
            Console.Write("Car make: ");
            string strMake = Console.ReadLine();          
            Enum.TryParse(strMake, out CarMake make);
           
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Extended Warranty? True or False: ");
            bool extendedWarranty = bool.Parse(Console.ReadLine().ToLower());

            NewCar nc = new NewCar(make, model, year, price, extendedWarranty);
            cars.Add(nc);

        }

        public static void AddUsedCar(List<Car> cars)
        {
         
            Console.WriteLine("\nPlease enter car details.");
            Console.Write("Car make: ");
            string strMake = Console.ReadLine();
            Enum.TryParse(strMake, out CarMake make);

            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Number of Owners: ");
            int owners = int.Parse(Console.ReadLine());
            Console.Write("Mileage: ");
            int mileage = int.Parse(Console.ReadLine());

            UsedCar uc = new UsedCar(make, model, year, price, owners, mileage);
            cars.Add(uc);

        }

        public static void PurchaseCar(List<Car> cars)
        {
            Console.Write("Which car you want to purchase? Please enter car no: ");
            int choice = int.Parse(Console.ReadLine());

            cars.RemoveAt(choice - 1);

        }

        public static string Continue()
        {
            Console.Write("Continue? Enter y or n: ");
            string input = Console.ReadLine().ToLower();
            while (input != "y" && input != "n")
            {
                Console.Write("Enter y or n: ");
                input = Console.ReadLine().ToLower();
            }
            return input;

        }

    }
}
