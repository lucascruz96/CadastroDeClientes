using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeClientes.Filters;
using CadastroDeClientes.Models;

namespace CadastroDeClientes.Repositories
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly EmpresaEntities db = new EmpresaEntities();

        public List<Cliente> Consultar(ClientesFilter clientesFilter)
        {
            return db.Cliente.Where(c =>
                                    c.IdEmpresa == clientesFilter.IdEmpresa
                                    && c.Nome != string.Empty && c.Nome != null && c.Nome.Contains(clientesFilter.Nome)
                                    && c.Cpf != string.Empty && c.Cpf != null && c.Cpf.Contains(clientesFilter.Cpf)
                                    ).ToList();
        }

        public void Inserir(Cliente cliente)
        {
            if (db.Cliente.Where(c => c.Cpf == cliente.Cpf && c.IdEmpresa == cliente.IdEmpresa).Count() > 0)
                throw new Exception($"Já existe um cliente cadastrado com o cpf {cliente.Cpf} para a empresa selecionada.");
            else
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
            }
        }
    }
}
