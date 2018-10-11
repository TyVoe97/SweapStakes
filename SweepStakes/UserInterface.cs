using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {

        public static string GetInfo(string newmessage)
        {
            Console.WriteLine(newmessage);
            string info = Console.ReadLine();
            return info;
        }
        

    }
}
