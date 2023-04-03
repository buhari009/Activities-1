using System.Collections.Generic;

public class Stall
{
    private string _name;
    private string _owner;
    private string _detail;

    public static List<Stall> StallList = new List<Stall>();

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Owner
    {
        get { return _owner; }
        set { _owner = value; }
    }

    public string Detail
    {
        get { return _detail; }
        set { _detail = value; }
    }

    public Stall(string name, string owner, string detail)
    {
        _name = name;
        _owner = owner;
        _detail = detail;
    }

    public override string ToString()
    {
        return $"Name : {_name}\nOwner : {_owner}\nDetails : {_detail}";
    }
}
