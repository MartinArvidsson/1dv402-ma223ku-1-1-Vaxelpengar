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
            double  TotalSum;
            int     MoneyFromCustomer;
            double  RoundingOff;
            int     TotalAfterRounding;
            int     WhatToPay;

            

            //Frågar om hur mkt kunden ska betala, gör också om strängen till ett nummer som programmet kan jobba med

            Console.Write("Ange den totala summan pengar som ska betalas: ");
            TotalSum = double.Parse(Console.ReadLine());

            //Frågar om hur mkt pengar kunden gav dig och läser om strängen till ett nummer som programmet kan jobba med

            Console.Write("Ange pengarna som kunden har gett dig: ");
            MoneyFromCustomer = int.Parse(Console.ReadLine());

            //Presenterar Grafiskt

            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------------------");

            //  Öresavrundning sker här, Dock så avrundar en inte bara decimalerna utan hela talet i dagsläget. ska åtgärdas.

            TotalAfterRounding = (int)Math.Round(TotalSum);
            RoundingOff = TotalAfterRounding - TotalSum;

            WhatToPay = MoneyFromCustomer - TotalAfterRounding;

            //Presenterar resultatet.
            Console.WriteLine("Totalt: {0:c} ", TotalSum);
            Console.WriteLine("Öresavrundning: {0:c} ", RoundingOff ); // {0:f2} innebär att öresavrundningen skrivs med 2 decimaler.
            Console.WriteLine("Att Betala: {0:c:} ", TotalAfterRounding);
            Console.WriteLine("Kontant : {0:c:} ", MoneyFromCustomer);
            Console.WriteLine("Totalt: {0:c} ", WhatToPay);
            Console.WriteLine("---------------------------------------");

        }
    }
}
