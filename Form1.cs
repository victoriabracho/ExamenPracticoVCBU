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
    public partial class Form1 : Form
    {
        private Concesionario concesionario; ///SE HACE UNA INSTACIA DE CONCESIONARIO, PARA MANEJAR LISTAS
        public Form1()
        {
            InitializeComponent();
            concesionario = new Concesionario(); //INICIALIZA UN CONCESIONARIO
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarroForm carroForm = new CarroForm(concesionario);  // Crear una instancia de CarroForm
            this.Hide();
            carroForm.ShowDialog();

            // Mostrar el formulario principal nuevamente después de cerrar CarroForm
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MotoForm motoForm = new MotoForm(concesionario);  // Crear una instancia de CarroForm
            this.Hide();
            motoForm.ShowDialog();

            // Mostrar el formulario principal nuevamente después de cerrar CarroForm
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvionForm avionForm = new AvionForm(concesionario);  // Crear una instancia de CarroForm
            this.Hide();
            avionForm.ShowDialog();

            // Mostrar el formulario principal nuevamente después de cerrar CarroForm
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar todos los vehículos
            listBox1.Items.Clear();

            // Obtener la lista de todos los vehículos almacenados 
            List<string> todosVehiculos = concesionario.MostrarTodosLosVehiculos();  // Obtener todos los vehículos

            // Verificar si hay vehículos almacenados
            if (todosVehiculos.Count > 0)
            {
                // Agregar cada vehículo al ListBox
                foreach (string vehiculo in todosVehiculos)
                {
                    listBox1.Items.Add(vehiculo);  // Añadir la información del vehículo
                }
            }
            else
            {
                MessageBox.Show("No hay vehículos almacenados");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
