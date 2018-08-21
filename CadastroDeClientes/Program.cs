using CadastroDeClientes.Models;
using CadastroDeClientes.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeClientes.Views;

namespace CadastroDeClientes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Empresa[] empresas = CarregarEmpresas();

            Application.Run(new FormPrincipal(empresas));
        }

        private static Empresa[] CarregarEmpresas()
        {
            string configEmpresas = Util.LerConteudoArquivo($@"{Application.StartupPath}\Configs\Empresas.json");

            var empresas = JsonConvert.DeserializeObject<Empresa[]>(configEmpresas);

            return empresas;
        }
    }
}
