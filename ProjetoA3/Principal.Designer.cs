namespace ProjetoA3
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Lista Jogos:" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0));
            label1 = new Label();
            btnCadastrar = new Button();
            listView = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(526, 37);
            label1.TabIndex = 0;
            label1.Text = "Minha coleção de jogos de Video-Game";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Indigo;
            btnCadastrar.Location = new Point(683, 402);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 36);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // listView
            // 
            listView.BackColor = SystemColors.Info;
            listView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView.Location = new Point(49, 64);
            listView.Name = "listView";
            listView.Size = new Size(353, 389);
            listView.TabIndex = 2;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(listView);
            Controls.Add(btnCadastrar);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Minha Coleção";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView;
        private Button btnCadastrar;
    }
}
