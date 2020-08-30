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
        }
        
        public override int EnlistCandidate()
        {
           try
           {                             
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
                    throw new InvalidException();
                }
              
                
           }
           catch (InvalidException ex)
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
