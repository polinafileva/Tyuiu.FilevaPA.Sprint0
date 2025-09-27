namespace Tyuiu.FilevaPA.Sprint0.Task6.V0.Test;
using Tyuiu.FilevaPA.Sprint0.Task6.V0.Lib;



[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
   
        public void CheckAdditionArrayValid()

    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var res = DataService.AdditionArray(numbers);
        Assert.AreEqual(15, res);
    }
}
