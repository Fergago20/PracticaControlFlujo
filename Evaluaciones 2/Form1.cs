using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.clase;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Alumno[] alum = new Alumno[10]; // Arreglo que almacena un máximo de 10 alumnos.
        int index = 0; // Índice que lleva la cuenta del número de alumnos registrados.

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            double nota;

            // Validación de entrada vacía
            if (string.IsNullOrEmpty(tbNom.Text) || string.IsNullOrEmpty(tbPuntaje.Text))
            {
                MessageBox.Show("Error de entrada");
            }
            else
            {
                try
                {
                    nombre = tbNom.Text;
                    nota = double.Parse(tbPuntaje.Text);

                    // Validación de rango del puntaje
                    if (nota <= 100 && nota >= 0)
                    {
                        // Verificar que el índice no sobrepase el límite del arreglo
                        if (index < alum.Length)
                        {
                            alum[index] = new Alumno(nombre, nota); // Agregar alumno al arreglo
                            Agregar(); // Actualizar la lista y las etiquetas
                            index++; // Incrementar el contador de alumnos
                        }
                        else
                        {
                            MessageBox.Show("No se pueden agregar más alumnos, la lista está llena.");
                        }

                        // Limpiar los campos después de agregar el alumno
                        tbNom.Clear();
                        tbPuntaje.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error de rango");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // Método para actualizar el ListBox y mostrar el primer, segundo, tercer lugar y el promedio
        void Agregar()
        {
            double promedio = 0;

            // Limpiar ListBox antes de agregar los elementos actualizados
            lbEstudiantes.Items.Clear();

            // Ordenamiento burbuja por puntaje (descendente)
            if (index >= 1)
            {
                for (int i = 0; i <= index - 1; i++)
                {
                    for (int j = 0; j <= index - i - 1; j++)
                    {
                        if (alum[j].Puntaje < alum[j + 1].Puntaje) // Orden descendente
                        {
                            Alumno temp = alum[j];
                            alum[j] = alum[j + 1];
                            alum[j + 1] = temp;
                        }
                    }
                }
            }

            // Agregar estudiantes al ListBox y calcular el promedio
            for (int i = 0; i <= index; i++)
            {
                lbEstudiantes.Items.Add("Nombre: " + alum[i].Nombre + " - Puntaje: " + alum[i].Puntaje);
                promedio += alum[i].Puntaje;
            }

            promedio /= index + 1;

            // Reiniciar los textos de los labels antes de asignar los nuevos valores
            lblPrimero.Text = "1er Lugar: ";
            lbSegundo.Text = "2do Lugar: ";
            lbTercero.Text = "3er Lugar: ";
            lblPromedio.Text = "Promedio: " + promedio;

            // Verificar cuántos alumnos hay antes de mostrar los tres primeros lugares
            if (index >= 0)
                lblPrimero.Text += alum[0].Nombre + " " + alum[0].Puntaje;

            if (index >= 1)
                lbSegundo.Text += alum[1].Nombre + " " + alum[1].Puntaje;

            if (index >= 2)
                lbTercero.Text += alum[2].Nombre + " " + alum[2].Puntaje;
        }
    }
}
