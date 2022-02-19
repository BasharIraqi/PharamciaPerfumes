using PharamaciaPerfumes.UI.Models;
using System.Data;

namespace PharamaciaPerfumes.UI
{
    public partial class CustomersUC : UserControl
    {
        public CustomersUC()
        {
            InitializeComponent();
            using (var db = new PharamaciaPerfumesContext())
            {
                var show = db.Customers.Select(s => new { s.Id, s.FirstName, s.LastName, s.PhoneNumber, s.Email, s.Address, s.CreditCardNumber }).ToList();
                dgvShow.DataSource = show;
            }
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            txtId.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (var db = new PharamaciaPerfumesContext())
            {
                var find = db.Customers.Find(int.Parse(txtId.Text));

                var orders = db.Orders.Where(w => w.CustomerId == find.Id).Select(s => new { s.Id, s.CustomerId, s.PreparationDate, s.ResieveDate, s.PaymentValue, s.NumberOfProducts, s.NumberOfPackages }).ToList();
                dgvOrder.DataSource = orders;
            }
        }

        private void txtorderid_Click(object sender, EventArgs e)
        {
            txtorderid.Clear();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            using (var db = new PharamaciaPerfumesContext())
            {
                var find = db.Orders.Find(int.Parse(txtorderid.Text));

                var products = db.Products.Where(w => w.OrderId == find.Id).Select(s => new { s.Id, s.Name, s.Stock, s.Price }).ToList();

                dgvProducts.DataSource = products;
            }
        }
    }
}
