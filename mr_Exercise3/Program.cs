using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string strValue;
            string strReversed;

            Console.WriteLine("Palindroom checker v.2");

            do
            {
                Console.Write("Voer een woord in: ");
                strValue = Console.ReadLine().ToLower();

                if (strValue != "")
                {
                    strReversed = Reverse(strValue);

                    if (strValue == strReversed)
                    {
                        Console.WriteLine("Palindroom!");
                    }
                    else
                    {
                        Console.WriteLine("Geen Palindroom");
                    }
                }

            } while (strValue != "");

            Console.ReadLine();
        }


        private static string Reverse(string strValue)
        {
            char[] chArray = strValue.ToCharArray();
            Array.Reverse(chArray);
            return new string(chArray);

        }
    }
}
