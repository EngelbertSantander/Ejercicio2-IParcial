using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_IParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarButton2_Click(object sender, EventArgs e)
        {
            Nota1Txt.Clear();
            Nota2Txt.Clear();
            Nota3Txt.Clear();
            Nota4Txt.Clear();
        }

        private async void CalcularButton1_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(Nota1Txt.Text);
            decimal num2 = Convert.ToDecimal(Nota2Txt.Text);
            decimal num3 = Convert.ToDecimal(Nota3Txt.Text);
            decimal num4 = Convert.ToDecimal(Nota4Txt.Text);

            decimal resultado = num1+ num2 + num3 + num4;
            decimal promedio = await PromedioAsync(num1, num2, num3, num4);

            MessageBox.Show("El promedio del estudiante es: " + promedio);
        }
        private async Task<decimal> PromedioAsync(decimal num1, decimal num2, decimal num3, decimal num4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return num1+ num2+ num3+ num4;
            });
            return promedio / 4;
        }
    }
}
