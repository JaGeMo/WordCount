using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public static class UIInput
    {
        private static string result;

        public static string ReturnStringFromInput()
        {
            Console.WriteLine("third try / enter new string to split: ");
            return result = Console.ReadLine();
        }
    }

}
