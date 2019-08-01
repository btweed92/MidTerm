﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPos
{
    class TerminalMethods
    {
        public static void WelcomeMenu()
        {
            Console.WriteLine("                         vvvvvvv                       ");
            Console.WriteLine("       O~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~O      ");
            Console.WriteLine("       >      Welcome to Deno's Pizzeria!       <      ");
            Console.WriteLine("       >              Gran Giorno!              <      ");
            Console.WriteLine("       >            555 - 888 - 1000            <      ");
            Console.WriteLine("       O~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~O      ");
            Console.WriteLine("                         ^^^^^^^                       ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("           ==================================          ");
            Console.WriteLine("                    1. Add To Order                    ");
            Console.WriteLine("                    2. Add New Item To Menu            ");
            Console.WriteLine("                    3. Leave The Pizzeria              ");
            Console.WriteLine("           ==================================          ");
            Console.WriteLine("                 What would you like to do?            ");

        }

        public static string ReceiptItems()
        {
            foreach (var item in collection)
            {
                List<string> orderedItems = new List<string>
            }
        }

        public static void PriceCalculator()
        {
            double subTotal = 0;//{ item.Name }{ item.Price };
            subTotal = Math.Round(subTotal, 2);
            foreach (var item in collection)
            {
                subTotal += item.Price;
            }

            double salesTax = subTotal * .06;
            salesTax = Math.Round(salesTax, 2);

            double totalAmount = subTotal + salesTax;
            totalAmount = Math.Round(totalAmount, 2);
            Console.WriteLine("   ===============================================     ");
            Console.WriteLine($"Subtotal        ..........            ${subTotal}     ");
            Console.WriteLine();
            Console.WriteLine($"Sales Tax (6%)  ..........            ${salesTax}     ");
            Console.WriteLine();
            Console.WriteLine($"Total           ..........            ${totalAmount}  ");
            Console.WriteLine();
            if (card)
            {

                Console.WriteLine(card.payment)
            }
            else if (cash)
            {

                Console.WriteLine(payment);
            }
            else if (check)
            {
                Console.WriteLine();
            }
            Console.WriteLine("   ===============================================     ");
        }

        public static void CompleteReceipt()
        {
            ReceiptItems();
            Console.WriteLine();
            PriceCalculator();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       S~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~S      ");
            Console.WriteLine("       S  Thanks for visiting Deno's Pizzeria!  S      ");
            Console.WriteLine("       S              Gran Giorno!              S      ");
            Console.WriteLine("       S            555 - 888 - 1000            S      ");
            Console.WriteLine("       S~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~S      ");


        }
    }
}