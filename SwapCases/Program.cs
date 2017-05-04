using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapCases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlternateCase("HeLLLLooooo"));
            
        }
        public static string AlternateCase(string s)
        {
            var arr = s.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                    arr[i] = char.ToLower(arr[i]);
                else
                    arr[i] = char.ToUpper(arr[i]);
            }
            string result = new string(arr);
            return result;
        }
    }
}
