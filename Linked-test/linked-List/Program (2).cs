namespace LinkedList
{
  public class Program
    {
        static void Main(string[] args)
        {
       List I =new List();
          
            I.Display();
          I.Insert(20);
            I.Insert(30);
            I.Insert(40);
            I.includes(20);
            I.Display();


            bool x =I.includes(20);
            Console.WriteLine(x);
            string y= I.ToString();
            Console.WriteLine(y);
         
        }
    }
}