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
        public static int Rcounter { get; set; }
        public CandidateRegistration()
        {
            CandiateName = new List<string>();
            Qualification = new List<string>();
        }
        public CandidateRegistration(bool feesPaid) : this()
        {
            FeesPaid = feesPaid;
        }
        public int RegisterCandidate(Candidate candidateObject)
        {
            if (FeesPaid)
            {
                Rcounter++;
                candidateObject.Qualification = Qualification.ToString();
                candidateObject.CandidateName = CandiateName.ToString();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
