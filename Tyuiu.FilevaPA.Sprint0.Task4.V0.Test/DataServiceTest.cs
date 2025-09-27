
using Tyuiu.FilevaPA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.FilevaPA.Sprint0.Task4.V0.Test;



[TestClass]
public sealed class DataServiceTest
{
    public object DataSercive { get; private set; }

    [TestMethod]
    public void CheckedAdditonValid()
    {
        Assert.AreEqual(10, DataService.Addition(5, 5));
    }
    [TestMethod]
    public void CheckedRemoveitonValid()

    {
        Assert.AreEqual(5, DataSercive.Subtraction(10, 5)); 
    }

    [TestMethod]
    public void CheckedMultiplicationValid()
    {
        Assert.AreEqual(50, DataService.Multiplication(10, 5));
    }
    [TestMethod]
    public void CheckedDivisionValid()
    {
        Assert.AreEqual(3, DataService.Division(9, 3));
    }
}





