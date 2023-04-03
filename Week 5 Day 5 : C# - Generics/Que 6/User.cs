using System;

public class User : IComparable<User>
{
    private string _name;
    private string _add1;
    private string _add2;
    private long _pincode;

    public User(string name, string add1, string add2, long pincode)
    {
        _name = name;
        _add1 = add1;
        _add2 = add2;
        _pincode = pincode;
    }

    public string Name { get { return _name; } }
    public string AddressLine1 { get { return _add1; } }
    public string AddressLine2 { get { return _add2; } }
    public long Pincode { get { return _pincode; } }

    public int CompareTo(User other)
    {
        int pinCodeComparison = this.Pincode.CompareTo(other.Pincode);
        if (pinCodeComparison == 0)
        {
            return this.AddressLine1.CompareTo(other.AddressLine1);
        }
        return pinCodeComparison;
    }

    public override string ToString()
    {
        return string.Format("Name : {0} Address : {1},{2},{3}", 
            this.Name, this.AddressLine1, this.AddressLine2, this.Pincode);
    }
}
