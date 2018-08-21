using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Models
{
    public class Empresa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public List<string> Telefones { get; set; }
    }
}
