using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TesteCEP
{
    public partial class Form1 : Form
    {
        private readonly CepService _cepService = new CepService();

        public Form1()
        {
            InitializeComponent();
            //ButtonConsultar.Click += ButtonConsultar_Click;
            textBoxCEP.TextChanged += textBoxCEP_TextChanged;
        }

        //private async void ButtonConsultar_Click(object sender, EventArgs e)
        //{
        //    string cep = textBoxCEP.Text.Replace("-", "");

        //    if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8)
        //    {
        //        MessageBox.Show("Informe um CEP válido.");
        //        return;
        //    }

        //    try
        //    {
        //        string responseJson = await _cepService.ConsultarCepAsync(cep);
        //        var endereco = JsonConvert.DeserializeObject<Endereco>(responseJson);

        //        if (endereco != null)
        //        {
        //            txtLogradouro.Text = endereco.Logradouro;
        //            txtBairro.Text = endereco.Bairro;
        //            txtLocalidade.Text = endereco.Localidade;
        //            txtUf.Text = endereco.Uf;
        //        }
        //        else
        //        {
        //            MessageBox.Show("CEP não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private async void textBoxCEP_TextChanged(object sender, EventArgs e)
        {
            string cep = textBoxCEP.Text.Replace("-", "");

            if (cep.Length == 8) // Quando o CEP tem 8 dígitos
            {
                try
                {
                    string responseJson = await _cepService.ConsultarCepAsync(cep);
                    var endereco = JsonConvert.DeserializeObject<Endereco>(responseJson);

                    if (endereco != null)
                    {
                        txtLogradouro.Text = endereco.Logradouro;
                        txtBairro.Text = endereco.Bairro;
                        txtLocalidade.Text = endereco.Localidade;
                        txtUf.Text = endereco.Uf;
                    }
                    else
                    {
                        LimparCamposEndereco();
                    }
                }
                catch (Exception ex)
                {
                    LimparCamposEndereco();
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimparCamposEndereco()
        {
            txtBairro.Clear();
            txtLocalidade.Clear();
            txtLogradouro.Clear();
            txtUf.Clear();
        }
    }
}