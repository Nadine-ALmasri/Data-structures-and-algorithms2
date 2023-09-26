using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashmap_left_join
{
    public class LeftJoinHash
    {

       public static List<List<string>> LeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            List<List<string>> result = new List<List<string>>();

            foreach (var key in synonyms.Keys)
            {
                List<string> word = new List<string>();
                word.Add(key);
                word.Add(synonyms[key]);

                if (antonyms.ContainsKey(key))
                {
                   word.Add(antonyms[key]);
                }
                else
                {
                    word.Add(null); // If no antonym exists, add null
                }

                result.Add(word);
            }

            return result;
        }
    }
}
