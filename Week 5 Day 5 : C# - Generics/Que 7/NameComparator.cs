using System.Collections.Generic;

namespace IComparerSolution
{
    public class NameComparator : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
