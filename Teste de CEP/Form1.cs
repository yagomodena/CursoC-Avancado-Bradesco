using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Teste_de_CEP
{
    public partial class Form1 : Form
    {

        private readonly CepService _cepService = new CepService();

        public Form1()
        {
            InitializeComponent();
            btnConsultar.Click += btnConsultar_Click;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string cep = textBox1.Text.Replace("-", "");

            if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8)
            {
                MessageBox.Show("Informe um CEP válido.");
                return;
            }

            try
            {
                string responseJson = await _cepService.ConsultarCepAsync(cep);
                // Fazer o parse do JSON e atualizar os controles do formulário
                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}