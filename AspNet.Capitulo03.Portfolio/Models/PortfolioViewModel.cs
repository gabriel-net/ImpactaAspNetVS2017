using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet.Capitulo03.Portfolio.Models
{
    public class PortfolioViewModel
    {
        public PortfolioViewModel()
        {
            //CaminhoImagens = new List<string>();
        }

        public List<string> CaminhoImagens { get; set; } = new List<string>();
    }
}