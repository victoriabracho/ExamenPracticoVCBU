using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPracticoVCBU
{
    public partial class AvionForm : Form
    {
        private Concesionario concesionario = new Concesionario();  // Instancia de Concesionario
        public AvionForm(Concesionario concesionario)
        {
            InitializeComponent();
            this.concesionario = concesionario;
        }

        private void btnAlmacenarCarro_Click(object sender, EventArgs e)
        {
            string nombreAvion = textBox1.Text; //REVISAR
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int año = int.Parse(txtAño.Text);

            // Crear el nuevo avión con los datos proporcionados
            Avion nuevoAvion = new Avion(nombreAvion, marca, modelo, año);

            // Agregar el avión al concesionario
            concesionario.AgregarAvion(nuevoAvion);

            // Mostrar un mensaje de confirmación
            MessageBox.Show("Avión almacenado con éxito");
            lstAviones.Items.Clear();

            // Limpiar los campos de texto después de almacenar el avión
            textBox1.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual 
            this.Close();

            // Mostrar nuevamente Form1
            Form1 form1 = Application.OpenForms["Form1"] as Form1;  // Obtener la instancia de Form1
            if (form1 != null)
            {
                form1.Show();  // Mostrar Form1 si está oculto
            }
        }

        private void btnEliminarCarro_Click(object sender, EventArgs e)
        {
            string AvionAEliminar = txtNombreEliminar.Text;  // Obtener el nombre del TextBox

            if (!string.IsNullOrEmpty(AvionAEliminar))  // Validar que el campo no esté vacío
            {
                bool eliminado = concesionario.EliminarAvionPorNombre(AvionAEliminar);

                if (eliminado)
                {
                    MessageBox.Show("Avión eliminado con éxito");
                    lstAviones.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún avión con ese nombre");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa el nombre de un avión para eliminar");
            }

            txtNombreEliminar.Clear();
        }

        private void btnActualizarCarro_Click(object sender, EventArgs e)
        {
            string nombreAntiguo = txtNombreAntiguo.Text;  // Nombre del avión a actualizar
            string nuevoNombre = txtNombreNuevo.Text;      // Nuevo nombre
            string nuevaMarca = txtNuevaMarca.Text;        // Nueva marca
            string nuevoModelo = txtNuevoModelo.Text;      // Nuevo modelo
            int nuevoAño;

            // Validar que el campo de nuevo año sea un número válido
            if (!int.TryParse(txtNuevoAño.Text, out nuevoAño))
            {
                MessageBox.Show("El año debe ser un número válido");
                return;
            }

            // Actualizar el avión en el concesionario
            bool actualizado = concesionario.ActualizarAvion(nombreAntiguo, nuevoNombre, nuevaMarca, nuevoModelo, nuevoAño);

            if (actualizado)
            {
                MessageBox.Show("Avión actualizado con éxito");
                lstAviones.Items.Clear();
            }
            else
            {
                MessageBox.Show("No se encontró ningún avión con ese nombre");
            }

            txtNombreAntiguo.Clear();
            txtNombreNuevo.Clear();
            txtNuevaMarca.Clear();
            txtNuevoModelo.Clear();
            txtNuevoAño.Clear();
        }

        private void lstAviones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BttListarCarros_Click(object sender, EventArgs e)
        {
            lstAviones.Items.Clear();

            // Obtener la lista de aviones almacenados
            List<Avion> avionesAlmacenados = concesionario.ObtenerAviones();

            // Verificar si hay aviones almacenados
            if (avionesAlmacenados.Count > 0)
            {
                // Agregar cada avión al ListBox
                foreach (Avion avion in avionesAlmacenados)
                {
                    lstAviones.Items.Add($"{avion.Nombre} - {avion.Marca} - {avion.Modelo} - {avion.Año}");
                }
            }
            else
            {
                MessageBox.Show("No hay aviones almacenados");
            }
        }
    }
}
