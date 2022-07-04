using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Miniräknare
{
    public class Calculations
    {
        public double res { get; set; }
        public string result { get; set; }

        public Calculations()
        {

        }


        public List<string> ListOfCalculations = new List<string>();
        

        public double Addition(double augend, double addend)
        {
            res = augend + addend;
            Console.WriteLine("---------");
            Console.WriteLine($"Summa: " + res);
            result = $"{augend} + {addend} = {res}";
            ListOfCalculations.Add(result);

            return res;
        }

        public double Subtraction(double minuendand, double subtrahend)
        {
            res = minuendand - subtrahend;
            Console.WriteLine("---------");
            Console.WriteLine($"Differens: " + res);
            result = $"{minuendand} - {subtrahend} = {res}";
            ListOfCalculations.Add(result);

            return res;
        }
        public double Multiplication(double multiplicand, double multiplier)
        {
            res = multiplicand * multiplier;
            Console.WriteLine("---------");
            Console.WriteLine($"Produkt: " + res);
            result = $"{multiplicand} x {multiplier} = {res}";
            ListOfCalculations.Add(result);

            return res;
        }
        public double Division(double dividend, double divisor)
        {
            res = dividend / divisor;
            Console.WriteLine("---------");
            Console.WriteLine($"Kvot: " + res);
            result = $"{dividend} / {divisor} = {res}";
            ListOfCalculations.Add(result);

            return res;
        }
        public string ShowCalculations()
        {
                foreach (var item in ListOfCalculations)
                {
                    Console.WriteLine($"{item}");
                    return item;
                }
            Console.ReadLine();
            Console.Clear();
            return null;
        }
    }
}
