using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Input: ");
            string str = Convert.ToString(Console.ReadLine());
             Console.WriteLine(Trim(str));
            Console.WriteLine(Trim1(result));

        }
        /// <summary>
        /// Sozun evvelinden bosluqlarin silinmesi
        /// </summary>
        /// <param name="str">istenilen sozu alir</param>
        /// <returns>evveldn bosluqlari silinmis soz</returns>
        static string Trim(string str)
        {
            bool check=false;
            string result = string.Empty;
          //  StringBuilder result = new StringBuilder();         
            for (int i = 0; i <str.Length-1; i++)
            {
                if (str[i]!=' ')
                {
                    check = true;
                   
                }
                if(check)
                {
                    result += str[i];
                }
            }
            return result;
        }
        static string Trim1(string result)
        {
            bool check = false;
            string result1 = string.Empty;
            //  StringBuilder result = new StringBuilder();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (result[i] != ' ')
                {
                    check = true;
                }
                if (check)
                {
                    result1 += result[i];
                }
            }
            return result1;
        }
    }
}
