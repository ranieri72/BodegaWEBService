using BodegaAdmin.WebReferenceLocal;
using System;
using System.Windows.Forms;

namespace BodegaAdmin
{
    public partial class FormLogin : Form
    {
        private WebService1 webService;
        private User u;

        public FormLogin()
        {
            InitializeComponent();
            Program.user = null;
            edtPassword.PasswordChar = '*';
            webService = new WebService1();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool error = false;
                u = new User();

                string login = edtLogin.Text;
                if (!login.Equals(""))
                {
                    u.Login = login;
                }
                else
                {
                    error = true;
                }

                string password = edtPassword.Text;
                if (!password.Equals(""))
                {
                    u.Password = password;
                }
                else
                {
                    error = true;
                }

                if (!error)
                {
                    u = webService.CheckLogin(u);
                    if (u != null)
                    {
                        Program.user = u;
                        this.Hide();
                        FormMain formMain = new FormMain();
                        formMain.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha inválidos!");
                    }
                }
                else
                {
                    MessageBox.Show("Campos inválidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante o login." + ex.Message);
            }
        }
    }
}
