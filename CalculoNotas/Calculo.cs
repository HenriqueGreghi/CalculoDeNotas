using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNotas
{
    public class Calculo
    {
        public double MaiorValor { get; set; }
        public double MenorValor { get; set; }
        public double ValorMedia { get; set; }
        public double SomaPar { get; set; }
        public double QuantidadeNt { get; set; }
        public double SomaImp { get; set; }
        private double Nota1;
        private double Nota2;
        private double Nota3;
        private double Nota4;

        public Calculo(double nota1, double nota2, double nota3, double nota4)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
        }
        public double CalculoMaiorValor()
        {
            if (Nota1 > Nota2 && Nota1 > Nota3 && Nota1 > Nota4)
            {
                MaiorValor = Nota1;
            }
            else if (Nota2 > Nota3 && Nota2 > Nota4)
            {
                MaiorValor = Nota2;
            }
            else if (Nota3 > Nota4)
            {
                MaiorValor = Nota3;
            }
            else { MaiorValor = Nota4; }
            return MaiorValor;
        }
        public double CalculoMenorValor()
        {
            if (Nota1 < Nota2 && Nota1 < Nota3 && Nota1 < Nota4)
            {
                MenorValor = Nota1;
            }
            else if (Nota2 < Nota3 && Nota2 < Nota4)
            {
                MenorValor = Nota2;
            }
            else if (Nota3 < Nota4)
            {
                MenorValor = Nota3;
            }
            else { MenorValor = Nota4; }
            return MenorValor;

        }
        public double Media()
        {
            ValorMedia = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return ValorMedia;
        }
        public double SomaPares()
        {
            SomaPar = Nota2 + Nota4;
            return SomaPar;
        }
        public double SomaImpar()
        {
            SomaImp = Nota1 + Nota3;
            return SomaImp;
        }
        public double QuantidadeNotas()
        {
            QuantidadeNt = 0;
            if (Nota1 >= 7)
            {
                QuantidadeNt++;
            }
            if (Nota2 >= 7)
            {
                QuantidadeNt++;
            }
            if (Nota3 >= 7)
            {
                QuantidadeNt++;
            }
            if (Nota4 >= 7)
            {
                QuantidadeNt++;
            }


            return QuantidadeNt;
        }
    }
}
