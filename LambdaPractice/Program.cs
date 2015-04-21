using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};
            

            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();
            


            //print the kayakProducts to the console using a foreach loop.
            foreach(string product in kayakProducts)
            { Console.WriteLine(product); }

            Console.WriteLine("");

            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();

            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (string product in shoeProducts)
            { Console.WriteLine(product); }

            Console.WriteLine("");

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.Contains("ball")).ToList();

            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach (string product in ballProducts)
            { Console.WriteLine(product); }

            Console.WriteLine("");

            //sort ballProducts alphabetically and print them to the console.
            foreach (string product in ballProducts.OrderBy(x=> x))
            { Console.WriteLine(product); }

            Console.WriteLine("");

            //print the product with the longest name to the console using the .First() extension.

            Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            

            Console.WriteLine("");

            //print the product with the shortest name to the console using the .First() extension.
            Console.WriteLine(products.OrderBy(x => x.Length).First());


            Console.WriteLine("");

            //print the product with the 3rd shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).  
            
            
            foreach (string product in ballProducts.OrderBy(x => x.Length).Take(3))
            { Console.WriteLine(product); }

            Console.WriteLine("");
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()). 
            List<string> ballPSecondLongest = ballProducts.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine(ballPSecondLongest[1]);
            Console.WriteLine("");
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reversedProducts = products.OrderByDescending(x => x.Length).Reverse().ToList(); 
            //print out the reversedProducts to the console using a foreach loop.
            foreach (string item in reversedProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list
            foreach (string item in products.OrderByDescending(x => x.Length))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            //FILL IN THE FUNCTIONS BELOW TO MAKE THE TESTS PASS

            Console.ReadKey();
        }

        public static string LongestName(List<string> inputList)
        {
            //with the input list, return the item with the longest name
            return inputList.OrderByDescending(x => x.Length).First();
        }

        public static string ShortestName(List<string> inputList)
        {
            //with the input list, return the item with the shortest name
            return inputList.OrderBy(x => x.Length).First();
        }

        public static string SecondLongestName(List<string> inputList)
        {
            //with the input list, return the item with the second longest name
            List<string> secondLongest = inputList.OrderByDescending(x => x.Length).ToList();
            return secondLongest[1].ToString();
        }

        public static string ThirdShortestName(List<string> inputList)
        {
            //with the input list, return the item with the third shortest name
            List<string> thirdShortest = inputList.OrderBy(x => x.Length).ToList();
            return thirdShortest[2].ToString();
            
        }

        public static List<string> BallProducts(List<string> inputList)
        {
            //with the input list, return a list with only the the products that contain the word ball
            return inputList.Where(x => x.Contains("ball")).ToList();
        }
        public static List<string> EndInS(List<string> inputList)
        {
            //with the input list, return a list with only the the products that end with the letter s
            return inputList.Where(x => x.EndsWith("s")).ToList();
        }
    }
}