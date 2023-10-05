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
    public partial class Form2 : Form
    {
        List<string> ListLibros = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Existen campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nuevoLibro;

                nuevoLibro = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                ListLibros.Add(nuevoLibro);

                // Actualiza la lista de libros en el ListBox.
                listBox1.DataSource = null;
                listBox1.DataSource = ListLibros;

                // Limpia los TextBox después de agregar un libro.
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Está seguro que desea cerrar el programa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Elimina el elemento seleccionado de la lista.
                ListLibros.RemoveAt(listBox1.SelectedIndex);

                // Actualiza la lista de libros en el ListBox.
                listBox1.DataSource = null;
                listBox1.DataSource = ListLibros;
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

