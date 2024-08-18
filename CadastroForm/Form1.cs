using Sistema;

namespace CadastroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedoresForm fornecedoresForm = new CadastroFornecedoresForm();
            fornecedoresForm.MdiParent = this;
            fornecedoresForm.WindowState = FormWindowState.Maximized;
            fornecedoresForm.Show();

        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametrosForm parametros = new ParametrosForm();
            parametros.MdiParent = this;
            parametros.WindowState = FormWindowState.Maximized;
            parametros.Show();
        }
    }
}
