using System.Collections.Generic;

namespace IComparerSolution
{
    public class EmailComparator : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return string.Compare(x.Email, y.Email);
        }
    }
}
