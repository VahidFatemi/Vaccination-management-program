using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    [Serializable]
    public class Person
    {
        private long _id;
        private string _gender;
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person( long id, string firstName, string lastName, int age, string gender)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _gender = gender;
        }
        public long GetId()
        {
            return _id;
        }
    }
}
