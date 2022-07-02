using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Miniräknare
{
    public class Menu
    {
        Calculations c = new Calculations();
        public void MenuController()
        {
            Console.WriteLine("Välkommen till Miniräknaren!");
            Console.WriteLine("[1] - Miniräknare \n[2] - Visa alla uträkningar \n[3] - Avsluta");
            Console.Write("Välj: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool start = true;
            while (start)
            {
                switch (answer)
                {
                    case 1:
                        CalculatorInput();
                        break;
                    case 2:
                        c.ShowCalculations();
                        MenuController();
                        break;
                    case 3:
                        Console.WriteLine("Tack för denna gången! Ses snart igen!");
                        start = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Fel! Ogiltigt menyval! Vänligen välj giltigt menyval!");
                        Console.ReadLine();
                        Console.Clear();
                        MenuController();
                        break;
                }
            }
        }
        public void CalculatorInput()
        {
            Console.WriteLine();
            Console.Write("Välj räknesätt \n Addition: + | Subtraktion: - | Multiplikation: x | Division: / \nVälj: ");
            string answer = Console.ReadLine();
            Console.WriteLine();
            double number1;
            double number2;
            //Console.Write("Siffra: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Siffra: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            switch (answer)
            {
                case "+":
                    Console.Write("Siffra: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Siffra: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    c.Addition(number1, number2);
                    Console.ReadLine();
                    Console.Clear();
                    MenuController();
                    break;

                case "-":
                    Console.Write("Siffra: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Siffra: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    c.Subtraction(number1, number2);
                    Console.ReadLine();
                    Console.Clear();
                    MenuController();
                    break;

                case "x":
                    Console.Write("Siffra: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Siffra: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    c.Multiplication(number1, number2);
                    Console.ReadLine();
                    Console.Clear();
                    MenuController();
                    break;

                case "/":
                    Console.Write("Siffra: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Siffra: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    c.Division(number1, number2);
                    Console.ReadLine();
                    Console.Clear();
                    MenuController();
                    break;

                default:
                    Console.WriteLine("Fel! Ogiltig räknesätt vald! Vänligen välj giltig räknesätt!");
                    break;
            }
        }
    }
}
