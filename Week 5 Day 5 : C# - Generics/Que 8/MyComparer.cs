using System.Collections.Generic;

public class MyComparer : IComparer<User>
{
    public int Compare(User x, User y)
    {
        return x.Username.CompareTo(y.Username);
    }
}
