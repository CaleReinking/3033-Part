using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public string done { get; set; }
        public Student()
           {
            
           }
        public Student(string firstName, string lastName, string major, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = Convert.ToDouble(gpa);
        }
        public override string ToString()
        {
            string output = $"{FirstName}, {LastName}, {Major}, {GPA}";
            return output;
        }
        public override string ToString(Student)
        {
            string outputs = $"{FirstName}, {LastName}";
            return outputs;
        }
        public string CalculateDistinction(double Gpa)
        {
            string Distinction = "";
            if (Gpa>=4.0)
            {

            }
            return Distinction;
        }
    }
    class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public Address()
        {

        }
        public Address(int streetnumber, string streetname, string state, string city, int zipcode)
        {
            StreetNumber = streetnumber;
            StreetName = streetname;
            State = state;
            City = city;
            Zipcode = zipcode;

            
        }
        public override string ToString()
        {
            
            string full = $"{StreetNumber}, {StreetName}, {State}, {City}, {Zipcode}";
            return full;
        }
    }
}
