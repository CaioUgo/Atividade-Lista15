namespace AtividadeLista15
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnGravar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtID = new TextBox();
            txtProcurar = new TextBox();
            txtNome = new TextBox();
            lblProcurar = new Label();
            lblID = new Label();
            lblNome = new Label();
            DataListaSetores = new Guna.UI2.WinForms.Guna2DataGridView();
            btnListarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)DataListaSetores).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(59, 270);
            btnGravar.Margin = new Padding(2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(78, 20);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(193, 270);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(524, 270);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(78, 20);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(104, 206);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(106, 23);
            txtID.TabIndex = 4;
            // 
            // txtProcurar
            // 
            txtProcurar.Location = new Point(399, 206);
            txtProcurar.Margin = new Padding(2);
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(204, 23);
            txtProcurar.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(204, 29);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(212, 23);
            txtNome.TabIndex = 6;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // lblProcurar
            // 
            lblProcurar.AutoSize = true;
            lblProcurar.Location = new Point(59, 31);
            lblProcurar.Margin = new Padding(2, 0, 2, 0);
            lblProcurar.Name = "lblProcurar";
            lblProcurar.Size = new Size(131, 15);
            lblProcurar.TabIndex = 7;
            lblProcurar.Text = "Digite o nome do setor:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(59, 210);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 8;
            lblID.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(349, 210);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.RightToLeft = RightToLeft.No;
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome:";
            // 
            // DataListaSetores
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataListaSetores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataListaSetores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataListaSetores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataListaSetores.ColumnHeadersHeight = 4;
            DataListaSetores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataListaSetores.DefaultCellStyle = dataGridViewCellStyle3;
            DataListaSetores.GridColor = Color.FromArgb(231, 229, 255);
            DataListaSetores.Location = new Point(66, 61);
            DataListaSetores.Margin = new Padding(2);
            DataListaSetores.Name = "DataListaSetores";
            DataListaSetores.RowHeadersVisible = false;
            DataListaSetores.RowHeadersWidth = 62;
            DataListaSetores.RowTemplate.Height = 33;
            DataListaSetores.Size = new Size(536, 135);
            DataListaSetores.TabIndex = 10;
            DataListaSetores.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataListaSetores.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataListaSetores.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataListaSetores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataListaSetores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataListaSetores.ThemeStyle.BackColor = Color.White;
            DataListaSetores.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataListaSetores.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataListaSetores.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataListaSetores.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DataListaSetores.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataListaSetores.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataListaSetores.ThemeStyle.HeaderStyle.Height = 4;
            DataListaSetores.ThemeStyle.ReadOnly = false;
            DataListaSetores.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataListaSetores.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataListaSetores.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DataListaSetores.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataListaSetores.ThemeStyle.RowsStyle.Height = 33;
            DataListaSetores.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataListaSetores.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataListaSetores.CellContentClick += DataListaSetores_CellContentClick;
            // 
            // btnListarTodos
            // 
            btnListarTodos.Location = new Point(399, 270);
            btnListarTodos.Margin = new Padding(2);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new Size(78, 20);
            btnListarTodos.TabIndex = 11;
            btnListarTodos.Text = "Listar Todos";
            btnListarTodos.UseVisualStyleBackColor = true;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 309);
            Controls.Add(btnListarTodos);
            Controls.Add(DataListaSetores);
            Controls.Add(txtProcurar);
            Controls.Add(lblNome);
            Controls.Add(lblID);
            Controls.Add(lblProcurar);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataListaSetores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtID;
        private TextBox txtProcurar;
        private TextBox txtNome;
        private Label lblProcurar;
        private Label lblID;
        private Label lblNome;
        public Guna.UI2.WinForms.Guna2DataGridView DataListaSetores;
        private Button btnListarTodos;
    }
}
