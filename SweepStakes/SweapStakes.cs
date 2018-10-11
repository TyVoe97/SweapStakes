using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweapStakes
    {
        Dictionary<int, Contestant> contestant = new Dictionary<int, Contestant>();
        int contestantCounter = 0;
        
        public SweapStakes(string name)
        {
           
            
            
           
        }
        public void RegisteredContestant(Contestant contestant)
        {
            contestant = UserInterface.GetUserInput(contestant);
            contestant.regNums = contestantCounter;
            Contestants.Add(contestantCounter, contestant);
            contestantCounter++;
           
        }
        public string PickWinner()
        {
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {
           
            dictionaryContestant.Add(contestant);
        }
    }
}
