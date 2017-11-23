using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public static class CountStrings
    {
        private static int result = 0;

        public static int StringsCountFromList(List<string> in_List)
        {
            foreach (string word in in_List)
            {
                result++;
            }

            return result;
        }
    }
}
