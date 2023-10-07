namespace graph_business_trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> graph = new Dictionary<string, Dictionary<string, int>>()
        {
            {"Metroville", new Dictionary<string, int>() {{"Pandora", 82}, {"Narnia", 37}, { "Naboo", 26},{"Arendelle", 99},{"New Monstropolis", 105}}},
            {"Pandora", new Dictionary<string, int>() {{"Metroville", 82}, {"Arendelle", 150}}},
            {"Arendelle", new Dictionary<string, int>() {{"Pandora", 150}, {"New Monstropolis", 42}, {"Naboo", 26}}},
            {"New Monstropolis", new Dictionary<string, int>() {{"Arendelle", 42}, { "Naboo", 73}}},
            {"Naboo", new Dictionary<string, int>() {{"Arendelle", 26},{"Metroville", 73}, {"Narnia", 250}}},
            {"Narnia", new Dictionary<string, int>() {{"Metroville", 37}, {"Naboo", 250}}}
        };

            string[] cityNames1 = { "Metroville", "Pandora" };
            int? tripCost1 = BusinessTrip.BusinesTrip(graph, cityNames1);
            Console.WriteLine("Trip Cost 1: $" + (tripCost1.HasValue ? tripCost1.ToString() : "null"));

            string[] cityNames2 = { "Arendelle", "New Monstropolis", "Naboo" };
            int? tripCost2 = BusinessTrip.BusinesTrip(graph, cityNames2);
            Console.WriteLine("Trip Cost 2: $" + (tripCost2.HasValue ? tripCost2.ToString() : "null"));

            string[] cityNames3 = { "Naboo", "Pandora" };
            int? tripCost3 = BusinessTrip.BusinesTrip(graph, cityNames3);
            Console.WriteLine("Trip Cost 3: " + (tripCost3.HasValue ? "$" + tripCost3.ToString() : "null"));

            string[] cityNames4 = { "Narnia", "Arendelle", "Naboo" };
            int? tripCost4 = BusinessTrip.BusinesTrip(graph, cityNames4);
            Console.WriteLine("Trip Cost 4: " + (tripCost4.HasValue ? "$" + tripCost4.ToString() : "null"));
        }
    }
}