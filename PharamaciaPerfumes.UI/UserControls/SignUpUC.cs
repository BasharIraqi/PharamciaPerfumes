using PharamaciaEntities;
using Users;

namespace PharamaciaPerfumes.UI.UserControls
{
    public partial class SignUpUC : UserControl
    {
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
            using (var db = new PharamaciaPerfumesContext())
            {
                var newUser = new User();
                newUser.UserName = txtUserName.Text;
                newUser.Password = txtPassword.Text;
                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("Your new user saved successfully");
            }
            
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
