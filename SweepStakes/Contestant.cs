using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{

    class Contestant
    {
        // Member Variables
        public string firstName;
        public string lastName;
        public string email;
        public int regNums;

        public Contestant()
        {
        }

        public Contestant(string firstName, string lastName, string email)
        {
            firstName = UserInterface.GetInfo("Please enter your First Name");
            lastName = UserInterface.GetInfo("Please enter your Last Name");
            email = UserInterface.GetInfo(" Please enter your Email");
            

        }
        //public void FirstName()
        //{
        //    if (firstName = GetInfo)
        //    {
        //        Console.WriteLine(firstName);
        //    }
        //}
    }
}
    


