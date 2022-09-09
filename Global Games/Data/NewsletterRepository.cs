using Global_Games.Data.Entities;

namespace Global_Games.Data
{
    public class NewsletterRepository : GenericRepository<Newsletter>, INewsletterRepository
    {
        public NewsletterRepository(DataContext context) : base(context)
        {
        }
    }
}
