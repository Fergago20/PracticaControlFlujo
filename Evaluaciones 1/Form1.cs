using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.moldes;

namespace Evaluaciones_1
{
    public partial class Form1 : Form
    {
        Estudiante estu = new Estudiante();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("Erro de entrada");
            }
            else
            {
                nombre = tbNombre.Text;
                estu.Agregar(nombre, index);
                index++;
                tbNombre.Clear();
                tbNombre.Focus();
                mostrar();
            }

            void mostrar()
            {
                lbAll.Items.Clear();
                lbLargos.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    lbAll.Items.Add(estu.Mostrar()[i]);
                    if (estu.Mostrar()[i].Length > 25)
                    {
                        lbLargos.Items.Add(estu.Mostrar()[i]);
                    }
                }

            }
        }
    }
}
