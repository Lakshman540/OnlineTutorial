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
        public Retestcandidate(string candidateName,int age,string qualification,int noOfRetest) : base(candidateName,age,qualification)
        {
            NoOfRetest = noOfRetest;
        }

        public override int EnlistCandidate()
        {
            try
            {
                if (NoOfRetest == 1)
                {
                    if (Qualification=="BE")
                    {
                        PriorityIndex = 4;
                        return 1;
                    }
                    else if(Qualification == "ME")
                    {
                        PriorityIndex = 3;
                        return 1;
                    }
                    else
                    {
                        PriorityIndex = 2;
                        return 1;
                    }
                }
                else if (NoOfRetest == 0)
                {
                    if (Qualification == "BE")
                    {
                        PriorityIndex = 5;
                        return 1;
                    }
                    else if (Qualification == "ME")
                    {
                        PriorityIndex = 4;
                        return 1;
                    }
                    else
                    {
                        PriorityIndex = 2;
                        return 1;
                    }
                }
                else
                {
                    throw new InvalidException();
                }
                                   
            }
            catch(InvalidException ex)
            {
                return -1;
            }
            catch(Exception e)
            {
                return -1;
            }
            
        }
    }
}
