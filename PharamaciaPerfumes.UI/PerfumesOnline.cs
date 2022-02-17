using PharamaciaPerfumes.UI.Models;
using Users;

namespace PharamaciaPerfumes.UI
{
    public partial class PerfumesOnline : Form
    {
        public PerfumesOnline()
        {
            InitializeComponent();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            using(var db=new PharamaciaPerfumesContext())
            {
               var users=db.Users.ToList();

                if (users.Exists(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text && user.UserName.Contains("cus")))
                {
                    OrderUC orderUC = new OrderUC();
                    orderUC.Dock= DockStyle.Fill;
                    this.Controls.Clear();
                    this.Controls.Add(orderUC);
                }
                else if (users.Exists(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text && user.UserName.Contains("man")))
                {
                    EmployeesUC employeesUC = new EmployeesUC();
                    employeesUC.Dock= DockStyle.Fill;
                    this.Controls.Clear();
                    this.Controls.Add(employeesUC);
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }

            }
        }
    }
}