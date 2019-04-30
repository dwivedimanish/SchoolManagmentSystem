using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Address
    {
        private string firstLine;
        private string secondLine;
        private string landMark;
        private long zipCode;
        private string completeAddress;

        public Address()
        {
            this.setAddress();
        }

        private void setAddress()
        {
            Console.WriteLine("Enter Address Line 1");
            this.firstLine = Console.ReadLine();
            Console.WriteLine("Enter Address Line 2");
            this.secondLine = Console.ReadLine();
            Console.WriteLine("Enter Landmark");
            this.landMark = Console.ReadLine();
            Console.WriteLine("Enter ZipCode");
            this.zipCode = Convert.ToInt64(Console.ReadLine());
            this.completeAddress = "Address : " + this.firstLine
                + "\n" + this.secondLine
                + "\n" + this.landMark
                + "\n" + this.zipCode;
        }

        public string getAddress()
        {
            return this.completeAddress;
        }
    }
}
