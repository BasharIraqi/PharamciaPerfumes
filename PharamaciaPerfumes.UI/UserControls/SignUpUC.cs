using PharamaciaEntities.Repositories;
using Users;

namespace PharamaciaPerfumes.UI.UserControls
{
    public partial class SignUpUC : UserControl
    {
        GenericRepository<User> userRepo=new GenericRepository<User>();
       
        static object objlock=new object();
        static SignUpUC instance;

        public static SignUpUC GetInstance()
        {
            if (instance == null)
            {
                lock (objlock)
                {
                    if(instance==null)
                        instance = new SignUpUC();
                }
            }
            return instance;
        }
        private SignUpUC()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var newUser = new User();
            if (txtUserName.Text.Length > 10 || txtPassword.Text.Length > 10)
            {
                MessageBox.Show("Your username or password too long");
                txtUserName.Text = "User Name";
                txtPassword.Text = "Password";
            }
            else
            {
                newUser.UserName = txtUserName.Text;
                newUser.Password = txtPassword.Text;
                newUser.AccessType = "general";


                var findUser = userRepo.GetAll().FirstOrDefault(w => w.UserName == txtUserName.Text && w.Password == txtPassword.Text);

                if (findUser != null)
                {
                    MessageBox.Show("User Already Exist Try Another one");
                }
                else
                {
                    userRepo.Add(newUser);
                    userRepo.Save();
                    MessageBox.Show("Your new user saved successfully");
                }



                PerfumesOnline.ActiveForm.Hide();
                PerfumesOnline perfumesOnline = new PerfumesOnline();
                perfumesOnline.ShowDialog();
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

    }
}
