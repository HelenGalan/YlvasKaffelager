using YlvasKaffelager.DataModels;

namespace YlvasKaffelager
{
    public interface IDbContext
    {
        List<Coffee> Coffees { get; set; }
        List<Order> Orders { get; set; }

        void AddOrder(Order order);
        Coffee GetCoffe(int Id);
    }
}