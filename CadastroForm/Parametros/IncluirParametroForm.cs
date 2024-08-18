using Infraestrutura.DataBaseFactory;
using Infraestrutura.Entidades.Parametro;
using Microsoft.EntityFrameworkCore;
using Negocio.Parametros.Interfaces;

namespace Sistema.Parametros
{
    public partial class IncluirParametroForm : Form
    {
        private readonly IParametrosBiz parametrosBiz;

        private ParametroModel model;
        public Action OnAdd;
        private Action<int> OnDelete;

        private ParametroModel _parametro;
        public IncluirParametroForm()
        {
            InitializeComponent();
            parametrosBiz = DInjector.Resolve<IParametrosBiz>();
        }

        public IncluirParametroForm(ParametroModel parametro): this()
        {
            _parametro = parametro;

            txbChave.Text = _parametro.Chave;
            txbDescricao.Text = _parametro.Descricao;
            txbValor.Text = _parametro.Valor;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrEmpty(txbChave.Text) || string.IsNullOrEmpty(txbDescricao.Text) || string.IsNullOrEmpty(txbValor.Text))
            {
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm() && _parametro == null)
            {
                var novoParametro = new ParametroModel
                {
                    Chave = txbChave.Text,
                    Valor = txbValor.Text,
                    Descricao = txbDescricao.Text,
                };

                parametrosBiz.IncluirNovoParametro(novoParametro);

                OnAdd?.Invoke();
                this.Close();
            }
            else 
            {
                var parametro = new ParametroModel
                {
                    Id = _parametro.Id,
                    Chave = txbChave.Text,
                    Valor = txbValor.Text,
                    Descricao = txbDescricao.Text,
                };
                parametrosBiz.EditarParametro(parametro);
            }

            this.Close();

        }
    }
}
