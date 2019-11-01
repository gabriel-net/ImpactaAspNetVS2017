﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio repositorio = new ModeloRepositorio();

        [TestMethod()]
        public void ObterPorMarca()
        {
            var modelos = repositorio.ObterPorMarca(2);

            foreach (var modelo in modelos)
            {
                Console.WriteLine($"{modelo.ID} - {modelo.Nome} - {modelo.Marca.Nome}");
            }

            modelos = repositorio.ObterPorMarca(9);

            Assert.IsTrue(modelos.Count == 0);

        }

        [TestMethod()]
        public void ObterPorIdTest()
        {
            var modelo = repositorio.Obter(4);

            Assert.AreEqual(modelo.Nome, "Polo");

            modelo = repositorio.Obter(28);

            Assert.IsNull(modelo);
        }
    }
}