using Author;
using Author.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    internal class DataOperations
    {
        private readonly AppDbContext _appDbContext;
        public DataOperations(AppDbContext context)
        {
            _appDbContext = context;
        }

        public void AddData()
        {
            var cand = new Candidate { CandidateName = "Ciril" };
            var ass = new Assesement { Title = "Sql", Score = 80 };
            cand.Assessments= new List<Assesement> { ass };
            _appDbContext.Candidates.Add(cand);
            //_context.Assesements.Add(ass);
            try
            {
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
