using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharamaciaEntities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public int NumberOfProducts { get; set; }
        public int PaymentValue { get; set; }
        public DateTime PreparationDate { get; set; }
        public DateTime ResieveDate { get; set; }
        public int NumberOfPackages { get; set; }
        public List<Product> Products { get; set; }

    }
}
