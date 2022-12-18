using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleProgramCalculatingGratuityAndTotalAmount

/*
 * Name: Maryna Sposabava
 * Date: 04/11/2022
 * Lab Report 1
 * 
 * This assignment represents my own work and 
 * is in accordance with the College Academic Policy
 * */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Calculating Gratuity and Total Amount." 
                + Environment.NewLine +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Please, enter a subtotal amount: ");

            string subtotal = Console.ReadLine();
            double subtotal1 = Convert.ToDouble(subtotal);

            Console.Write("\r\nPlease, enter a gratuity rate: ");

            string gratuityRate = Console.ReadLine();
            double gratuityRate1 = Convert.ToDouble(gratuityRate);

            double gratuity, total;
            gratuity = subtotal1 * gratuityRate1 / 100;
            total = subtotal1 + gratuity;

            string finalGratuity = "Gratuity: " + "$" + gratuity;
            string finalTotal = "Total: " + "$" + total;

            Console.WriteLine(Environment.NewLine +
                finalGratuity + Environment.NewLine +
                finalTotal + Environment.NewLine +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine(Environment.NewLine +
                "Program Converting Minutes" +
                Environment.NewLine +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" 
                + Environment.NewLine);

            Console.Write("Please, enter any number of minutes: ");

            string minutes = Console.ReadLine();
            ulong minutes1 = Convert.ToUInt64(minutes);

            ulong hours, days, years, remainingMinutes, remainingMinutes1, minutes2;

            years = minutes1 / 525600;
            remainingMinutes = minutes1 % 525600;
            days = remainingMinutes / 1440;
            remainingMinutes1 = remainingMinutes % 1440;
            hours = remainingMinutes1 / 60;
            minutes2 = remainingMinutes1 % 60;

            string finalMinutes = "This equals to:"  + years + "years "
                + days + "days " + hours + "hours " + minutes2 + "minutes.";

            Console.WriteLine(Environment.NewLine
                + finalMinutes 
                + Environment.NewLine);
            
            Console.WriteLine("Please, hit any key to exit."
                 + Environment.NewLine +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.ReadLine();
        }
    }
}
