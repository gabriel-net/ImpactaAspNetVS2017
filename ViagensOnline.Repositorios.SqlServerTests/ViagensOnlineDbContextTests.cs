using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViagensOnline.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagensOline.Dominio;

namespace ViagensOnline.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class ViagensOnlineDbContextTests
    {
        ViagensOnlineDbContext db = new ViagensOnlineDbContext();

        [TestMethod()]
        public void InsertTest()
        {
            var destino = new Destino();

            destino.Cidade = "Dublin";
            destino.Nome = "Conheca terra da Guiness";
            destino.NomeImagem = "dublin.jpg";
            destino.Pais = "Irlanda";

            db.Destinos.Add(destino);

            db.SaveChanges();
        }

        [TestMethod]
        public void UpdateTest()
        {
            // db.Destinos.Where();
            var destino = db.Destinos.Find(1);

            destino.NomeImagem = "guinneess.png";

            db.SaveChanges();

            destino = db.Destinos.Where(d => d.Id == 1).Single();

            Assert.AreEqual(destino.NomeImagem, "guinneess.png");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var destino = db.Destinos.Find(4);

            db.Destinos.Remove(destino);

            db.SaveChanges();

            destino = db.Destinos.Find(4);

            Assert.IsNull(destino);
        }
    }
}