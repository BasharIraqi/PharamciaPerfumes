using PharamaciaEntities.Interfaces;

namespace PharamaciaEntities.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(PharamaciaPerfumesContext context) : base(context)
        {
        }

        public Customer GetCustomer(int id)
        {
            return _context.Customers.FirstOrDefault(f=>f.Id==id);
        }
    }
}
