using CadastroDeClientes.Filters;
using CadastroDeClientes.Models;
using CadastroDeClientes.Presenters;
using CadastroDeClientes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeClientes.Views
{
    public partial class FormPrincipal : Form, ICadastrosView, IListagensView
    {
        private const string PATTERN_ENDERECO_EMPRESA = "{0}, {1} {2} - {3}, {4} - {5}, {6}";

        private Empresa[] _empresas;

        public FormPrincipal(Empresa[] empresas)
        {
            InitializeComponent();

            _empresas = empresas;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarPadraoForm();
        }

        private void cbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empresa empresa = (Empresa)cbEmpresas.SelectedItem;

            txtEnderecoEmpresa.Text = string.Format(PATTERN_ENDERECO_EMPRESA,
                                                    empresa.Endereco.Logradouro,
                                                    empresa.Endereco.Numero,
                                                    empresa.Endereco.Complemento,
                                                    empresa.Endereco.Bairro,
                                                    empresa.Endereco.Cidade,
                                                    empresa.Endereco.Uf,
                                                    empresa.Endereco.Cep);

            if (empresa.Endereco.Uf == "MG")
                lblRg.Text = "* RG (apenas números): ";
            else
                lblRg.Text = "RG (apenas números): ";
        }

        private void btnAddTelefone_Click(object sender, EventArgs e)
        {
            if (txtTelefone.MaskCompleted)
            {
                if (lbTelefones.Items.Contains(txtTelefone.Text))
                    MessageBox.Show("Telefone já está cadastrado!", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    lbTelefones.Items.Add(txtTelefone.Text);
                    txtTelefone.Clear();
                    btnDelTelefone.Enabled = true;
                }
            }
            else
                MessageBox.Show("Telefone inválido!", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelTelefone_Click(object sender, EventArgs e)
        {
            if (lbTelefones.SelectedItem != null)
            {
                lbTelefones.Items.Remove(lbTelefones.SelectedItem);
                btnDelTelefone.Enabled = (lbTelefones.Items.Count > 0);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarDataNascimento())
            {
                if (ValidarCpf())
                    CadastrarCliente();
                else
                    MessageBox.Show($"Cpf inválido!", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show($"O valor {cbDiaNascimento.SelectedItem.ToString()}/{cbMesNascimento.SelectedItem.ToString()}/{cbAnoNascimento.SelectedItem.ToString()} não é válido como data de nascimento.", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }

        private void ConsultarClientes()
        {
            try
            {
                var listagemPresenter = new ListagensPresenter(this);
                listagemPresenter.ListarClientes();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Falha ao pesquisar clientes.\nDetalhes: {erro.Message}", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private bool ValidarCpf()
        {
            return Util.ValidarCpf(txtCpf.Text);
        }

        private void CadastrarCliente()
        {
            try
            {
                var cadastroPresenter = new CadastrosPresenter(this);
                cadastroPresenter.ProcessarCadastro();
                ResetarCampos();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Falha ao realizar cadastro.\nDetalhes: {erro.Message}", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarPadraoForm()
        {
            cbEmpresas.Items.AddRange(_empresas);
            cbEmpresas.SelectedIndex = 0;
            ResetarCampoDataNascimento();
        }

        private void ResetarCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            lbTelefones.Items.Clear();
            txtRg.Clear();
            ResetarCampoDataNascimento();
        }

        private void ResetarCampoDataNascimento()
        {
            cbDiaNascimento.SelectedIndex = 0;
            cbMesNascimento.SelectedIndex = 0;
            cbAnoNascimento.SelectedIndex = 0;
        }

        private bool ValidarDataNascimento()
        {
            DateTime dataNascimento = GetDataNascimento();

            return (dataNascimento != DateTime.MinValue && Util.CalcularIdade(dataNascimento) > 0);
        }

        private DateTime GetDataNascimento()
        {
            int dia = int.Parse(cbDiaNascimento.SelectedItem.ToString());
            int mes = int.Parse(cbMesNascimento.SelectedItem.ToString());
            int ano = int.Parse(cbAnoNascimento.SelectedItem.ToString());

            try
            {
                var data = new DateTime(ano, mes, dia);

                return data;
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        private string GetTelefones()
        {
            var listTelefones = lbTelefones.Items.OfType<string>().ToList();
            var telefones = new StringBuilder();

            foreach (string telefone in listTelefones)
                telefones.Append((telefones.Length > 0 ? $" | {telefone}" : telefone));

            return telefones.ToString();
        }

        public Cliente GetCliente()
        {
            var cliente = new Cliente();
            cliente.Nome = txtNome.Text.Trim();
            cliente.Cpf = txtCpf.Text;
            cliente.Rg = txtRg.Text;
            cliente.DataNascimento = GetDataNascimento();
            cliente.Telefones = GetTelefones();
            cliente.IdEmpresa = (cbEmpresas.SelectedItem as Empresa).Codigo;
            cliente.DataCadastro = DateTime.Now;

            return cliente;
        }

        public Empresa GetEmpresa()
        {
            return (cbEmpresas.SelectedItem as Empresa);
        }

        public ClientesFilter GetFiltro()
        {
            return new ClientesFilter
            {
                Nome = txtNomePesquisa.Text,
                Cpf = txtCpfPesquisa.Text,
                IdEmpresa = (cbEmpresas.SelectedItem as Empresa).Codigo
            };
        }

        public void MontarGrid(List<Cliente> clientes)
        {
            gridListagem.DataSource = clientes;
        }
    }
}
