using System;

public class Hall : IComparable<Hall>
{
    private string _name;
    private long _mobileNumber;
    private string _ownerName;
    private double _costPerDay;

    public Hall(string name, long mobileNumber, string ownerName, double costPerDay)
    {
        _name = name;
        _mobileNumber = mobileNumber;
        _ownerName = ownerName;
        _costPerDay = costPerDay;
    }

    public int CompareTo(Hall other)
    {
        return _costPerDay.CompareTo(other._costPerDay);
    }

    public override string ToString()
    {
        return string.Format("{0,-20} {1,-15} {2,-15} {3,-10}", _name, _mobileNumber, _ownerName, _costPerDay);
    }
}
