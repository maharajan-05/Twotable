using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    public class Candidate
    {
        internal object Assesements;

        [Key]
        public int CandidateId {  get; set; }
        public string CandidateName { get; set; }
        public ICollection<Assesement> Assessments { get; set; }

        

        
        }
    }

