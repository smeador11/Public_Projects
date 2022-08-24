using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingExperience.ListFuncs;

namespace TestingConsoleFunctions
{
    public class ListTests
    {
        static List<int>[] ListTestCases =
        {
            new List<int> { 1, 2, 3, 4, 5 },
            new List<int> { 5, 4, 3, 2, 1 },
            new List<int> { 10, 8, 7, 4, 0 },
        };

        [TestCaseSource(nameof(ListTestCases))]
        public void GetLastItemInList(List<int> list)
        {
            Assert.That(ListUtilities.GetLastItemInList(list), Is.EqualTo(list[list.Count - 1]));
        }
        [TestCaseSource(nameof(ListTestCases))]
        public void GetFirstItemInList(List<int> list)
        {
            Assert.That(ListUtilities.GetFirstItemInList(list), Is.EqualTo(list[0]));
        }
    }
}
