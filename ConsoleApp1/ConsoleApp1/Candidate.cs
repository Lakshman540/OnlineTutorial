using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Candidate
    {
        public static int counter=999;
        public int Age { get; set; }
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public int PriorityIndex { get; set; }
        public string Qualification { get; set; }
        public Candidate()
        {
            CandidateId = ++counter;
        }
        public Candidate(string candidateName,int age,string qualification) : this()
        {
            CandidateName = candidateName;
            Age = age;
            Qualification = qualification;
        }
        public abstract int EnlistCandidate();
    }
}
