using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string idNumber;
        private int semester;
        private string[] subjects;
        private double gpa;

        public Student(string firstName, string lastName, string idNumber, int semester, string[] subjects, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idNumber;
            this.semester = semester;
            this.subjects = subjects;
            this.gpa = gpa;
        }


        public double GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value > 35)
                {
                    throw new Exception("GPA is Out of Range");
                    
                }
                else
                {
                    gpa = value;
                }
            }
        }

        public string IDNumber 
        {
            get
            {
                return idNumber;
            }
            set
            {
                if(value.Length == 11)
                {
                    idNumber = value;
                }
                else
                {
                    throw new Exception("Incorrect Format");
                }
            }
        }

        public void NameAndSurname()
        {
            Console.WriteLine($"Name: {firstName} \n Surname: {lastName}");
        }

        public void ListOfSubjects()
        {
            foreach (var s in subjects)
            {
                Console.WriteLine(s);
            }
        }

       

    }
}
