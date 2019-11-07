﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        static string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["caminhoArquivoCor"]);

        //ToDo: OO - Polimorfismo por sobrecarga (varios metedos com mesmo nome)
        public List<Cor> Obter()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var cor = new Cor();
                cor.ID = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);
                cores.Add(cor);
            }

            return cores;
        }

        public Cor Obter(int id)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var linhaId = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaId)
                {
                    cor = new Cor();
                    cor.ID = linhaId;
                    cor.Nome = linha.Substring(5);

                    break;
                }
                
            }

            return cor;
        }
    }
}
