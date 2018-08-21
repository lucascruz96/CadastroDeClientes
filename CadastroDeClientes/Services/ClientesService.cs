using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeClientes.Filters;
using CadastroDeClientes.Models;
using CadastroDeClientes.Repositories;
using CadastroDeClientes.Utils;

namespace CadastroDeClientes.Services
{
    public class ClientesService : IClientesService
    {
        private IClientesRepository _clientesRepository;

        public ClientesService()
        {
            _clientesRepository = new ClientesRepository();
        }

        public void Inserir(Cliente cliente, Empresa empresa)
        {
            ValidarRegras(cliente, empresa);

            _clientesRepository.Inserir(cliente);
        }

        public List<Cliente> Consultar(ClientesFilter clientesFilter)
        {
            return _clientesRepository.Consultar(clientesFilter);
        }

        private void ValidarRegras(Cliente cliente, Empresa empresa)
        {
            switch(empresa.Endereco.Uf)
            {
                case "SP":
                    AplicarRegrasSp(cliente);
                    break;
                case "MG":
                    AplicarRegrasMg(cliente);
                    break;
            }
        }

        private void AplicarRegrasSp(Cliente cliente)
        {
            if (Util.CalcularIdade(cliente.DataNascimento) < 18)
                throw new ArgumentException("Não é permitido o cadastro de clientes menores de 18 anos para empresas de São Paulo.", "Data Nascimento");
        }

        private void AplicarRegrasMg(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Rg))
                throw new ArgumentException("O campo RG é obrigatório para empresas de Minas Gerais.", "RG");
        }
    }
}
