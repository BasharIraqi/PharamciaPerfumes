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
            newUser.UserName = txtUserName.Text;
            newUser.Password = txtPassword.Text;
            var findUser = userRepo.GetAll().Where(w => w.UserName == txtUserName.Text && w.Password == txtPassword.Text);

            if(findUser==null)
            {
            userRepo.Add(newUser);
            userRepo.Save();
            MessageBox.Show("Your new user saved successfully");
            }
            else
            {
                MessageBox.Show("User Already Exist Try Another one");
            }


            PerfumesOnline.ActiveForm.Hide();
            PerfumesOnline perfumesOnline = new PerfumesOnline();
            perfumesOnline.ShowDialog();   
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtUserName.Text = "cus ";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
