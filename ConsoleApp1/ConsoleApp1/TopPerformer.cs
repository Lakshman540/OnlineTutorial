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
        public TopPerformer(string candidateName, int age, string qualification, int rank)
        {

        }
        public override int EnlistCandidate()
        {
            throw new NotImplementedException();
        }
    }
}
