using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringTrim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Input:");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Included Word Length:{str.Length}");

            Console.WriteLine(Trim(str));
            Console.WriteLine((Trim(str)).Length);
          //  Console.WriteLine($"The length of the trimmed word:{Trim(str)).Length}");
            
        }
        /// <summary>
        /// Delete the space from the beginning of the word
        /// </summary>
        /// <param name="str">Accepts a string type word or sentence.</param>
        /// <returns>A word with spaces removed from the beginning of the word.</returns>
        static string TrimBegin(string str)
        {
            bool check = false;
            StringBuilder begin = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    check = true;
                }
                if (check)
                {
                    begin.Append(str[i]);
                }
            }
            return begin.ToString();
        }
        /// <summary>
        /// Deletes spaces at the end of a word or sentence.
        /// </summary>
        /// <param name="result">A word returned in string type in the Trim1 method</param>
        /// <returns>A word with spaces removed from the end of the word</returns>
        static string TrimEnd(string result)
        {
            bool check = false;
            StringBuilder end = new StringBuilder();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (result[i] != ' ')
                {
                    check = true;
                }
                if (check)
                {
                    end.Append(result[i]);
                }
            }
            //for (int i = 0; i < result.Length; i++)
            //{
            //    end.Append(result[i]);
            //}
            return end.ToString();
        }
        static string Trim(string str)
        {
            string result = string.Empty;
            result = TrimBegin(str);
            result = TrimEnd(result);
            return result.ToString();
        }
    }

}