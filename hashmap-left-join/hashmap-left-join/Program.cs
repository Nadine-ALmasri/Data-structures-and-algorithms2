using hashmap_left_join;
namespace hashmap_left_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            {"diligent", "employed"},
            {"fond", "enamored"},
            {"guide", "usher"},
            {"outfit", "garb"},
            {"wrath", "anger"}
        };

            Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            {"diligent", "idle"},
            {"fond", "averse"},
            {"guide", "follow"},
            {"flow", "jam"},
            {"wrath", "delight"}
        };

            List<List<string>> result = LeftJoinHash.LeftJoin(synonyms, antonyms);

            // Print the result
            foreach (var row in result)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
    }
}