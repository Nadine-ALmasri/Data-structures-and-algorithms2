namespace hashmap_repeated_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var input = "Why Razor Pages? Razor Pages are presented as a more beginner-friendly " +
                "and lightweight alternative to MVC for web development. " +
                "They are considered suitable for smaller projects where the complexity of controllers " +
                "and models is not necessary.Creating Razor Pages Application";
            string result = RepeatedWord.FindFirstRepeatedWord(input);
                Console.WriteLine(result);

        }

        
    }
}