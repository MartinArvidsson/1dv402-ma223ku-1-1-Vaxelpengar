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
                        break;
                    }
                    catch
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel! du har inte angivit ett heltal!");
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
                        break;
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel! du har inte angivit ett heltal! Talet får inte inehålla bokstäver eller kommatecken!");
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

                //Presenterar resultatet.
                Console.WriteLine("Totalt           :   {0:c} ", TotalSum);
                Console.WriteLine("Öresavrundning   :   {0:c} ", RoundingOff);
                Console.WriteLine("Att Betala       :   {0} kr ", TotalAfterRounding);
                Console.WriteLine("Kontant          :   {0} kr ", MoneyFromCustomer);
                Console.WriteLine("Tillbaka         :   {0} kr ", WhatToPay);
                Console.WriteLine("---------------------------------------");

                // Beräknar antal sedlar som ska lämnas ut med hjälp av modulous och presenterar resultatet.
                Console.WriteLine("Femhundralappar  :   " + (WhatToPay - WhatToPay % 500) / 500); WhatToPay = WhatToPay % 500;
                Console.WriteLine("Hundralappar     :   " + (WhatToPay - WhatToPay % 100) / 100); WhatToPay = WhatToPay % 100;
                Console.WriteLine("Femtiolappar     :   " + (WhatToPay - WhatToPay % 50) / 50); WhatToPay = WhatToPay % 50;
                Console.WriteLine("tjugolappar      :   " + (WhatToPay - WhatToPay % 20) / 20); WhatToPay = WhatToPay % 20;
                Console.WriteLine("tiokronor        :   " + (WhatToPay - WhatToPay % 10) / 10); WhatToPay = WhatToPay % 10;
                Console.WriteLine("Femkronor        :   " + (WhatToPay - WhatToPay % 5) / 5); WhatToPay = WhatToPay % 5;
                Console.WriteLine("Enkronor         :   " + (WhatToPay - WhatToPay % 1) / 1);

            }
        }
}
