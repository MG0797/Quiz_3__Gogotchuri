using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        private string[] subjects;

        public Teacher(string firstName, string lastName, string[] subjects)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subjects = subjects;
        }

        public string [] Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                if (value.Length > 3)
                {
                    throw new Exception("Maximum Number of Subjects = 3");
                }
                else
                {
                    subjects = value;
                }
            }
        }
        public void NameAndSurname()
        {
            Console.WriteLine($"Name: {firstName} \n Surname: {lastName}");
        }

    }
}
