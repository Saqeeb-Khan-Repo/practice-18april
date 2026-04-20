//exeption handling example
using System;

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
  Console.WriteLine(e.Message);
}

      finally
      {
  Console.WriteLine("program ended here");
}
Console.ReadLine();
    }
  }
}

//delegation single and multicast example

class test
{
  public void p1()
  {
    Console.WriteLine(" p1 method ");
  }
  public void p2()
  {
    Console.WriteLine(" p2 method ");
  }
}
public delegate void dname();
class program
{
  public static void Main(string[] args)
  {
    test t1 = new test();
    dname d1, d2, d3, d4, d5, d6;

    d1 = new dname(t1.p1);
    d1();
    d2 = new dname(t1.p2);
    d2();

    d3 = d1 + d2;
    Console.WriteLine("from d3");
    d3();

    d4 = d2 + d3;
    Console.WriteLine("from d4");
    d4();

    d5 = d3 + d4;
    Console.WriteLine("from d5");
    d5();

    d6 = d4 + d5;
    Console.WriteLine("from d6");
    d6();

  }
}

    //multithreading
    using System.Threading;
class multithreding{
  class test
{
  public void p1()
  {
    for (int i = 0; i <= 10; i++)
    {
      Console.WriteLine(i + " ");
      Thread.Sleep(500);
    }
  }
    public void p2()
    {
      for (int i = 11; i < 20; i++)
      {
        Console.WriteLine(i + " ");
        Thread.Sleep(500);
      }
    }
  }
class text
{
  public static void Main(string[] args)
  {
      test p = new test();
      ThreadStart ts1 = new ThreadStart(p.p1);
      ThreadStart ts2 = new ThreadStart(p.p2);
      Thread t1 = new Thread(ts1);
      Thread t2 = new Thread(ts2);
      t1.Start();
      t2.Start();

      Console.ReadKey();

  }
}
}
