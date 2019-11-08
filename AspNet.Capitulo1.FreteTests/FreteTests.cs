using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet.Capitulo1.Frete
{
    [TestClass()]
    public class FreteTests
    {
        [TestMethod()]
        public void CalcularTest()
        {
            var frete = new Frete(UF.MG, 200);
            frete.Cliente = new Cliente { NomeCliente = "Vitor", Id = 1 };
            //frete.UF = UF.MG;
            //frete.ValorProduto = 200m; **Esses dois paramentros estao sendo usados acima, foi criado um construtor 

            //frete.Calcular();

            Assert.AreEqual(frete.ValorFrete, 0.35m);
            Assert.AreEqual(frete.ValorTotal, 270m);

        }
    }
}