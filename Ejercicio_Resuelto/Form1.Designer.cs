
namespace Ejercicio_Resuelto
{
    partial class Programa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.radio_Rectangulo = new System.Windows.Forms.RadioButton();
            this.radio_Triangulo = new System.Windows.Forms.RadioButton();
            this.radio_Circulo = new System.Windows.Forms.RadioButton();
            this.txt_radio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Base = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(209, 261);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(308, 47);
            this.txt_altura.TabIndex = 1;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(209, 508);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(308, 47);
            this.txt_area.TabIndex = 2;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(752, 497);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(262, 58);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // radio_Rectangulo
            // 
            this.radio_Rectangulo.AutoSize = true;
            this.radio_Rectangulo.ForeColor = System.Drawing.Color.White;
            this.radio_Rectangulo.Location = new System.Drawing.Point(752, 170);
            this.radio_Rectangulo.Name = "radio_Rectangulo";
            this.radio_Rectangulo.Size = new System.Drawing.Size(204, 45);
            this.radio_Rectangulo.TabIndex = 4;
            this.radio_Rectangulo.TabStop = true;
            this.radio_Rectangulo.Text = "Rectángulo";
            this.radio_Rectangulo.UseVisualStyleBackColor = true;
            this.radio_Rectangulo.CheckedChanged += new System.EventHandler(this.radio_Rectangulo_CheckedChanged);
            // 
            // radio_Triangulo
            // 
            this.radio_Triangulo.AutoSize = true;
            this.radio_Triangulo.ForeColor = System.Drawing.Color.White;
            this.radio_Triangulo.Location = new System.Drawing.Point(752, 263);
            this.radio_Triangulo.Name = "radio_Triangulo";
            this.radio_Triangulo.Size = new System.Drawing.Size(177, 45);
            this.radio_Triangulo.TabIndex = 5;
            this.radio_Triangulo.TabStop = true;
            this.radio_Triangulo.Text = "Triángulo";
            this.radio_Triangulo.UseVisualStyleBackColor = true;
            this.radio_Triangulo.CheckedChanged += new System.EventHandler(this.radio_Triangulo_CheckedChanged);
            // 
            // radio_Circulo
            // 
            this.radio_Circulo.AutoSize = true;
            this.radio_Circulo.ForeColor = System.Drawing.Color.White;
            this.radio_Circulo.Location = new System.Drawing.Point(752, 349);
            this.radio_Circulo.Name = "radio_Circulo";
            this.radio_Circulo.Size = new System.Drawing.Size(147, 45);
            this.radio_Circulo.TabIndex = 6;
            this.radio_Circulo.TabStop = true;
            this.radio_Circulo.Text = "Círculo";
            this.radio_Circulo.UseVisualStyleBackColor = true;
            this.radio_Circulo.CheckedChanged += new System.EventHandler(this.radio_Circulo_CheckedChanged);
            // 
            // txt_radio
            // 
            this.txt_radio.Location = new System.Drawing.Point(209, 347);
            this.txt_radio.Name = "txt_radio";
            this.txt_radio.Size = new System.Drawing.Size(308, 47);
            this.txt_radio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Radio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Área";
            // 
            // txt_Base
            // 
            this.txt_Base.Location = new System.Drawing.Point(209, 182);
            this.txt_Base.Name = "txt_Base";
            this.txt_Base.Size = new System.Drawing.Size(308, 47);
            this.txt_Base.TabIndex = 12;
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 716);
            this.Controls.Add(this.txt_Base);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_radio);
            this.Controls.Add(this.radio_Circulo);
            this.Controls.Add(this.radio_Triangulo);
            this.Controls.Add(this.radio_Rectangulo);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.txt_altura);
            this.Name = "Programa";
            this.Text = "Calculadora de área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.RadioButton radio_Rectangulo;
        private System.Windows.Forms.RadioButton radio_Triangulo;
        private System.Windows.Forms.RadioButton radio_Circulo;
        private System.Windows.Forms.TextBox txt_radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Base;
    }
}

