using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsLearn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Escribir(TextBox textbox, string texto)
        {
            textbox.Text = texto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Escribir(this.textBox2, "Soy el 2 :)");
            //Escribir(this.textBox1, "Hola tbx 1");



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
        //private MessageBox Mensaje(string mostar)
        //{
        //    return MessageBox.Show("mostrar");
        //}
    }
}
