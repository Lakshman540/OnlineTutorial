using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TopPerformer : Candidate
    {
        public int Rank { get; set; }
        public TopPerformer()
        {

        }
        public TopPerformer(string candidateName, int age, string qualification, int rank):base(candidateName,age,qualification)
        {
            Rank = rank;
            CandidateName = candidateName;
            Age = age;
            Qualification = qualification;
        }
        
        public override int EnlistCandidate()
        {
            int PriorityIndex;

            if(Qualification=="BE")
            {
            if(Rank>0 && Rank<=5)
                {
                    PriorityIndex = 9;
                    return 1;
                }
            else
                {
                    PriorityIndex = 8;
                    return 1;
                }
            }
            else if(Qualification == "ME")
            {
                if (Rank > 0 && Rank <= 5)
                {
                    PriorityIndex = 7;
                    return 1;
                }
                else
                {
                    PriorityIndex = 6;
                    return 1;
                }
            }
            else
            {
                try
                {

                }
                catch (InvalidException ex)
                {

                }
                return -1;

            }
        }
    }
}
