using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Capitulo01.VetoresColecoes.Teste 
{
    [TestClass]
    public class VetoresTeste 
    {
        [TestMethod]
        public void InicializacaoTeste() 
        {
            var inteiros = new int[5]; //1ª forma de escrever
            inteiros[0] = 48;
            inteiros[1] = 20;
            //inteiros[-5] = 8;  'o build nao quebra, mas o aplicativo crasha'

            var decimais = new decimal[] {0.2m, 5, 2.52m, 1.9m}; //2ª forma de escrever

            decimal[] maisDecimais = {2, 5.8m, 0.5m};

            foreach (var @decimal in decimais) 
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} é de: {decimais.Length}");
            //nameof serve para que nao corra o risco, caso ocorra um rename, de nao trocar o nome da variavel no texto exibido
        }

        [TestMethod]
        public void RedimensionamentoTeste() 
        {
            var decimais = new decimal[] {2.1m, 1.6m, -8}; //0, 1, 2

            Array.Resize(ref decimais, 5); //redimencionamento de tamanho do vetor. uma vez criado o vetor não pode ser redimencionado por ele mesmo, pois o espaço dele é criado diretamento no windows
    
            decimais[3] = 1.7m;

            Assert.AreEqual(decimais[4], 0);

            foreach (var @decimal in decimais) 
            {
                Console.WriteLine(@decimal);
            }
           
        }

        [TestMethod]
        public void OrdenacaoTeste() 
        {
            var decimais = new decimal[] { 2.1m, 1.6m, -8 };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -8);

            foreach (var @decimal in decimais) 
            {
                Console.WriteLine(@decimal);
            }
        }

        [TestMethod]
        public void ParamsTeste() 
        {
            var decimais = new decimal[] { 2.1m, 1.6m, -8 };

            Console.WriteLine(Media(decimais));
            Console.WriteLine(Media(1.9m, 2.19m, 22,03m));
            Console.WriteLine(decimais.Average());
        }

        private decimal Media(decimal valor1, decimal valor2) 
        {
            return (valor1 + valor2) / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valores"></param>
        /// <returns></returns>
        private decimal Media(params decimal[] valores)
        {
            var soma = 0m;

            foreach (var valor in valores)
	        {
                soma += valor;

	        }

            //for (int i = 0; i < valores.Length; i++) 
            //{
            //    soma += valores[i];
            //}

            return soma / valores.Length;
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste() 
        {
            var nome = "Vitor";

            Assert.AreEqual(nome[0], 'V');

            //StringBuilder;

            foreach (var letra in nome) 
            {
                Console.Write(letra);
            }
        }
    }
}
