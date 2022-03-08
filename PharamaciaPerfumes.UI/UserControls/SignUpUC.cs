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
            userRepo.Add(newUser);
            userRepo.Save();
            MessageBox.Show("Your new user saved successfully");

            PerfumesOnline.ActiveForm.Hide();
            PerfumesOnline perfumesOnline = new PerfumesOnline();
            perfumesOnline.ShowDialog();   
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
