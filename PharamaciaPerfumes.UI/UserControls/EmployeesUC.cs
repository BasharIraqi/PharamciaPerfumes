using PharamaciaPerfumes.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
