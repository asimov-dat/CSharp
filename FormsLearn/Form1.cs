using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLearn
{
    public partial class Form1 : Form // parcial es cuando es muy grande : hereda de la clase form
    {
        public Form1() // constructor!!!
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            this.tbxHolaMundo.Text += "Ser";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.tbxHolaMundo.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // this.tbxHolaMundo.Text = "O no Ser";
            MessageBox.Show("Crash");
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void Validar(TextBox textbox)
        {
            if (textbox.Text == string.Empty)
            {
                textbox.Text = "Lo llene con algo";
                MessageBox.Show("Estaba vacio fue llenado");
            }
            else if (textbox.Text != string.Empty)
            {
                MessageBox.Show(textbox.Text);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Validar(this.tbxHolaMundo);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
