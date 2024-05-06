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
        public int Age { get; } = 0;
        public Gender Gender { get; set; }

        public User() { }
        public User(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append($"Hi, my name is {FirstName} and last name {LastName}. ");
            result.Append(Age >= 10 ? $"I am {Age} years old. " : "I am a baby. ");

            if(Gender != Gender.Unknown)
            {
                result.Append($"I am {Gender}.");
            }
            return result.ToString();
        }
    }
}
