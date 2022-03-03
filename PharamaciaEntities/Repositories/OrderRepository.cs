using PharamaciaEntities.Interfaces;

namespace PharamaciaEntities.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(PharamaciaPerfumesContext context) : base(context)
        {
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        
        public Order ShowOrder(int id)
        {
           return _context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateOrder(Order order)
        {
           _context.Orders.Update(order);
        }
    }
}
