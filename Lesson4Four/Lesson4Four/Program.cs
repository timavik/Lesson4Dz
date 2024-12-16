namespace Lesson4Four
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Используйте английскую расклатку клавитуры");
      Console.Write("Используйте клавиши (W, S, A, D) для перемищения ");

      var repeat = true;

      while (repeat)
      {
        char button = char.ToUpper(Console.ReadKey().KeyChar);
        switch (button)
        {
          case 'W':
            Console.WriteLine("\nВы идёте в перёд");
            break;

          case 'A':
            Console.WriteLine("\nВы идёте в лево");
            break;

          case 'S':
            Console.WriteLine("\nВы идёте в назад");
            break;

          case 'D':
            Console.WriteLine("\nВы идёте в право");
            break;

          default:
            Console.WriteLine("\nВы не здвинулись с места");
            repeat = false;
            break;
        }
      }

      Console.WriteLine("\nДля завершения программы нажмите <Enter>");
      Console.ReadLine();
    }
  }
}
