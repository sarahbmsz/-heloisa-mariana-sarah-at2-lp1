using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_2_BD1_INW_LP1_PDS___SARAH___MARIANA___HELOISA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			privade void button1_Click(object sender, EvenarAgrgs e)
			{
				double at, v, c, pt, p;

				if (ComboBox1.SelectedIndex == 0)
				{
					p = 150;

					at = 80;
				}

				else if (ComboBox1.SelectedIndex == 1)
				{
					p = 40;

					at = 50;
				}

				else if (ComboBox1.SelectedIndex == 2)
				{
					p = 100;

					at = 30;
				}

				else
				{
					MensageBox.Show(Escolha a ponte de sua preferência", MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}

				if (Double.TryParse(textCaixadetexto1.Text, out a) == false ││ Double TryParse;

				MessageBox("Coloque os dados solicitados", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (a > at)
			{
				MessageBox.Show("Altura Incorreta", "Resultado", MessageBoxButtons.OK, MessageIcon.Information);
			}

			else
			{
				MessageBox.Show("Altura correta", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			if ((v + c) > p)
				MessageBox.Show("Peso Incorreto", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}
	else
	{
		MessageBox.Show("Peso correto", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}

    

