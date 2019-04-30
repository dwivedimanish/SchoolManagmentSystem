using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private string subject;
        private int age;
        private string gender;
        private Address address;

        public Teacher()
        {
            this.setName();
            this.setSubject();
            this.setAge();
            this.setGender();
            address = new Address();
        }

        private void setName()
        {
            Console.WriteLine("Enter First Name");
            this.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            this.lastName = Console.ReadLine();
            this.fullName = this.firstName + " " + this.lastName;
        }

        public String getName()
        {
            return this.fullName;
        }

        private void setSubject()
        {
            Console.WriteLine("Enter Teaching Subject");
            this.subject = Console.ReadLine();

        }

        public String getSubject()
        {
            return this.subject;
        }

        private void setAge()
        {
            Console.WriteLine("Enter Age");
            this.age = Convert.ToInt32(Console.ReadLine());
        }

        public int getAge()
        {
            return this.age;
        }

        private void setGender()
        {
            Console.WriteLine("Enter Gender");
            this.gender = Console.ReadLine();
        }

        public string getGender()
        {
            return this.gender;
        }

        public void displayTeacherInformation()
        {
            Console.WriteLine("Teacher Name: " + this.getName()
                + "\nSubject : " + this.getSubject()
                + "\nGender : " + this.getGender()
                + "\nAge : " + this.getAge()
                + address.getAddress());
        }
    }
}
