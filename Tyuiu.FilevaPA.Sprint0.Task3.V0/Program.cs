
using Tyuiu.FilevaPA.Sprint0.Task3.V0.Lib;
namespace Tyuiu.FilevaPA.Sprint0.Task3.V0;

internal class Program


{
   
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(DataService.Sum(7, 7));
        Console.ReadKey();
    }
}