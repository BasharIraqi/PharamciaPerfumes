namespace PharamaciaEntities.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetCustomer(int id);
    }
}
