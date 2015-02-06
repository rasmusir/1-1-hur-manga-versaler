using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_1_hur_manga_versaler
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            int count = 0;
            foreach(char c in text)
            {
                count += char.IsUpper(c) ? 1 : 0;
            }
            return count;
        }
    }
}