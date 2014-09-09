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
            int MoneyFromCustomer;
            uint FinalPrice;
            double RoundingOff;
            

            //Frågar om hur mkt kunden ska betala, gör också om strängen till ett nummer som programmet kan jobba med

            Console.Write("Ange den totala summan pengar som ska betalas: ");
            TotalSum = double.Parse(Console.ReadLine());

            //Frågar om hur mkt pengar kunden gav dig och läser om strängen till ett nummer som programmet kan jobba med

            Console.Write("Ange pengarna som kunden har gett dig: ");
            MoneyFromCustomer = int.Parse(Console.ReadLine());

            //Presenterar Grafiskt

            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------------------");

            //  Öresavrundning sker här, Dock så avrundar en inte bara decimalerna utan allt innan också. ska åtgärdas

            FinalPrice = (uint)Math.Round(TotalSum);
            RoundingOff = FinalPrice - MoneyFromCustomer;

            //Presenterar resultatet.
            Console.WriteLine("Totalt");
            Console.WriteLine("Öresavrundning: {0} ", RoundingOff); // {0:f2} innebär att öresavrundningen skrivs med 2 decimaler.
            Console.WriteLine("Att Betala");
            Console.WriteLine("Kontant");
            Console.WriteLine("Totalt");
            Console.WriteLine("---------------------------------------");

        }
    }
}
