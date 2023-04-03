using System;

public class User
{
    private string _username;
    private string _email;
    private string _contactNo;

    public User(string _username, string _email, string _contactNo)
    {
        this._username = _username;
        this._email = _email;
        this._contactNo = _contactNo;
    }

    public string Username
    {
        get { return _username; }
        set { _username = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string ContactNo
    {
        get { return _contactNo; }
        set { _contactNo = value; }
    }

    public override string ToString()
    {
        return $"Username : {_username}\nEmail : {_email}\nContact No : {_contactNo}";
    }
}
