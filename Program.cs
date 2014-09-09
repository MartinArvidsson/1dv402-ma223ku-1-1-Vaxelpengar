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

            //  Öresavrundning, Finalprice är lika med Totalsum avrundat, Totalsum är vad sakerna kostar. Rounding off är priset efter avrundingen Rounding off blir Kostnaden av sakerna - pengarna 
            // som man fick av kunden.

            FinalPrice = (uint)Math.Round(TotalSum);
            RoundingOff = TotalSum - MoneyFromCustomer;

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
