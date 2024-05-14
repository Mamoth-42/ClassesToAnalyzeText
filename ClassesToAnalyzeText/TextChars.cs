using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesToAnalyzeText
{
    public class TextChars
    {
        Dictionary<char, int> stats;
        public string Analysis(string input, bool IgnoreCase)
        {
            if (IgnoreCase)
                input = input.ToLower();
            string output = "";
            stats = new Dictionary<char, int>();
            char[] inputChars = input.ToCharArray();
            foreach(char temp in inputChars) 
            { 
                if (stats.TryGetValue(temp, out int count))
                {
                    stats[temp] = count + 1;
                }
                else
                {
                    stats[temp] = 1;
                }
            }
            foreach(var temp in stats.OrderByDescending(i => i.Value))
            {
                output = output + temp.Key + " " + temp.Value + "\n";
            }
            return output;
        }
    }
}
