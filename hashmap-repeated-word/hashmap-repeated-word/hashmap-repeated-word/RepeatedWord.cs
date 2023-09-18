using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hashmap_repeated_word
{
    public class RepeatedWord
    {
        public static string FindFirstRepeatedWord(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            string[] words = Regex.Split(input.ToLower(), @"\W+");

            HashSet<string> reapeted = new HashSet<string>();

            foreach (string word in words)
            {
                if (!reapeted.Add(word))
                {
                    return word;
                }
            }

            return null;
        }

    }
}
