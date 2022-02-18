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
        public static User saveUser=User.GetUser();

        private void btnSign_Click(object sender, EventArgs e)
        {
            saveUser.UserName = txtUserName.Text;
            saveUser.Password = txtPassword.Text;
            using(var db= new PharamaciaPerfumesContext())
            {
               var users=db.Users.ToList();

                if (users.Exists(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text && user.AccessType()=="customer"))
                {
                    OrderUC orderUC = new OrderUC();
                    orderUC.Dock= DockStyle.Fill;
                    this.Controls.Clear();
                    this.Controls.Add(orderUC);
                }
                else if (users.Exists(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text && (user.AccessType()=="manager" || user.AccessType()=="director")))
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