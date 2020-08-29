using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Retestcandidate : Candidate
    {
        public int NoOfRetest { get; set; }
        public Retestcandidate()
        {

        }
        public Retestcandidate(string candidateName,int age,string qualification,int noOfRetest)
        {
                
        }

        public override int EnlistCandidate()
        {
            throw new NotImplementedException();
        }
    }
}
