namespace Grapichs_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.InitialDirectory = @"C:\";
            janela.Filter = "Arquivos txt|*.txt|Arquivos jpg|*.jpg|Todos os arquivos|*";

            //Habilitar varios arquivos...
            //janela.Multiselect = true;

            if (janela.ShowDialog() == DialogResult.OK)
            {
                /*
                 * Mostra o caminho de todos os arquivos...
                 * 
                 * string [] locais = janela.FileNames;
                foreach (string localDoArq in locais)
                {
                    MessageBox.Show(localDoArq);
                }*/

                string local = janela.FileName;
                MessageBox.Show(local);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = folderBrowserDialog1.SelectedPath;
                MessageBox.Show(caminho);
            }
        }
    }
}