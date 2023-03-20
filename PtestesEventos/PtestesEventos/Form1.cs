using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtestesEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13)) //tecla que foi pressionada, foi ENTER
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            //endereço
            if ((textBox2.Text == "") || (textBox2.Text.Length < 20))
            {
                MessageBox.Show("Endereço Inválido");
                textBox2.Focus();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //e-mail
            if (textBox3.Text=="")
            {
                MessageBox.Show("E-mail vazio");

                e.Cancel=true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Celular-textbox perdeu o foco");

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("CPF-textbox5 ganhou o foco");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
