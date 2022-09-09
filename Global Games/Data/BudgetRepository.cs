using Global_Games.Data.Entities;

namespace Global_Games.Data
{
    public class BudgetRepository : GenericRepository<Budget>, IBudgetRepository
    {
        public BudgetRepository(DataContext context) : base(context)
        {
        }
    }
}
