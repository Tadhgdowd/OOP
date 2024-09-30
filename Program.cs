/*
Name = Tadhg Dowdall
Student Number = S00250843
 
 
 
 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // test cases 
            //int[] ints = { 1, 2, 3 };
            //Zero(ints);


            //int n1 = 5; int n2 = 10;
            //Sum(n1 , n2);



            int stockOnHand = 2; int sales = 3;
        
            Console.WriteLine(StockOnHand(stockOnHand, sales));



        }



        static bool ValidAge(int age)
        {

            if (age >= 18 && age <=21)
            {
                return true;
            } 
            return false;


        }


        static double ReturnCostOfProduct(string product)
        {
            switch(product)
            {
                case "Jeans":
                    return 67.99;
                case "Jacket":
                    return 68.99;
                case "Boots":
                    return 34.99;
                case "Scarves":
                    return 10;
                case "Belts":
                    return 10;
                case "Socks":
                    return 10;
                default:
                    return -999;

            }

        }

        static void Zero(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }

            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        static int Sum(int n1, int n2)
        {

            // Ensure n1 is less than n2
            if (n1 > n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }

            int sum = 0; // Initialize sum to zero
            int counter = n1; // Start counter from n1

            while (counter <= n2) // Include n2 in the sum
            {
                sum += counter; // Add the current counter to sum
                Console.WriteLine(counter); // Optional: Print the current number
                counter++; // Increment the counter
            }

            Console.WriteLine("Final Sum: " + sum); // Print the final sum
            return sum; // Return the calculated sum
        }

        static bool StockOnHand(int stockOnHand, int salesFigure)
        {
          
            if (stockOnHand >= salesFigure)
            {
                // Deduct the sales figure from stock
                stockOnHand -= salesFigure;
                return true;
            }
            return false;
        }



    }
}
