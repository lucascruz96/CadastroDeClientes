using CadastroDeClientes.Filters;
using CadastroDeClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Views
{
    public interface IListagensView
    {
        ClientesFilter GetFiltro();
        void MontarGrid(List<Cliente> clientes);
    }
}
