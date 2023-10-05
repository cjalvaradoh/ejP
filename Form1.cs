using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejPrograAgregarLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "ingre1234")
            {
                // Los datos son correctos, abre el Form2.
                Form2 form2 = new Form2();
                form2.ShowDialog(); // Mostrar Form2 como un diálogo modal.
            }
            else
            {
                MessageBox.Show("Datos INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
