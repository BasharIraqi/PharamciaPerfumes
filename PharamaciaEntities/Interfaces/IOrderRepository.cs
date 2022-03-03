namespace PharamaciaEntities.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order ShowOrder(int id);
        void DeleteOrder(Order order);
        void UpdateOrder(Order order);
        void AddOrder(Order order);

        void SaveChanges();

    }
}
