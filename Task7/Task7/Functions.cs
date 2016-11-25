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
        public static string ConvertNumberToText(string NumberString)
        {
            int Number = Convert.ToInt32(NumberString);

            string NumberText = "";

            int units = Number % 10;
            int tens = (Number - units) % 100 / 10;
            int hundreds = (Number - tens -units) % 1000 / 100;
            int thousands = (Number - tens - units - hundreds) % 10000 / 1000;
            int tensThousands = (Number - tens - units - hundreds - thousands) % 100000 / 10000;
            int hundredsThousands = (Number - tens - units - hundreds - thousands - tensThousands) % 1000000 / 100000;
            int millions = (Number - tens - units - hundreds - thousands - tensThousands - hundredsThousands) % 10000000 /1000000;

            switch (millions)
            {
                case 1:
                    NumberText += "Один миллион ";
                    break;
                case 2:
                    NumberText += "Два миллиона ";
                    break;
                case 3:
                    NumberText += "Три миллиона ";
                    break;
                case 4:
                    NumberText += "Четыре миллиона ";
                    break;
                case 5:
                    NumberText += "Пять миллионов ";
                    break;
                case 6:
                    NumberText += "Шесть миллионов ";
                    break;
                case 7:
                    NumberText += "Семь миллионов ";
                    break;
                case 8:
                    NumberText += "Восемь миллионов ";
                    break;
                case 9:
                    NumberText += "Девять миллионов ";
                    break;
            }

            switch (hundredsThousands)
            {
                case 1:
                    NumberText += "сто ";
                    break;
                case 2:
                    NumberText += "двести ";
                    break;
                case 3:
                    NumberText += "триста ";
                    break;
                case 4:
                    NumberText += "четыреста ";
                    break;
                case 5:
                    NumberText += "пятьсот ";
                    break;
                case 6:
                    NumberText += "шестьсот ";
                    break;
                case 7:
                    NumberText += "семьсот ";
                    break;
                case 8:
                    NumberText += "восемьсот ";
                    break;
                case 9:
                    NumberText += "девятьсот ";
                    break;
            }

            switch (tensThousands)
            {
                case 1:
                    NumberText += "десять ";
                    break;
                case 2:
                    NumberText += "двадцать ";
                    break;
                case 3:
                    NumberText += "тридцать ";
                    break;
                case 4:
                    NumberText += "сорок ";
                    break;
                case 5:
                    NumberText += "пятьдесят ";
                    break;
                case 6:
                    NumberText += "шестьдесят ";
                    break;
                case 7:
                    NumberText += "семьдесят ";
                    break;
                case 8:
                    NumberText += "восемьдесят ";
                    break;
                case 9:
                    NumberText += "девяносто ";
                    break;
            }

            switch (thousands)
            {
                case 1:
                    NumberText += "одна ";
                    break;
                case 2:
                    NumberText += "две ";
                    break;
                case 3:
                    NumberText += "три ";
                    break;
                case 4:
                    NumberText += "четыре ";
                    break;
                case 5:
                    NumberText += "пять ";
                    break;
                case 6:
                    NumberText += "шесть ";
                    break;
                case 7:
                    NumberText += "семьт ";
                    break;
                case 8:
                    NumberText += "восемь ";
                    break;
                case 9:
                    NumberText += "девять ";
                    break;
            }

            if (thousands != 0 || tensThousands != 0 || hundredsThousands != 0)
                NumberText += "тысячи ";
            
            switch (hundreds)
            {
                case 1:
                    NumberText += "сто ";
                    break;
                case 2:
                    NumberText += "двесте ";
                    break;
                case 3:
                    NumberText += "триста ";
                    break;
                case 4:
                    NumberText += "четыреста ";
                    break;
                case 5:
                    NumberText += "пятьсот ";
                    break;
                case 6:
                    NumberText += "шестьсот ";
                    break;
                case 7:
                    NumberText += "семьсот ";
                    break;
                case 8:
                    NumberText += "восемьсот";
                    break;
                case 9:
                    NumberText += "девятьсот ";
                    break;
            }

            switch (tens)
            {
                case 1:
                    NumberText += "десять ";
                    break;
                case 2:
                    NumberText += "двадцать ";
                    break;
                case 3:
                    NumberText += "дридцать ";
                    break;
                case 4:
                    NumberText += "сорок ";
                    break;
                case 5:
                    NumberText += "пятьдесят ";
                    break;
                case 6:
                    NumberText += "шестьдесят ";
                    break;
                case 7:
                    NumberText += "семьдесят ";
                    break;
                case 8:
                    NumberText += "восемьдесят ";
                    break;
                case 9:
                    NumberText += "девяносто ";
                    break;
            }

             switch (units)
            {
                case 1:
                    NumberText += "один";
                    break;
                case 2:
                    NumberText += "два";
                    break;
                case 3:
                    NumberText += "три";
                    break;
                case 4:
                    NumberText += "четыре";
                    break;
                case 5:
                    NumberText += "пять";
                    break;
                case 6:
                    NumberText += "шесть";
                    break;
                case 7:
                    NumberText += "семь";
                    break;
                case 8:
                    NumberText += "восемь";
                    break;
                case 9:
                    NumberText += "девять";
                    break;
            }
            return NumberText;
        }
    }
}
