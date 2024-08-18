using Sistema;
using Sistema.Usuarios;

namespace CadastroForm
{
    public partial class InicioForm : Form
    {
        public InicioForm()
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm formUsuarios = new UsuariosForm();
            formUsuarios.MdiParent = this;
            formUsuarios.WindowState = FormWindowState.Maximized;
            formUsuarios.Show();
        }
    }
}
