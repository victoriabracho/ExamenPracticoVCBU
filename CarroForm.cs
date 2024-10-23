using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenPracticoVCBU
{
    public partial class CarroForm : Form
    {
        private Concesionario concesionario = new Concesionario();  // Instancia de Concesionario

        public CarroForm(Concesionario concesionario)
        {
            InitializeComponent();
            this.concesionario = concesionario;
        }

        private void button1_Click(object sender, EventArgs e) //AGREGAR CARRO BOTÓN
        {
            string nombreCarro = textBox1.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int año = int.Parse(txtAño.Text);

            // Crear el nuevo carro con los datos proporcionados
            Carro nuevoCarro = new Carro(nombreCarro, marca, modelo, año);

            // Agregar el carro al concesionario
            concesionario.AgregarCarro(nuevoCarro);

            // Mostrar un mensaje de confirmación
            MessageBox.Show("Carro almacenado con éxito");
            lstCarros.Items.Clear();

            // Limpiar los campos de texto después de almacenar el carro

            textBox1.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
        }

        private void CarroForm_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //LABEL MODELO
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //LABEL "NOMBRE" PARA ELIMINAR
        }


        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            //MARCA DEL CARRO BOX
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //LABEL "NOMBRE ANTIGUO DEL CARRO"
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //BOX NUEVA MARCA
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //LABEL "NUEVO MODELO"
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //LABEL "NUEVA MARCA"
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //LABEL NUEVO AÑO
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //BOX NUEVO AÑO
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //BOX NUEVO MODELO
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //LABEL "NUEVO NOMBRE"
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //BOX NUEVO NOMBRE
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            //LABEL "NOMBRE DEL CARRO"
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //NOMBRE DEL CARRO BOX
        }

        private void btnEliminarCarro_Click(object sender, EventArgs e) //BOTÓN DE ELIMINAR CARRO
        {
            string CarroAEliminar = txtNombreEliminar.Text;  // Obtener el nombre del TextBox

            if (!string.IsNullOrEmpty(CarroAEliminar))  // Validar que el campo no esté vacío
            {
                bool eliminado = concesionario.EliminarCarroPorNombre(CarroAEliminar);

                if (eliminado)
                {
                    MessageBox.Show("Carro eliminado con éxito");
                    lstCarros.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún carro con ese nombre");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa el nombre de un carro para eliminar");
            }

            txtNombreEliminar.Clear();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            //MODELO DEL CARRO BOX
        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {
            //AÑO DEL CARRO BOX
        }

        private void txtNombreEliminar_TextChanged(object sender, EventArgs e)
        {
            //NOMBRE DE CARRO A ELIMINAR LABEL
        }

        private void btnActualizarCarro_Click(object sender, EventArgs e)//BOTON DE ACTUALIZAR CARRO
        {
            
                string nombreAntiguo = txtNombreAntiguo.Text;  // Nombre del carro a actualizar
                string nuevoNombre = txtNombreNuevo.Text;      // Nuevo nombre
                string nuevaMarca = txtNuevaMarca.Text;        // Nueva marca
                string nuevoModelo = txtNuevoModelo.Text;      // Nuevo modelo
                int nuevoAño;

                // Validar que el campo de nuevo año sea un número válido
                if (!int.TryParse(txtNuevoAño.Text, out nuevoAño))//out indica que nuevoAño será una variable de salida si se hace la coversipon
                {
                    MessageBox.Show("El año debe ser un número válido");
                    return;
                }

                // Actualizar el carro en el concesionario
                bool actualizado = concesionario.ActualizarCarro(nombreAntiguo,nuevoNombre, nuevaMarca, nuevoModelo, nuevoAño);

                if (actualizado)
                {
                    MessageBox.Show("Carro actualizado con éxito");
                    lstCarros.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún carro con ese nombre");
                }

            txtNombreAntiguo.Clear();
            txtNombreNuevo.Clear();
            txtNuevaMarca.Clear();
            txtNuevoModelo.Clear();
            txtNuevoAño.Clear();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //BOX NOMBRE ANTIGUO DEL CARRO
        }

        private void button1_Click_1(object sender, EventArgs e)//LISTAR CARROS
        {
            // Limpiar el ListBox antes de mostrar los carros para evitar duplicados
            lstCarros.Items.Clear();

            // Obtener la lista de carros almacenados
            List<Carro> carrosAlmacenados = concesionario.ObtenerCarros();

            // Verificar si hay carros almacenados
            if (carrosAlmacenados.Count > 0)
            {
                // Agregar cada carro al ListBox
                foreach (Carro carro in carrosAlmacenados)
                {
                    lstCarros.Items.Add($"{carro.Nombre} - {carro.Marca} - {carro.Modelo} - {carro.Año}");
                }
            }
            else
            {
                MessageBox.Show("No hay carros almacenados");
            }
        }

        private void txtNombreEliminar_TextChanged_1(object sender, EventArgs e)
        {
            //BOX NOMBRE A ELIMINAR
        }

        private void button1_Click_2(object sender, EventArgs e)//REGRESAR AL MENU INICIAL
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

        private void lstCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LISTA DE CARROS
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //LABEL "AÑO"
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //LABEL "MARCA"
        }
    }
}
