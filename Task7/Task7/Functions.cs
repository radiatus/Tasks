using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    class Functions
    {
         private static readonly string[][] units = new string[][] {
            new string[] {"", "один ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь ", "девять " },
            new string[] {"", "одна ","две ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь ", "девять "},
            new string[] {"", "десять ","двадцать ","тридцать ","сорок ","пятьдесят ", "шестьдесят ", "семьдесят ","восемьдесят ","дявяносто "},
            new string[] {"", "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятсот "},
            new string[] {"десять ","одинадцать ", "двенадцать ", "тринадцать ","четырнадцать ", "пятьнадцать ", "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать "}
        };

        public static string ConvertNumberToText(string NumberString)
        {
            int Number = Convert.ToInt32(NumberString);

            string NumberText = "";

            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int l = 0, j = 1; l < 6; l++, j *= 10)
                {
                    if (i == l)
                        numbers[i] = Number % (j * 10) / j;
                }
            }
                        
            if (numbers[4] <= 1 && numbers[4] !=0 && numbers[3] != 0)
            {

                NumberText += get(numbers[5], 3);
                NumberText += get(numbers[3], 4);
            }
            else
            {
                NumberText += get(numbers[5], 3);
                NumberText += get(numbers[4], 2);
                NumberText += get(numbers[3], 1);
            }
            
            if (numbers[5] != 0 || numbers[4] != 0 || numbers[3] != 0)
                NumberText += thousands(numbers[3]);
            
            if (numbers[1] <= 1 && numbers[1] != 0 && numbers[0] != 0)
            {
                NumberText += get(numbers[2], 3);
                NumberText += get(numbers[0], 4);
            }
            else
            {
                NumberText += get(numbers[2], 3);
                NumberText += get(numbers[1], 2);
                NumberText += get(numbers[0], 0);
            }
            return NumberText;
        }

        private static string get(int number, int discarge)
        {
            return units[discarge][number];
        }

        private static string thousands(int i)
        {
            switch (i)
            {
                case 1:
                    return "тысяча ";
                case 3:
                case 4:
                    return "тысячи ";
                default:
                    return "тысяч ";
            }
        }

        private static int[] getNumbers(int number)
        {
            int[] numbers = new int[6];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int l = 0, j = 1; l < 6; l++, j *= 10)
                {
                    if (i == l)
                        numbers[i] = number % (j * 10) / j;
                }
            }
            return numbers;
        }
    }
}