using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        private MarcaRepositorio marcaRepositorio = new MarcaRepositorio();

        [TestMethod()]
        public void ObterTest()
        {
            var marcas = marcaRepositorio.Obter();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.ID} - {marca.Nome}");
            }
        }

        [TestMethod()]
        public void ObterPorIdTest()
        {
            var marca = marcaRepositorio.Obter(3);
            Assert.AreEqual(marca.Nome, "VW");            //TESTES UNITARIOS, NÃO É USADO O CW (CONSOLE WRITTELINE), APENAS A VERIFICAÇÃO (FAROL VERDE)

            marca = marcaRepositorio.Obter(8);
            Assert.IsNull(marca);
        }
    }
}