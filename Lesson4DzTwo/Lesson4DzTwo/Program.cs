namespace Lesson4DzTwo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Двузначные числа, кратные 5: ");
      for (int i = 10; i < 100; i += 5)
      {
        Console.Write($" {i}");
      }
      Console.Write(".");
      Console.WriteLine("\nДля завершения программы нажмите <Enter>");
      Console.ReadLine();
    }
  }
}
