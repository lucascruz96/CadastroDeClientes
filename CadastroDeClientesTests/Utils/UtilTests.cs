using NUnit.Framework;
using CadastroDeClientes.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Utils.Tests
{
    [TestFixture()]
    public class UtilTests
    {
        [Test()]
        public void ValidarCpfInvalidoTest()
        {
            Assert.IsFalse(Util.ValidarCpf("999.999.999-99"));
            Assert.IsFalse(Util.ValidarCpf("56199391038"));
        }

        [Test()]
        public void ValidarCpfValidoTest()
        {
            Assert.IsTrue(Util.ValidarCpf("574.789.170-70"));
            Assert.IsTrue(Util.ValidarCpf("94565822059"));
        }

        [Test()]
        public void CalcularIdadeValidaTest()
        {
            var dataNascimento = new DateTime(1996, 07, 04);

            int esperado = 22;
            int resultado = Util.CalcularIdade(dataNascimento);

            Assert.AreEqual(esperado, resultado);
        }

        [Test()]
        public void CalcularIdadeInvalidaTest()
        {
            var dataNascimento = new DateTime(2020, 07, 04);

            int esperado = -1;
            int resultado = Util.CalcularIdade(dataNascimento);

            Assert.AreEqual(esperado, resultado);
        }
    }
}