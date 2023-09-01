namespace Album_de_Fotos
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
            btnCarregarImagem = new Button();
            pictureBox = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnCarregarImagem
            // 
            btnCarregarImagem.Location = new Point(33, 208);
            btnCarregarImagem.Name = "btnCarregarImagem";
            btnCarregarImagem.Size = new Size(125, 38);
            btnCarregarImagem.TabIndex = 0;
            btnCarregarImagem.Text = "Carregar imagem";
            btnCarregarImagem.UseVisualStyleBackColor = true;
            btnCarregarImagem.Click += btnCarregarImagem_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(23, 30);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(149, 166);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
          
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Album de Fotos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 258);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Controls.Add(btnCarregarImagem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Album de Fotos";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarregarImagem;
        private PictureBox pictureBox;
        private Label label1;
    }
}