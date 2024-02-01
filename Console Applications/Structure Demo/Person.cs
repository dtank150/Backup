using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Demo
{
    struct Person
    {
        private int _personId;
        private string _name;
        private int _salary;

        public Person(int personId)
        {
            _personId = personId;
            _name = string.Empty;
            _salary = 0;
        }
        public Person(int personId, string personName, int salary)
        {
            this._personId = personId;
            this._name = personName;
            this._salary = salary;
        }
        public bool ComparePerson(Person other)
        {
            if (_name.ToLower() == other._name.ToLower()
                && _salary == other._salary 
                && _personId == other._personId)
                return true;

            return false; 
        }
        public void SetPersonId(int personId)
        {
            this._personId = personId;
        }
        public int GetPersonId() { return _personId; }

        public String Name
        {
            get { return _name; }
        }

    }
}
