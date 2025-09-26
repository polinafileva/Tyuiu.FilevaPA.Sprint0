using System.Diagnostics;
using Tyuiu.FilevaPA.Sprinto.Task2.V0.Lib;

namespace TestProjectFilevaPA
{
    [TestClass]
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid



            ()
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
