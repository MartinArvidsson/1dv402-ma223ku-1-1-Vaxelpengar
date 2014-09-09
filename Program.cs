using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Växelpengar_labration_Martin_Arvidsson_UD14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anger Variabler 
            double TotalSum;
            double MoneyFromCustomer;
            double FinalPrice;

            //Frågar om hur mkt kunden ska betala, gör också om strängen till ett nummer som programmet kan jobba med
            Console.Write("Ange den totala summan pengar som ska betalas: ");
            TotalSum = double.Parse(Console.ReadLine());

            //Frågar om hur mkt pengar kunden gav dig och läser om strängen till ett nummer som programmet kan jobba med
            Console.Write("Ange pengarna som kunden har gett dig: ");
            MoneyFromCustomer = double.Parse(Console.ReadLine());
            //Presenterar Grafiskt

            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------------------");

            // Beräknar pengarna kunden gav dig - vad det kostar
            FinalPrice = MoneyFromCustomer - TotalSum;

            //Presenterar resultatet.
            Console.WriteLine("Vad som ska betalas är {0:f2}", FinalPrice);
        }
    }
}
