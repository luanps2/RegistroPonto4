namespace RegistroPonto4
{
    partial class Entrada
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
            label1 = new Label();
            txtId = new TextBox();
            pbFoto = new PictureBox();
            dgRegistros = new DataGridView();
            label2 = new Label();
            btnCarregarImg = new Button();
            btnAcessarDir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRegistros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 258);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira seu ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(115, 258);
            txtId.Name = "txtId";
            txtId.Size = new Size(103, 23);
            txtId.TabIndex = 1;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.Fixed3D;
            pbFoto.Location = new Point(14, 44);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(204, 159);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 2;
            pbFoto.TabStop = false;
            // 
            // dgRegistros
            // 
            dgRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRegistros.Location = new Point(224, 44);
            dgRegistros.Name = "dgRegistros";
            dgRegistros.ReadOnly = true;
            dgRegistros.Size = new Size(469, 237);
            dgRegistros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 9);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 4;
            label2.Text = "Registro de Ponto";
            // 
            // btnCarregarImg
            // 
            btnCarregarImg.BackColor = Color.DarkGreen;
            btnCarregarImg.Cursor = Cursors.Hand;
            btnCarregarImg.FlatStyle = FlatStyle.Popup;
            btnCarregarImg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCarregarImg.ForeColor = Color.White;
            btnCarregarImg.Image = Properties.Resources.carregar;
            btnCarregarImg.ImageAlign = ContentAlignment.MiddleRight;
            btnCarregarImg.Location = new Point(14, 209);
            btnCarregarImg.Name = "btnCarregarImg";
            btnCarregarImg.Size = new Size(95, 43);
            btnCarregarImg.TabIndex = 6;
            btnCarregarImg.Text = "Carregar Imagem";
            btnCarregarImg.TextAlign = ContentAlignment.MiddleLeft;
            btnCarregarImg.UseVisualStyleBackColor = false;
            btnCarregarImg.Click += button1_Click;
            // 
            // btnAcessarDir
            // 
            btnAcessarDir.BackColor = Color.Olive;
            btnAcessarDir.Cursor = Cursors.Hand;
            btnAcessarDir.FlatStyle = FlatStyle.Popup;
            btnAcessarDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAcessarDir.ForeColor = Color.White;
            btnAcessarDir.Image = Properties.Resources.pasta;
            btnAcessarDir.ImageAlign = ContentAlignment.MiddleRight;
            btnAcessarDir.Location = new Point(115, 209);
            btnAcessarDir.Name = "btnAcessarDir";
            btnAcessarDir.Size = new Size(103, 43);
            btnAcessarDir.TabIndex = 7;
            btnAcessarDir.Text = "Acessar Diretório";
            btnAcessarDir.TextAlign = ContentAlignment.MiddleLeft;
            btnAcessarDir.UseVisualStyleBackColor = false;
            btnAcessarDir.Click += button1_Click_1;
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 300);
            Controls.Add(btnAcessarDir);
            Controls.Add(btnCarregarImg);
            Controls.Add(label2);
            Controls.Add(dgRegistros);
            Controls.Add(pbFoto);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Entrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada";
            Load += Entrada_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private PictureBox pbFoto;
        private DataGridView dgRegistros;
        private Label label2;
        private Button btnCarregarImg;
        private Button btnAcessarDir;
    }
}