using PharamaciaEntities;
using PharamaciaEntities.Repositories;
using System.Data;

namespace PharamaciaPerfumes.UI
{
    public partial class OrderUC : UserControl
    {
        GenericRepository<Customer> customerRepo = new GenericRepository<Customer>();
        GenericRepository<Order> orderRepo = new GenericRepository<Order>();
        GenericRepository<Product> productRepo = new GenericRepository<Product>();
        public OrderUC()
        {
            InitializeComponent();
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            UpdatePanel.Visible = false;
            ShowPanel.Visible = false;
        }

        private void txtOrderDId_Click(object sender, EventArgs e)
        {
            txtOrderDId.Clear();
        }

        private void txtOrderUId_Click(object sender, EventArgs e)
        {
            txtOrderUId.Clear();
        }

        private void txtOrderId_Click(object sender, EventArgs e)
        {
            txtOrderId.Clear();
        }
        private void txtAddProduct_Click(object sender, EventArgs e)
        {
            txtAddProduct.Clear();
        }
        private void txtUpdate_Click(object sender, EventArgs e)
        {
            txtUpdate.Clear();
        }
        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            DeletePanel.Visible = false;
            UpdatePanel.Visible = false;
            ShowPanel.Visible = false;
            AddPanel.Dock = DockStyle.Fill;

            var show=productRepo.GetAll().Select(p => new { p.Id, p.Name, p.Price, p.Stock }).ToList();

            foreach (var item in show)
            {
                lbAdd.Items.Add(item);
            }
        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = true;
            UpdatePanel.Visible = false;
            ShowPanel.Visible = false;
            DeletePanel.Dock = DockStyle.Fill;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            UpdatePanel.Visible = true;
            ShowPanel.Visible = false;
            UpdatePanel.Dock = DockStyle.Fill;
            dgvUpdate.Dock = DockStyle.Bottom;

            var show = productRepo.GetAll().Select(p => new { p.Id, p.Name, p.Price, p.Stock }).ToList();

            foreach (var item in show)
            {
                lbAdd.Items.Add(item);
            }
        }

        private void showOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            UpdatePanel.Visible = false;
            ShowPanel.Visible = true;
            ShowPanel.Dock = DockStyle.Fill;
            dgvShow.Dock = DockStyle.Bottom;
        }

        static List<Product> selectProducts = new List<Product>();
        static int sum = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var find=productRepo.GetById(int.Parse(txtAddProduct.Text));

            selectProducts.Add(find);
            sum += selectProducts[selectProducts.Count - 1].Price;

            find.Stock -= 1;
            productRepo.Update(find);
            productRepo.Save();
           
            txtAddProduct.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            order.CustomerId = orderRepo.GetAll().Where(w => w.Customer.Id == w.CustomerId).Select(s => s.Customer.Id).FirstOrDefault();
            order.NumberOfProducts = selectProducts.Count();
            order.NumberOfPackages = new Random().Next(1, order.NumberOfProducts);
            order.PreparationDate = DateTime.Today;
            order.ResieveDate = DateTime.Today.AddDays(3);
            order.PaymentValue = sum;
            orderRepo.Add(order);
            orderRepo.Save();
            MessageBox.Show("Your Order Successfully Addedd -_-");

            order.Products = selectProducts;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var findOrder = orderRepo.GetById(int.Parse(txtOrderDId.Text));

            if (findOrder != null)
            {
                orderRepo.Delete(findOrder);
                orderRepo.Save();
                MessageBox.Show("Your Order Deleted Successfully !!!!!");
            }
            else
            {
                MessageBox.Show("Not Found Yuor Order Try Again");
            }
        }

        private void btnUShow_Click(object sender, EventArgs e)
        {
            var find = orderRepo.GetAll().Where(p => p.Id == int.Parse(txtOrderUId.Text)).Select(s => new
            {
                s.Id,
                s.CustomerId,
                s.NumberOfProducts,
                s.PreparationDate,
                s.ResieveDate,
                s.PaymentValue,
                s.NumberOfPackages
            }).ToList();

            dgvUpdate.DataSource = find;
        }

        List<Product> updateList = selectProducts;
        int updateSum = sum;
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var find=productRepo.GetById(int.Parse(txtUpdate.Text));

            if (find.Stock == 0)
                MessageBox.Show("The Product Dous not Exist In Stock");
            else
            {
                updateList.Add(find);
                updateSum += updateList[updateList.Count - 1].Price;
                find.Stock -= 1;
                productRepo.Update(find);
                productRepo.Save();
                MessageBox.Show("Added Product To Your Order");
            }
            txtAddProduct.Clear();
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            var find = productRepo.GetById(int.Parse(txtUpdate.Text));

            updateList.Remove(find);
            updateSum -= updateList[updateList.Count - 1].Price;
            find.Stock += 1;
            productRepo.Update(find);
            productRepo.Save();
            MessageBox.Show("Remove Product From Your Order");

            txtAddProduct.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var order = orderRepo.GetById(int.Parse(txtOrderUId.Text));

            order.CustomerId = orderRepo.GetAll().Where(w => w.Customer.Id == w.CustomerId).Select(s => s.Customer.Id).FirstOrDefault();
            order.NumberOfProducts = updateList.Count();
            order.NumberOfPackages = new Random().Next(1, order.NumberOfProducts);
            order.PreparationDate = DateTime.Today;
            order.ResieveDate = DateTime.Today.AddDays(3);
            order.PaymentValue = updateSum;

            orderRepo.Update(order);
            orderRepo.Save();
            MessageBox.Show("Your Order Successfully Updated -_-");
            order.Products = updateList;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var find = orderRepo.GetById(int.Parse(txtOrderId.Text));

            if (find != null)
            {
                var show = orderRepo.GetAll().Where(w => w.Id == int.Parse(txtOrderId.Text)).Select(s => new {
                    s.Id,
                    s.CustomerId,
                    s.NumberOfProducts,
                    s.NumberOfPackages,
                    s.PreparationDate,
                    s.PaymentValue,
                    s.ResieveDate
                }).ToList();
                dgvShow.DataSource = show;
            }
            else
            {
                MessageBox.Show("Order Id not Found");
            }
        }
    }
}



