using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPCorreiosDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String cep = txtCEP.Text;
            String Descricao;
            String Complemento;
            String Bairro;
            String Cidade;
            String UF;

            try
            {
                using (var correios = new Correios.AtendeClienteClient())
                {
                    var consulta = correios.consultaCEP(cep);
                    Descricao = consulta.end;
                    Complemento = consulta.complemento;
                    Bairro = consulta.bairro;
                    Cidade = consulta.cidade;
                    UF = consulta.uf;
                }

                MessageBox.Show("Descrição: " + Descricao + "\n" +
                "Complemento: " + Complemento + "\n" +
                "Bairro: " + Bairro + "\n" +
                "Cidade: " + Cidade + "\n" +
                "UF: " + UF);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
