using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6V91MembersAndFinalizersDestructors
{
    public class Members
    {
        // member - private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            
            Console.WriteLine("Member is created.\n");
        }

        // member - property - exposed jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }

            set
            {
                jobTitle = value;
            }
        }

        // public member method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine(
                    $"Hi, my name is {memberName}, and my job title is {jobTitle}.  I am {age} years old.");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // member - finalizer / destructor
        ~Members()
        {
            Console.WriteLine("Destruction of Members object");
            Debug.Write("Members object destructed");
        }
    }
}
