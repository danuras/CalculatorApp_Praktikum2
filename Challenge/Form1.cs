using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMachine;

namespace Challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNilaiA.Text);
            int b = int.Parse(txtNilaiB.Text);

            var cal = new Calculator();
            int idx = cmbBoxOperation.SelectedIndex;
            txtHasil.Clear();
            if (idx == 0) txtHasil.AppendText(cal.Penambahan(a, b).ToString());
            if (idx == 1) txtHasil.AppendText(cal.Pengurangan(a, b).ToString());
            if (idx == 2) txtHasil.AppendText(cal.Perkalian(a, b).ToString());
            if (idx == 3) txtHasil.AppendText(Calculator.Pembagian(a, b).ToString());
            if (idx == 4) txtHasil.AppendText(cal.Pangkat(a, b).ToString());
            if (idx == 5) txtHasil.AppendText(Calculator.Modulo(a, b).ToString());
        }
    }
}
