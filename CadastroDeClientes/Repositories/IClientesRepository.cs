using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeClientes.Filters;
using CadastroDeClientes.Models;

namespace CadastroDeClientes.Repositories
{
    interface IClientesRepository
    {
        void Inserir(Cliente cliente);
        List<Cliente> Consultar(ClientesFilter clientesFilter);
    }
}
