using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Dinheiro");
            listBox1.Items.Add("Cartão de crédito");
            listBox1.Items.Add("Cartão de Débito");
            listBox1.Items.Add("Pix");
            listBox1.Items.Add("Boleto");
            listBox1.SelectedIndex = 1; // deixar um pré selecionado
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") // if(TextBox1.text=string.empty)
                MessageBox.Show("nome está vazio");

            //if (checkBox1.Checked)
            //    MessageBox.Show("é a primeira viagem");
            //else
            //    MessageBox.Show("já viajou com a agância");

            if (checkBox1.CheckState == CheckState.Checked)
                MessageBox.Show("é a primeira viagem");
            else if (checkBox1.CheckState == CheckState.Unchecked)
                MessageBox.Show("já viajou com a agência");
            else
                MessageBox.Show("não informado se é primeira viagem");

            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("não selecionou destino");
            else
                MessageBox.Show("destino:"+comboBox1.SelectedItem);

            DateTime auxiliar;
            if (DateTime.TryParse(maskedTextBox1.Text, out auxiliar))
                MessageBox.Show("data ida:" + auxiliar.ToShortDateString());
            else
                MessageBox.Show("data ida invalida");

            Double valor;
            if (Double.TryParse(maskedTextBox3.Text, out valor))
                MessageBox.Show("valor:" + valor.ToString("N2"));
            else
                MessageBox.Show("valor inválido");

            string stringona = "";
            for (var i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                stringona = stringona + "\n" + 
                    checkedListBox1.CheckedItems[i].ToString();

            MessageBox.Show(stringona);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
