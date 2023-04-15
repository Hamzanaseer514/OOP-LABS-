using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            float price;
            int toyPrice;
            int sum = 0;
            int counter1 = 1;
            int counter2 = 0;
            Console.Write("Enter your age : ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter the total price of washing machine : ");
           price = float.Parse(Console.ReadLine()); 
            
            Console.Write("Enter the total price of toy : ");
            toyPrice = int.Parse(Console.ReadLine());
           float total =  lilly(ref counter1,ref counter2,ref age,ref sum,ref price,ref toyPrice);
            float answer;

            if (total >= price)
            {
                answer = total - price;
                Console.WriteLine("Yes! " + answer);
                Console.ReadKey();
            }
            if (total < price)
            {
                answer = -(total - price);
                Console.WriteLine("NO! " + answer);
                Console.ReadKey();
            }

        }

        static float lilly(ref int counter1,ref int counter2,ref int age, ref int sum,ref float price,ref int toyPrice)
        {
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + (counter1 * 10);
                    counter1++;
                }
                else
                {
                    counter2++;
                }
            }
            counter1 = counter1 - 1;
            float total = sum - counter1;
            float answer = toyPrice * counter2;
            total = total + answer;
            return total;
           
        }
    }
}
