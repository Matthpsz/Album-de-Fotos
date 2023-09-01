using System.Windows.Forms;

namespace Album_de_Fotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

  
    }
}