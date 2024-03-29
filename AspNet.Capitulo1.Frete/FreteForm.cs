﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNet.Capitulo1.Frete
{
    public partial class freteForm : Form
    {
        public freteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)//(ValidarFormulario())
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            }
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(valorTextBox.Text);
            var nordeste = new List<string> {"BA", "AL", "CE"};

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;

                case "RJ":
                case "ES":
                    percentual = 0.3m;
                    break;

                case "MG":
                    percentual = 0.35m;
                    break;

                case "AM":
                    percentual = 0.6m;
                    break;

                case var uf when nordeste.Contains(uf):
                    percentual = 0.4m;
                    break;

                default:
                    percentual = 0.7m;
                    break;
            }

            //if (ufComboBox.Text.ToUpper() == "SP") 
            //{
            //    percentual = 0.2m;
            //}
            //else if (ufComboBox.Text.ToUpper() == "RJ" || (ufComboBox.Text.ToUpper() == "ES")
            //{
            //    percentual = 0.3m;           
            //}
            //else if (ufComboBox.Text.ToUpper() == "MG") 
            //{
            //    percentual = 0.5m;
            //} 
            //else 
            //{
            //    percentual = 0.7m;
            //}

            freteTextBox.Text = percentual.ToString("p2");
            totalTextBox.Text = ((1 + percentual) * valor).ToString("c");
       
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            //if (clienteTextBox.Text == "")
            if (clienteTextBox.Text.Trim() == string.Empty)
            {
                erros.Add("Preencha o campo Cliente!!!");
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione o campo UF!!!");
            }

            if (string.IsNullOrEmpty(valorTextBox.Text.Trim()))
            {
                erros.Add("Preencha o campo Valor!!!");
            }
            else
            {
                if (!decimal.TryParse(valorTextBox.Text.Trim(), out decimal valorConvertido))
                {
                    erros.Add("Preencha o campo Valor apenas com números!!!");
                }
            }

            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e) 
        {
            clienteTextBox.Clear();
            valorTextBox.Text = "";
            ufComboBox.SelectedIndex = -1;
            freteTextBox.Text = null;
            totalTextBox.Text = string.Empty;
        }
    }

}

