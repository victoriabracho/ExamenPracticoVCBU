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
    public partial class MotoForm : Form
    {
        private Concesionario concesionario = new Concesionario();  // Instancia de Concesionario

        public MotoForm(Concesionario concesionario)
        {
            InitializeComponent();
            this.concesionario = concesionario;
        }

        private void btnAlmacenarCarro_Click(object sender, EventArgs e)
        {
            string nombreMoto = textBox1.Text; //REVISAR
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int año = int.Parse(txtAño.Text);

            // Crear la nueva moto con los datos proporcionados
            Moto nuevaMoto = new Moto(nombreMoto, marca, modelo, año);

            // Agregar la moto al concesionario
            concesionario.AgregarMoto(nuevaMoto);

            // Mostrar un mensaje de confirmación
            MessageBox.Show("Moto almacenada con éxito");
            lstMotos.Items.Clear();

            // Limpiar los campos de texto después de almacenar la moto
            textBox1.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
        }

        private void BttListarCarros_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar las motos para evitar duplicados
            lstMotos.Items.Clear();

            // Obtener la lista de motos almacenadas
            List<Moto> motosAlmacenadas = concesionario.ObtenerMotos();

            // Verificar si hay motos almacenadas
            if (motosAlmacenadas.Count > 0)
            {
                // Agregar cada moto al ListBox
                foreach (Moto moto in motosAlmacenadas)
                {
                    lstMotos.Items.Add($"{moto.Nombre} - {moto.Marca} - {moto.Modelo} - {moto.Año}");
                }
            }
            else
            {
                MessageBox.Show("No hay motos almacenadas");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevoAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevaMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevoModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreAntiguo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCarros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarCarro_Click(object sender, EventArgs e)
        {
            string nombreAntiguo = txtNombreAntiguo.Text;  // Nombre de la moto a actualizar
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

            // Actualizar la moto en el concesionario
            bool actualizado = concesionario.ActualizarMoto(nombreAntiguo, nuevoNombre, nuevaMarca, nuevoModelo, nuevoAño);

            if (actualizado)
            {
                MessageBox.Show("Moto actualizada con éxito");
                lstMotos.Items.Clear();
            }
            else
            {
                MessageBox.Show("No se encontró ninguna moto con ese nombre");
            }

            txtNombreAntiguo.Clear();
            txtNombreNuevo.Clear();
            txtNuevaMarca.Clear();
            txtNuevoModelo.Clear();
            txtNuevoAño.Clear();
        }

        private void btnEliminarCarro_Click(object sender, EventArgs e)
        {
            string MotoAEliminar = txtNombreEliminar.Text;  // Obtener el nombre del TextBox

            if (!string.IsNullOrEmpty(MotoAEliminar))  // Validar que el campo no esté vacío
            {
                bool eliminado = concesionario.EliminarMotoPorNombre(MotoAEliminar);

                if (eliminado)
                {
                    MessageBox.Show("Moto eliminada con éxito");
                    lstMotos.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna moto con ese nombre");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa el nombre de una moto para eliminar");
            }

            txtNombreEliminar.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
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
    }
}
