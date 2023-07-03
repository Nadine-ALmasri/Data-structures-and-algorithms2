namespace LinkedList
{
  public class Program
    {
        static void Main(string[] args)
        {
       LinkedList I =new LinkedList();
            I.append(5);
            I.append(15);
            I.AddFirstList(6);
            I.Display();
          
            I.InsertAfter(3,6);
            I.Display();
       
            I.Insertbefore(4,15);
            I.Display();
            Console.WriteLine("the Kth Method");
            I.KthFromEnd(-1);


          string y= I.ToString();
            Console.WriteLine(y);
         
        }
    }
}