using Author.Data;
namespace Author
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var dp = new DataOperations(context);
                dp.AddData();
            }
        }
    }
}
