using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CandidateRegistration
    {
        public List<string> CandiateName { get; set;}
        public bool FeesPaid { get; set; }
        public int NoOfStudents { get; set; }
        public List<string> Qualification { get; set; }
        public int Rcounter { get; set; }
        public CandidateRegistration()
        {
                
        }
        public CandidateRegistration(bool feesPaid)
        {

        }
        public int RegisterCandidate(Candidate candidateObject)
        {
            return 0;
        }
    }
}
