using ModuloAutenticacao.Desktop;
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
    public partial class TelaCadUsuario : Form
    {


        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtLogin.Enabled = false;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            txtLogin.Text = "O leave foi acionado";
            txtLogin.BackColor = Color.BlueViolet;

            txtLogin.Text = txtNome.Text;
            txtLogin.BackColor = Color.White;
            
            //Clever
            string[] nome = txtNome.Text.Split(' ');
            //txtLogin.Text = nome[0];
            //Yedo
            string substring = "";
            string[] subs = txtSobrenome.Text.Split();
            foreach (string sub in subs)
            {
                //  MessageBox.Show($"Substring: {sub}");
                substring = sub;
            }
            //===================
            txtLogin.Text = $"{nome[0].ToLower()}.{substring.ToLower()}";
                        
        }

        private void txtSenhaUsuario1_Leave(object sender, EventArgs e)
        {
           
        }

        private void labelConfirmarSenha_Leave(object sender, EventArgs e)
        {
            string senhaUsuarioa1 = txtSenhaUsuario1.Text, senhaUsuario2 = txtConfirmarSenhaUsuario.Text;
            if (senhaUsuarioa1 != senhaUsuario2)
            {
                MessageBox.Show("Senhas diferentes");
                labelSenha.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TelaNivel().Show();
        }
    }
}
