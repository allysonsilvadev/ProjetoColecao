namespace ProjetoA3
{
    partial class Cadastro
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
            lblTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtTempo = new TextBox();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            pictureBox = new PictureBox();
            btnCarregar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(327, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Novo Jogo Cadastrado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do Jogo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(18, 118);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço do jogo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(16, 146);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Horas Jogadas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(48, 188);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Imagem:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(108, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(261, 23);
            txtNome.TabIndex = 5;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(108, 117);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(261, 23);
            txtPreco.TabIndex = 6;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(108, 146);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(261, 23);
            txtTempo.TabIndex = 7;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Black;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Red;
            btnExcluir.Location = new Point(680, 23);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 34);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(262, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(89, 400);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(108, 223);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(261, 171);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 11;
            pictureBox.TabStop = false;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(108, 184);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(97, 23);
            btnCarregar.TabIndex = 12;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarregar);
            Controls.Add(pictureBox);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(txtTempo);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            ForeColor = Color.Black;
            Name = "Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtTempo;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private PictureBox pictureBox;
        private Button btnCarregar;
    }
}