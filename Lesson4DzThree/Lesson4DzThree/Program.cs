namespace Lesson4DzThree
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Последовательность отрицательных чисел:");
      int i = -20;
      do
      {
        Console.WriteLine(i);
        i -= 20;
      }
      while (i >= -100);
      Console.WriteLine("\nДля завершения программы нажмите <Enter>");
      Console.ReadLine();
    }
  }
}
