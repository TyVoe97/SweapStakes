using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweapStakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        int contestantCounter = 0;
        
        public SweapStakes(string name)
        {
            Contestant contestant = new Contestant()
            {
                
            };
            

            
               
            



        }
        public void RegisteredContestant(Contestant contestant)
        {
            //contestant = UserInterface.GetUserInput(contestant);
            contestant.regNums = contestantCounter;
            contestants.Add(contestantCounter, contestant);
            contestantCounter++;
           
        }
        public string PickWinner()
        {
            Random random = new Random();
            int IndexOfWinner = random.Next(0, contestantCounter);
            return contestants[IndexOfWinner].firstName;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine( contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.email);
            Console.WriteLine( contestant.regNums);
        }
    }
}
