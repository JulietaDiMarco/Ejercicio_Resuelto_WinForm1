using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Resuelto
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if(radio_Rectangulo.Checked && txt_Base.Text.Length!=0 && txt_altura.Text.Length!=0)
            {
                if(float.TryParse(txt_Base.Text, out _)&& float.TryParse(txt_altura.Text, out _))
                txt_area.Text = Convert.ToString(float.Parse(txt_Base.Text) * float.Parse(txt_altura.Text));
            }
            else
            {
                if(radio_Circulo.Checked && txt_radio.Text.Length != 0)
                {
                    if (float.TryParse(txt_radio.Text, out _))
                        txt_area.Text = Convert.ToString((float.Parse(txt_radio.Text) * float.Parse(txt_radio.Text))*Math.PI);
                }
                else
                {
                    if (radio_Triangulo.Checked&& txt_Base.Text.Length != 0 && txt_altura.Text.Length != 0)
                    {
                        if (float.TryParse(txt_Base.Text, out _) && float.TryParse(txt_altura.Text, out _))
                            txt_area.Text = Convert.ToString(float.Parse(txt_Base.Text) * float.Parse(txt_altura.Text) * 0.5);
                    }
                }
            }
        }

        private void radio_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Rectangulo.Checked)
            {
                txt_altura.Enabled = true;
                txt_Base.Enabled = true;
                txt_radio.Enabled= false;
            }
        }

        private void radio_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Triangulo.Checked)
            {
                txt_altura.Enabled = true;
                txt_Base.Enabled = true;
                txt_radio.Enabled = false;
            }
        }

        private void radio_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Circulo.Checked)
            {
                txt_altura.Enabled = false;
                txt_Base.Enabled = false;
                txt_radio.Enabled = true;
            }
        }
    
    }
}
