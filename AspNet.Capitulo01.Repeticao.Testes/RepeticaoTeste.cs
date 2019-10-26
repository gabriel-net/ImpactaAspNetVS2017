using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Capitulo01.Repeticao.Testes 
{
    [TestClass]
    public class RepeticaoTeste 
    {
        [TestMethod]
        public void tabuadaTeste() 
        {
            for (int a = 1; a < 10; a++) 
            {
                for (int b = 1; b <= 10; b++) 
                {
                    Console.WriteLine($" {a} * {b} = {a*b}");
                }

                Console.WriteLine(new string('-', 50));
            }
        }

        [TestMethod]
        public void estruturaForTeste() 
        {
            var i = 0;
            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i)) 
            {
                ++i;
            }
            /*
                for (1. inicialização; 2.critério; 4. pós-execução) 
                {
                    3. execução
                }
             */

        }

        [TestMethod]
        public void forApenasComCondicaoTeste() 
        {
            var i = 1;

            for (; i <= 3;) 
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTest()
        {
            for (int i = 1; i <= 10; i++) 
            {
                if (i <=5 ) 
                {
                    continue;
                }

                Console.WriteLine(i);

            }

        }

        [TestMethod]
        public void BreakTest() 
        {
            for (int i = 1; i <= 10; i++) 
            {
                if (i > 5) 
                {
                    break;
                }

                Console.WriteLine(i);

            }

        }


    }
}
