using PharamaciaEntities;
using PharamaciaEntities.Repositories;
using System.Data;

namespace PharamaciaPerfumes.UI
{
    public partial class CustomersUC : UserControl
    {
        GenericRepository<Customer> customerRepo =new GenericRepository<Customer>();
        GenericRepository<Order> orderRepo= new GenericRepository<Order>();
        GenericRepository<Product> productRepo= new GenericRepository<Product>();
        public CustomersUC()
        {
            InitializeComponent();

           var get= customerRepo.GetAll();
            dgvShow.DataSource = get;
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            txtId.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var find= customerRepo.GetById(int.Parse(txtId.Text));
            if (find != null)
            {
                var orders=orderRepo.GetAll().Where(w => w.CustomerId == find.Id).Select(s => new { s.Id, s.CustomerId, s.PreparationDate, s.ResieveDate, s.PaymentValue,
                    s.NumberOfProducts, s.NumberOfPackages }).ToList();
                dgvOrder.DataSource = orders;
            }
            else 
                MessageBox.Show("Wrong customer id or not found try again");
        }

        private void txtorderid_Click(object sender, EventArgs e)
        {
            txtorderid.Clear();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            var find = orderRepo.GetById(int.Parse(txtorderid.Text));

            if (find != null)
            {
                var products = productRepo.GetAll().Where(w => w.OrderId == find.Id).Select(s => new { s.Id, s.Name, s.Stock, s.Price }).ToList();

                dgvProducts.DataSource = products;

            }
            else 
                MessageBox.Show("Wrong order id or not found try again");
        }
    }
}
