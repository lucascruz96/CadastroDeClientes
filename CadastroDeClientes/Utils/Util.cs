using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroDeClientes.Utils
{
    public class Util
    {
        public static string LerConteudoArquivo(string caminho)
        {
            var arquivo = new StreamReader(caminho);

            string conteudo = arquivo.ReadToEnd();

            arquivo.Close();

            return conteudo;
        }

        public static int CalcularIdade(DateTime dataNascimento)
        {
            if (DateTime.Today.Date < dataNascimento.Date)
                return -1;

            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day))
                idade--;

            return idade;
        }

        public static bool ValidarCpf(string cpf)
        {
            cpf = Regex.Replace(cpf, "[^0-9]+", "");

            if (cpf.Length != 11)
                return false;

            if (Regex.IsMatch(cpf, "([0]{11}|[1]{11}|[2]{11}|[3]{11}|[4]{11}|[5]{11}|[6]{11}|[7]{11}|[8]{11}|[9]{11})"))
                return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpfTemporario;
            string digito;
            int soma;
            int resto;

            cpfTemporario = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpfTemporario[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            cpfTemporario = cpfTemporario + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpfTemporario[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
