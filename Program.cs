using System.Threading.Channels;

namespace practice_18april
{
  internal class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int x, y;
        Console.WriteLine("enter two numbers: ");
        Console.WriteLine();
        Console.Write("enter x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter y: ");
        y = Convert.ToInt32(Console.ReadLine());

        int z = x + y;
        Console.WriteLine("x addition with y is : " + z);

      }
      catch (Exception e) {
        Console.WriteLine( e.Message);
      }
      finally
      {
        Console.WriteLine("program ended here");
      }
      Console.ReadLine();
    }
  }
}
