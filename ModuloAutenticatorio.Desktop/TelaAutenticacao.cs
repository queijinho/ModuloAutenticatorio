using ModuloAutenticatorio.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAutenticatorio.Desktop
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void TelaAutenticacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.Login = txtLogin.Text;
            usuario.Password = txtPassword.Text;

            if (usuario.Login.Equals(""))
            {
                MessageBox.Show("Login Obrigatório!");
                labelLogin.Focus();
            }else if (usuario.Password.Equals(""))
            {
                MessageBox.Show("Senha Obrigatório!");
                labelPassword.Focus();
            }else
            {
                if (usuario.Login != "Senai")
                {
                    MessageBox.Show("Login Incorreto");
                }
                else if (usuario.Password != "123")
                {
                    MessageBox.Show("Senha Incorreta");
                }
                else
                {
                    MessageBox.Show($"Seja bem Vindo {usuario.Login}!");
                    TelaCadUsuario tcu = new TelaCadUsuario();
                    tcu.Show();
                }
            }

        }
    }
}
