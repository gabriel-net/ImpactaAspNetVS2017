﻿using AspNet.Capitulo03.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNet.Capitulo03.Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Deixe sua mensagem.";

            return View();
        }

        //public  ActionResult Contact(string nome, string email, string mensagem)
        //public ActionResult Contact(FormCollection formulario)
        [HttpPost]
        public ActionResult Contact(ContatoViewModel contato)
        {
            //var nome = formulario["nome"];
            if (!ModelState.IsValid)
            {
                return View(contato);
            }

            var stringConexao = ConfigurationManager.ConnectionStrings["portfolioConnectionString"].ConnectionString;

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string instrucao = @"INSERT INTO [dbo].[Contato]
                                               ([Nome]
                                               ,[Email]
                                               ,[Mensagem])
                                         VALUES
                                               (@Nome
                                               ,@Email
                                               ,@Mensagem)";

                //ToDo: não esqueca do meu IDisposable.
                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    comando.Parameters.AddWithValue("Nome", contato.Nome);
                    comando.Parameters.AddWithValue("@Email", contato.Email);
                    comando.Parameters.AddWithValue(nameof(contato.Mensagem), contato.Mensagem);


                    comando.ExecuteNonQuery();
                }
                //conexao.Close() não precisa, pois o using e o SqlConnection fecham a conexao

            }

            ViewBag.Sucesso = true;

            ModelState.Clear();

            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }
    }
}