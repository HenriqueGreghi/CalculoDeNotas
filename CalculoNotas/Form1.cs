using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoNotas
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Notas;Integrated Security=True");
        SqlCommand cmd;
        
        public Form1()
        {
            InitializeComponent();
        }

        double nota1, nota2, nota3, nota4;
        bool testar;
        

        private void salvarNotas_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("INSERT INTO Alunos(id,nome,nota1,nota2,nota3,nota4) VALUES(@Id,@Nome,@Nota1,@Nota2,@Nota3,@Nota4)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", txt_Id.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Nome", txt_Nome.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Nota1", txt_Nota1.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Nota2", txt_Nota2.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Nota3", txt_Nota3.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Nota4", txt_Nota4.Text.ToUpper());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                con.Close();
                
            }


        }



        public void lerNotas_Click(object sender, EventArgs e)
        {
            testar = double.TryParse(txt_Nota1.Text, out nota1);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 1.");
                return;
            }
            testar = double.TryParse(txt_Nota2.Text, out nota2);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 2.");
                return;
            }
            testar = double.TryParse(txt_Nota3.Text, out nota3);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 3.");
                return;
            }
            testar = double.TryParse(txt_Nota4.Text, out nota4);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 1.");
                return;
            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Calculo calc = new Calculo(nota1, nota2, nota3, nota4);
            double maior = calc.CalculoMaiorValor();
            resultadoMaior.Text = string.Format("Maior nota:..........................{0}", maior.ToString("F2", CultureInfo.InvariantCulture));
            double menor = calc.CalculoMenorValor();
            resultadoMenor.Text = string.Format("Menor nota:...........................{0}", menor.ToString("F2", CultureInfo.InvariantCulture));
            double media = calc.Media();
            resultadomedia.Text = string.Format("Média....................................{0}", media.ToString("F2", CultureInfo.InvariantCulture));
            double par = calc.SomaPares();
            somaPar.Text = string.Format("Soma das notas pares..........{0}", par.ToString("F2", CultureInfo.InvariantCulture));
            double imp = calc.SomaImpar();
            somaImpar.Text = string.Format("Soma das notas impares.......{0}", imp.ToString("F2", CultureInfo.InvariantCulture));
            double qtd = calc.QuantidadeNotas();
            quantidadeMI.Text = string.Format("Qtde de notas >= a 7.............{0}", qtd.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void limpar_Click(object sender, EventArgs e)
        {
            resultadoMaior.Text = string.Format("Maior nota:...................{0}", 0);
            resultadoMenor.Text = string.Format("Menor nota:...................{0}", 0);
            resultadomedia.Text = string.Format("Média.........................{0}", 0);
            somaPar.Text = string.Format("Soma das notas pares..........{0}", 0);
            somaImpar.Text = string.Format("Soma das notas impares......{0}", 0);
            quantidadeMI.Text = string.Format("Qtde de notas >= a 7.......{0}", 0);
            txt_Nota1 = null;
            txt_Nota2 = null;
            txt_Nota3 = null;
            txt_Nota4 = null;

        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do programa ?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txt_Nota1.Focus();
            }

        }

        private void resultadoMaior_Click(object sender, EventArgs e)
        {

        }

        private void resultadoMenor_Click(object sender, EventArgs e)
        {

        }

        private void resultadoMedia_Click(object sender, EventArgs e)
        {

        }


        private void resultadoSPar_Click(object sender, EventArgs e)
        {

        }

        private void resultadoSImp_Click(object sender, EventArgs e)
        {

        }

        private void resultadoQta_Click(object sender, EventArgs e)
        {

        }

    }
}
