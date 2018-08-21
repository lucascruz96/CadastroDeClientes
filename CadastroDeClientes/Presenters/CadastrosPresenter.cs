using CadastroDeClientes.Models;
using CadastroDeClientes.Services;
using CadastroDeClientes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Presenters
{
    public class CadastrosPresenter
    {
        private ICadastrosView _cadastroView;
        private IClientesService _clientesService;

        public CadastrosPresenter(ICadastrosView cadastroView)
        {
            _cadastroView = cadastroView;
            _clientesService = new ClientesService();
        }

        public void ProcessarCadastro()
        {
            Cliente cliente = _cadastroView.GetCliente();
            Empresa empresa = _cadastroView.GetEmpresa();

            _clientesService.Inserir(cliente, empresa);
        }
    }
}
