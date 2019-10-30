using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Capitulo01.VetoresColecoes.Teste 
{
    [TestClass]
    public class ColecoesTeste 
    {
        [TestMethod]
        public void ListTeste() 
        {
            var inteiros = new List<int>(1000) { 16, 3, 34, 2, -81 };// a sintaxe (1000) pode ser apenas de (), porem se colocado valor será o tamanho do 'vetor'
            inteiros.Add(15);//para Add no final
            inteiros[0] = 23;//Add alterando o que ja esta na posicao 0
            //inteiros[10] = 2;

            var maisInteiros = new List<int> { 4, 2, 3 };
            inteiros.AddRange(maisInteiros);//Add a lista dentro da outra lista (ao final)
            inteiros.Insert(0, 29);//adiciona na posicao escolhida (empurra o que ja estava para proxima posicao)
            inteiros.Remove(2);//remove o item, pelo valor do item nao pela posicao
            inteiros.RemoveAll(x => x == 2);
            inteiros.RemoveAt(4);//remove o item, na posição 4
            inteiros.Sort();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();
            var ultimo = inteiros.Last();
            ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros) 
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");
            }

        }

        [TestMethod]
        public void DectionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();//dictionary, o indice pode ser de qualquer tipo, não apenas INT
            feriados.Add(new DateTime(2019, 11, 02), "Finados");//para adicionar date time é necessaria a sintaxe 'new'
            feriados.Add(Convert.ToDateTime("15/11/2019"), "Proclamação da República");//outra forma de digitar um 'datetime'
            feriados.Add(Convert.ToDateTime("20/11/2019"), "Consciência Negra");//outra forma de digitar um 'datetime'
          //feriados.Add(Convert.ToDateTime("20/11/2019"), "Consciência Negra");// NÃO É POSSIVEL TER UM MESMO ÍNDICE NO DICTIONARY

            var finados = feriados[new DateTime(2019, 11, 2)];

            foreach (var feriado in feriados)
            {
              //Console.WriteLine($"{feriado.Key.ToShortDateString()}: {feriado.Value}");
                Console.WriteLine($"{feriado.Key.ToString("dd/mm/yyyy")}: {feriado.Value}");
            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("15/11/2019")));//verificar se contem a data 15/11/2019 na chave (indice)
            Console.WriteLine(feriados.ContainsValue("Finados"));//verificar se possui finados nos valores
        }
    }
}
