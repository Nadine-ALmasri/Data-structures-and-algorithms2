namespace LinkedList
{
  public class Program
    {
        static void Main(string[] args)
        {
       List I =new List();
            I.append(5);
            I.append(15);
            I.AddFirstList(6);
            I.Display();
          
            I.InsertAfter(3,6);
            I.Display();
       
            I.Insertbefore(4,15);
            I.Display();
     
      
          string y= I.ToString();
            Console.WriteLine(y);
         
        }
    }
}