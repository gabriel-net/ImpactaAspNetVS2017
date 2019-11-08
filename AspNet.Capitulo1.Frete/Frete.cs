using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet.Capitulo1.Frete
{
    public class Frete
    {
        public Frete(UF uf, decimal valorProduto)
        {
            UF = uf;
            ValorProduto = valorProduto;

            Calcular();
        }

        public Cliente Cliente { get; set; }
        public decimal ValorProduto { get; set; }
        public UF UF { get; set; }
        public decimal ValorFrete { get; private set; } /*a prop 'Frete' não pode ter o mesmo nome da classe*/
        public decimal ValorTotal { get; private set; }

        //public Dictionary<UF, decimal> ValoresFrete { get; set; } *DICTIONARY, USA UMA 1 CHAVE(KEY) E 2 UM VALUE

        //public void PreecherValores()
        //{
        //    ValoresFrete.Add(UF.SP, 0.2M);
        //    ValoresFrete.Add(UF.RJ, 0.3M);
        //                                                          *CRIANDO UM DICTIONARY
        //    ValorFrete = ValoresFrete[UF];                        *UMA OUTRA MANEIRA, SEM FAZER SWITCH
        //}

        private void Calcular()
        {
            switch (UF.ToString().ToUpper())
            {
                case "SP":
                    ValorFrete = 0.2m;
                    break;

                case "RJ":
                    ValorFrete = 0.3m;
                    break;

                case "MG":
                    ValorFrete = 0.35m;
                    break;

                case "AM":
                    ValorFrete = 0.6m;
                    break;

                default:
                    ValorFrete = 0.7m;
                    break;
            }

            ValorTotal = (1 + ValorFrete) * ValorProduto;
        }
    }

}
