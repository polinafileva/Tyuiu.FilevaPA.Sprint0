using Tyuiu.FilevaPA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.FilevaPA.Sprint0.Task6.V0.Test;



public class DataService


{
    //Пример циклической структуры ( цикл с параметрами) for
    public static object AdditionArray(int[] numbers)
    {
        var total = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];

        }
        return total;
    }


    
    


