using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;
using ModuloAuteticacao.Classes;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //método(ações do objeto) de instancia
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidades();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Atualizar(txtNome.Text, txtId.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Deletar(txtId.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {


            txtId.Enabled = false;
            CarregarResponsabilidades();
            
        }

        private void CarregarResponsabilidades()
        {
            NivelDAO nivelPesquisa = new NivelDAO();

            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }

        private void dgvNivel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.PesquisarPorNome(txtNome.Text);
            if (txtNome.Text.Equals("")){
                CarregarResponsabilidades();
                txtNome.Clear();
            }
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}