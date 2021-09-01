using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_x1.Enabled = false;
            txt_x2.Enabled = false;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double a=0, b=0, c=0, x1=0, x2=0;

            

            try
            {
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);

                x1 = (-b + Math.Sqrt((b * b) - (4 * c * a))) / (2 * a);
                x2 = (-b - Math.Sqrt((b * b) - (4 * c * a))) / (2 * a);

                txt_x1.Text = Convert.ToString(x1);
                txt_x2.Text = Convert.ToString(x2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresar caracteres validos");
            }

        }
    }
}
