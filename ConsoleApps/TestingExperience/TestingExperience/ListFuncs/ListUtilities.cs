using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExperience.ListFuncs
{
    public class ListUtilities
    {
        public static int GetLastItemInList(List<int> list)
        {
            return list[list.Count - 1];
        }
        public static int GetFirstItemInList(List<int> list)
        {
            return list[0];
        }
    }
}
