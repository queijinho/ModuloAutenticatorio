namespace ModuloAutenticacao.Desktop
{
    partial class TelaNivel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvNivel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bntAtualizar = new System.Windows.Forms.Button();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(196, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(435, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(196, 177);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 29);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvNivel
            // 
            this.dgvNivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNivel.Location = new System.Drawing.Point(58, 250);
            this.dgvNivel.Name = "dgvNivel";
            this.dgvNivel.Size = new System.Drawing.Size(693, 150);
            this.dgvNivel.TabIndex = 3;
            this.dgvNivel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNivel_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(435, 20);
            this.txtNome.TabIndex = 5;
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.Location = new System.Drawing.Point(438, 177);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(75, 29);
            this.bntAtualizar.TabIndex = 6;
            this.bntAtualizar.Text = "Atualizar";
            this.bntAtualizar.UseVisualStyleBackColor = true;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Location = new System.Drawing.Point(316, 177);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(75, 29);
            this.bntPesquisar.TabIndex = 7;
            this.bntPesquisar.Text = "Pesquisar";
            this.bntPesquisar.UseVisualStyleBackColor = true;
            this.bntPesquisar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(542, 177);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 29);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // TelaNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.bntPesquisar);
            this.Controls.Add(this.bntAtualizar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNivel);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "TelaNivel";
            this.Text = "TelaNivel";
            this.Load += new System.EventHandler(this.TelaNivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button bntAtualizar;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.Button btnExcluir;
    }
}