namespace PharamaciaPerfumes.UI
{
    public partial class EmployeesUC : UserControl
    {
        public EmployeesUC()
        {
            InitializeComponent();
            
            if(PerfumesOnline.saveUser.AccessType()=="manager")
            {
                btnCustomer.Enabled= true;
                btnOrders.Enabled= false;
            }
            else if (PerfumesOnline.saveUser.AccessType() =="director")
            {
                btnCustomer.Enabled = true;
                btnOrders.Enabled = true;
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomersUC customersUC = new CustomersUC();
            customersUC.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(customersUC);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderUC orderUC = new OrderUC();
            orderUC.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(orderUC);
        }
    }
}
