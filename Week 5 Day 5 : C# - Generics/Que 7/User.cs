using System;

namespace IComparerSolution
{
    public class User
    {
        private string _name;
        private string _email;
        private string _contactNo;

        public User(string name, string email, string contactNo)
        {
            _name = name;
            _email = email;
            _contactNo = contactNo;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string ContactNo { get { return _contactNo; } set { _contactNo = value; } }

        public override string ToString()
        {
            return string.Format("{0,-15}{1,-20}{2}",_name,_email,_contactNo);
        }
    }
}
