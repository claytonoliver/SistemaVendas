using Negocio.Parametros.Interfaces;
using Sistema.Parametros;
using Infraestrutura.DataBaseFactory;
using Infraestrutura.Entidades.Parametro;
using System;

namespace Sistema
{
    public partial class ParametrosForm : Form
    {
        private readonly IParametrosBiz parametrosBiz;
        public ParametrosForm()
        {
            InitializeComponent();
            parametrosBiz = DInjector.Resolve<IParametrosBiz>();
            LoadGrid();
            InitializeLayoutDgParametros();
        }

        private void LoadGrid()
        {
            DgParametros.DataSource = parametrosBiz.BuscarParametros();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            var incluirParametro = new IncluirParametroForm();
            incluirParametro.OnAdd += () => LoadGrid();
            incluirParametro.ShowDialog();
        }

        private void InitializeLayoutDgParametros()
        {
            DgParametros.Columns["Id"].Visible = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgParametros.SelectedRows.Count > 0)
            {
                var row = DgParametros.SelectedRows[0];
                var parametro = new ParametroModel
                {
                    Id = (int)row.Cells["Id"].Value,
                    Chave = row.Cells["Chave"].Value.ToString(),
                    Valor = row.Cells["Valor"].Value.ToString(),
                    Descricao = row.Cells["Descricao"].Value.ToString(),
                };

                var editParametroForm = new IncluirParametroForm(parametro);
                editParametroForm.ShowDialog();
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (DgParametros.SelectedRows.Count > 0)
            {
                var row = DgParametros.SelectedRows[0];
                if (MessageBox.Show("Deseja Remover os itens selecionados?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parametrosBiz.ExcluirParametro((int)row.Cells["Id"].Value);
                    MessageBox.Show($"Parametro {row.Cells["Chave"].Value.ToString()} removido ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                }



            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
