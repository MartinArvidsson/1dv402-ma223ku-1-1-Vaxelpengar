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
            double RoundingOff;
            int TotalAfterRounding;
            int WhatToPay;






            //Frågar om hur mkt kunden ska betala, gör också om strängen till ett nummer som programmet kan jobba med
            while (true)
            {
                try
                {
                    Console.Write("Ange den totala summan pengar som ska betalas: ");
                    TotalSum = double.Parse(Console.ReadLine());
                    if (TotalSum < 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel! Talet måste vara större än 1!");
                        Console.ResetColor();
                        return;
                    }

                    break;
                }
                catch
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! du har inte angivit ett heltal! Eller så är talet för stort!");
                    Console.ResetColor();
                }
            }
            //Frågar om hur mkt pengar kunden gav dig och läser om strängen till ett nummer som programmet kan jobba med
            while (true)
            {
                try
                {
                    Console.Write("Ange pengarna som kunden har gett dig: ");
                    MoneyFromCustomer = int.Parse(Console.ReadLine());
                    if (MoneyFromCustomer < TotalSum)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel! kunden måste betala mer än vad varan kostar!");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! du har inte angivit ett heltal! Eller ett ett tal som är för stort eller för litet!");
                    Console.ResetColor();
                }
            }
            //Presenterar Grafiskt

            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------------------");

            //  Öresavrundning sker här.

            TotalAfterRounding = (int)Math.Round(TotalSum);
            RoundingOff = TotalAfterRounding - TotalSum;
            WhatToPay = MoneyFromCustomer - TotalAfterRounding;

            //Presenterar resultaten av beräkningarna av hur mycket som ska lämnas tillbaka.
            Console.WriteLine("Totalt           :   {0:c} ", TotalSum);
            Console.WriteLine("Öresavrundning   :   {0:c} ", RoundingOff);
            Console.WriteLine("Att Betala       :   {0} kr ", TotalAfterRounding);
            Console.WriteLine("Kontant          :   {0} kr ", MoneyFromCustomer);
            Console.WriteLine("Tillbaka         :   {0} kr ", WhatToPay);
            Console.WriteLine("---------------------------------------");

            // Beräknar antal sedlar som ska lämnas ut med hjälp av modulous ekvationer och presenterar resultaten.
            if ((WhatToPay - WhatToPay % 500) / 500 > 0)
                Console.WriteLine("Femhundralappar  :   " + (WhatToPay - WhatToPay % 500) / 500);
            WhatToPay = WhatToPay % 500;
            if ((WhatToPay - WhatToPay % 100) / 100 > 0)
                Console.WriteLine("Hundralappar     :   " + (WhatToPay - WhatToPay % 100) / 100);
            WhatToPay = WhatToPay % 100;
            if ((WhatToPay - WhatToPay % 50) / 50 > 0)
                Console.WriteLine("Femtiolappar     :   " + (WhatToPay - WhatToPay % 50) / 50);
            WhatToPay = WhatToPay % 50;
            if ((WhatToPay - WhatToPay % 20) / 200 > 0)
                Console.WriteLine("tjugolappar      :   " + (WhatToPay - WhatToPay % 20) / 20);
            WhatToPay = WhatToPay % 20;
            if ((WhatToPay - WhatToPay % 10) / 10 > 0)
                Console.WriteLine("tiokronor        :   " + (WhatToPay - WhatToPay % 10) / 10);
            WhatToPay = WhatToPay % 10;
            if ((WhatToPay - WhatToPay % 5) / 5 > 0)
                Console.WriteLine("Femkronor        :   " + (WhatToPay - WhatToPay % 5) / 5);
            WhatToPay = WhatToPay % 5;
            if ((WhatToPay - WhatToPay % 1) / 1 > 0)
                Console.WriteLine("Enkronor         :   " + (WhatToPay - WhatToPay % 1) / 1);

        }
    }
}
