using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private int age;
        private int rollNumber;
        private string gender;
        private Address address;

        public Student()
        {
            this.setName();
            this.setAge();
            this.setGender();
            this.setRollNumber();
            address = new Address();
        }

        private void setName()
        {
            Console.WriteLine("Enter Student's First Name");
            this.firstName = Console.ReadLine();
            Console.WriteLine("Enter Student's Last Name");
            this.lastName = Console.ReadLine();
            this.fullName = this.firstName + " " + this.lastName;
        }

        public String getName()
        {
            return this.fullName;
        }

        private void setAge()
        {
            Console.WriteLine("Enter Student's Age");
            this.age = Convert.ToInt32(Console.ReadLine());
        }

        public int getAge()
        {
            return this.age;
        }

        private void setRollNumber()
        {
            Console.WriteLine("Enter Student's Roll Number");
            this.rollNumber = Convert.ToInt32(Console.ReadLine());
        }

        public int getRollNumber()
        {
            return this.rollNumber;
        }

        private void setGender()
        {
            Console.WriteLine("Enter Student's Gender");
            this.gender = Console.ReadLine();
        }

        public string getGender()
        {
            return this.gender;
        }

        public void displayStudentInformation()
        {
            Console.WriteLine("Student Name: " + this.getName()
                + "\nRoll Number : " + this.getRollNumber()
                + "\nGender : " + this.getGender()
                + "\nAge : " + this.getAge()
                + address.getAddress());
        }


    }
}
