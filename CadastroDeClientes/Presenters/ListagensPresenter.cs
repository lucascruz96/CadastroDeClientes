using CadastroDeClientes.Filters;
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
    public class ListagensPresenter
    {
        private IListagensView _listagensView;
        private IClientesService _clientesService;

        public ListagensPresenter(IListagensView listagensView)
        {
            _listagensView = listagensView;
            _clientesService = new ClientesService();
        }

        public void ListarClientes()
        {
            ClientesFilter clientesFilter = _listagensView.GetFiltro();

            List<Cliente> clientes = _clientesService.Consultar(clientesFilter);

            _listagensView.MontarGrid(clientes);
        }
    }
}
