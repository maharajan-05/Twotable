using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    public class Assesement
    {
        [Key]
        public int AssesementId { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }

        public ICollection<Candidate> Candidates { get; set; } //Collection navigation prop

    }
}
