using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeClientes.Filters;
using CadastroDeClientes.Models;

namespace CadastroDeClientes.Services
{
    public interface IClientesService
    {
        void Inserir(Cliente cliente, Empresa empresa);
        List<Cliente> Consultar(ClientesFilter clientesFilter);
    }
}
