using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naumenko_HW_2_3
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; }
        public Gender Gender { get; set; }

        public User() { }
        public User(string age)
        {
            Age = age;
        }
    }
}
