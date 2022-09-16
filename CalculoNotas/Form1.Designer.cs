
using System;

namespace CalculoNotas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nota1 = new System.Windows.Forms.TextBox();
            this.txt_Nota2 = new System.Windows.Forms.TextBox();
            this.txt_Nota3 = new System.Windows.Forms.TextBox();
            this.txt_Nota4 = new System.Windows.Forms.TextBox();
            this.salvarNotas = new System.Windows.Forms.Button();
            this.lerNotas = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quantidadeMI = new System.Windows.Forms.Label();
            this.somaImpar = new System.Windows.Forms.Label();
            this.somaPar = new System.Windows.Forms.Label();
            this.resultadomedia = new System.Windows.Forms.Label();
            this.resultadoMenor = new System.Windows.Forms.Label();
            this.resultadoMaior = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nota 4";
            // 
            // txt_Nota1
            // 
            this.txt_Nota1.Location = new System.Drawing.Point(82, 50);
            this.txt_Nota1.Name = "txt_Nota1";
            this.txt_Nota1.Size = new System.Drawing.Size(100, 26);
            this.txt_Nota1.TabIndex = 1;
            // 
            // txt_Nota2
            // 
            this.txt_Nota2.Location = new System.Drawing.Point(82, 108);
            this.txt_Nota2.Name = "txt_Nota2";
            this.txt_Nota2.Size = new System.Drawing.Size(100, 26);
            this.txt_Nota2.TabIndex = 2;
            // 
            // txt_Nota3
            // 
            this.txt_Nota3.Location = new System.Drawing.Point(82, 163);
            this.txt_Nota3.Name = "txt_Nota3";
            this.txt_Nota3.Size = new System.Drawing.Size(100, 26);
            this.txt_Nota3.TabIndex = 3;
            // 
            // txt_Nota4
            // 
            this.txt_Nota4.Location = new System.Drawing.Point(82, 217);
            this.txt_Nota4.Name = "txt_Nota4";
            this.txt_Nota4.Size = new System.Drawing.Size(100, 26);
            this.txt_Nota4.TabIndex = 4;
            // 
            // salvarNotas
            // 
            this.salvarNotas.Location = new System.Drawing.Point(60, 291);
            this.salvarNotas.Name = "salvarNotas";
            this.salvarNotas.Size = new System.Drawing.Size(108, 35);
            this.salvarNotas.TabIndex = 5;
            this.salvarNotas.Text = "Salvar Notas";
            this.salvarNotas.UseVisualStyleBackColor = true;
            this.salvarNotas.Click += new System.EventHandler(this.salvarNotas_Click);
            // 
            // lerNotas
            // 
            this.lerNotas.Location = new System.Drawing.Point(271, 291);
            this.lerNotas.Name = "lerNotas";
            this.lerNotas.Size = new System.Drawing.Size(86, 35);
            this.lerNotas.TabIndex = 6;
            this.lerNotas.Text = "Ler Notas";
            this.lerNotas.UseVisualStyleBackColor = true;
            this.lerNotas.Click += new System.EventHandler(this.lerNotas_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(483, 291);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(81, 35);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(170, 374);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(76, 30);
            this.limpar.TabIndex = 8;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(407, 374);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 30);
            this.sair.TabIndex = 9;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantidadeMI);
            this.groupBox1.Controls.Add(this.somaImpar);
            this.groupBox1.Controls.Add(this.somaPar);
            this.groupBox1.Controls.Add(this.resultadomedia);
            this.groupBox1.Controls.Add(this.resultadoMenor);
            this.groupBox1.Controls.Add(this.resultadoMaior);
            this.groupBox1.Location = new System.Drawing.Point(195, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 210);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.calcular);
            this.groupBox2.Controls.Add(this.lerNotas);
            this.groupBox2.Controls.Add(this.salvarNotas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Nota1);
            this.groupBox2.Controls.Add(this.txt_Nota4);
            this.groupBox2.Controls.Add(this.txt_Nota2);
            this.groupBox2.Controls.Add(this.txt_Nota3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 341);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // quantidadeMI
            // 
            this.quantidadeMI.AutoSize = true;
            this.quantidadeMI.Location = new System.Drawing.Point(26, 168);
            this.quantidadeMI.Name = "quantidadeMI";
            this.quantidadeMI.Size = new System.Drawing.Size(311, 20);
            this.quantidadeMI.TabIndex = 19;
            this.quantidadeMI.Text = "Quantidade de notas maiores ou iguais a 7";
            // 
            // somaImpar
            // 
            this.somaImpar.AutoSize = true;
            this.somaImpar.Location = new System.Drawing.Point(26, 139);
            this.somaImpar.Name = "somaImpar";
            this.somaImpar.Size = new System.Drawing.Size(185, 20);
            this.somaImpar.TabIndex = 18;
            this.somaImpar.Text = "Soma das notas ímpares";
            // 
            // somaPar
            // 
            this.somaPar.AutoSize = true;
            this.somaPar.Location = new System.Drawing.Point(26, 110);
            this.somaPar.Name = "somaPar";
            this.somaPar.Size = new System.Drawing.Size(169, 20);
            this.somaPar.TabIndex = 17;
            this.somaPar.Text = "Soma das notas pares";
            // 
            // resultadomedia
            // 
            this.resultadomedia.AutoSize = true;
            this.resultadomedia.Location = new System.Drawing.Point(26, 81);
            this.resultadomedia.Name = "resultadomedia";
            this.resultadomedia.Size = new System.Drawing.Size(126, 20);
            this.resultadomedia.TabIndex = 16;
            this.resultadomedia.Text = "Média das notas";
            // 
            // resultadoMenor
            // 
            this.resultadoMenor.AutoSize = true;
            this.resultadoMenor.Location = new System.Drawing.Point(26, 52);
            this.resultadoMenor.Name = "resultadoMenor";
            this.resultadoMenor.Size = new System.Drawing.Size(90, 20);
            this.resultadoMenor.TabIndex = 15;
            this.resultadoMenor.Text = "Menor nota";
            // 
            // resultadoMaior
            // 
            this.resultadoMaior.AutoSize = true;
            this.resultadoMaior.Location = new System.Drawing.Point(26, 26);
            this.resultadoMaior.Name = "resultadoMaior";
            this.resultadoMaior.Size = new System.Drawing.Size(84, 20);
            this.resultadoMaior.TabIndex = 14;
            this.resultadoMaior.Text = "Maior nota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.limpar);
            this.Name = "Form1";
            this.Text = "Calcula Notas ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nota1;
        private System.Windows.Forms.TextBox txt_Nota2;
        private System.Windows.Forms.TextBox txt_Nota3;
        private System.Windows.Forms.TextBox txt_Nota4;
        private System.Windows.Forms.Button salvarNotas;
        private System.Windows.Forms.Button lerNotas;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label quantidadeMI;
        private System.Windows.Forms.Label somaImpar;
        private System.Windows.Forms.Label somaPar;
        private System.Windows.Forms.Label resultadomedia;
        private System.Windows.Forms.Label resultadoMenor;
        private System.Windows.Forms.Label resultadoMaior;
    }
}

