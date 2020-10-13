using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes_3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address address { get; set; }
        
        public Student()
        {

        }
        public Student(string first, string last, string major, double gpa, Address addy)
        {
            FirstName = first;
            LastName = last;
            Major = major;
            GPA = gpa;
        }

        public string CalculateDistinction()
        {
            if (GPA > 3.8)
            {
                return "Summa Cum Laude";
            }
            else if (GPA > 3.6)
            {
                return "Magna Cum Laude";
            }
            else if (GPA > 3.4)
            {
                return "Cum Laude";
            }
            else
            {
                return "";
            }
        }

        public string ToString()
        {
            return FirstName + " " + LastName + "\nMajor: " + Major;
        }
    }
}
