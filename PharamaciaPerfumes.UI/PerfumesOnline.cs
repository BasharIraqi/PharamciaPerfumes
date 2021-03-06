using PharamaciaEntities.Repositories;
using PharamaciaPerfumes.UI.UserControls;
using Users;

namespace PharamaciaPerfumes.UI
{
    public partial class PerfumesOnline : Form
    {
        GenericRepository<User> userRepo = new GenericRepository<User>();
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
        public static User saveUser=new User();
        private void btnSign_Click(object sender, EventArgs e)
        {

            saveUser.UserName = txtUserName.Text;
            saveUser.Password = txtPassword.Text;

                var users=userRepo.GetAll().ToList();

            if (users.ToList().Exists(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text && user.AccessType=="general"))
            {
                saveUser.AccessType = "general";
                OrderUC orderUC = new OrderUC();
                orderUC.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(orderUC);
            }
            else if (users.ToList().Exists(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text && user.AccessType == "manager"))
            {
                saveUser.AccessType = "manager";
                EmployeesUC employeesUC = new EmployeesUC();
                employeesUC.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(employeesUC);
            }
            else if (users.ToList().Exists(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text &&  user.AccessType == "director"))
            {
                saveUser.AccessType = "director";
                EmployeesUC employeesUC = new EmployeesUC();
                employeesUC.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(employeesUC);
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password And if you are a new user sign up");
                txtUserName.Text = "User Name";
                txtPassword.Text = "Password";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpUC signUpUC = SignUpUC.GetInstance();
            signUpUC.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(signUpUC);
        }
    }
}