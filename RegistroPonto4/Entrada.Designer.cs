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
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRegistros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 262);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Insira seu ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 258);
            txtId.Name = "txtId";
            txtId.Size = new Size(91, 23);
            txtId.TabIndex = 1;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(14, 44);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(170, 176);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 2;
            pbFoto.TabStop = false;
            // 
            // dgRegistros
            // 
            dgRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRegistros.Location = new Point(190, 44);
            dgRegistros.Name = "dgRegistros";
            dgRegistros.Size = new Size(536, 237);
            dgRegistros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 9);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 4;
            label2.Text = "Registro de Ponto";
            // 
            // btnCarregarImg
            // 
            btnCarregarImg.Location = new Point(14, 226);
            btnCarregarImg.Name = "btnCarregarImg";
            btnCarregarImg.Size = new Size(170, 26);
            btnCarregarImg.TabIndex = 6;
            btnCarregarImg.Text = "Carregar Imagem";
            btnCarregarImg.UseVisualStyleBackColor = true;
            btnCarregarImg.Click += button1_Click;
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 300);
            Controls.Add(btnCarregarImg);
            Controls.Add(label2);
            Controls.Add(dgRegistros);
            Controls.Add(pbFoto);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Entrada";
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
    }
}