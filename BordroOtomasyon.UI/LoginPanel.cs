using BordroOtomasyon.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordroOtomasyon.UI
{
    public partial class LoginPanel : Form
    {
        private readonly AppDbContext _context;
        public LoginPanel(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var admin = _context.Users
                .FirstOrDefault(u => u.Email == email && u.PasswordHash == password);

            if (admin != null)
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız giriş denemesi");

                adminPanel adminPanel = new adminPanel();
                adminPanel.Show();

                this.Hide();

            }
        }
    }
}
