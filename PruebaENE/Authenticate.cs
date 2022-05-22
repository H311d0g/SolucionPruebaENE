using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PruebaENE
{
    public partial class Authenticate : Form
    {
        public Authenticate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "email" && textBox1.TextLength > 2)
            {
                if (textBox2.Text != "clave")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.UserLogin(textBox1.Text, textBox2.Text);
                    if (validLogin == true)
                    {
                        RegistroRequerimiento form = new RegistroRequerimiento();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("usuario o clave incorrecta");
                    }
                }
            }
        }

        private void Authenticate_Load(object sender, EventArgs e)
        {

        }
    }
}
