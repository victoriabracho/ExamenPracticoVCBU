using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPracticoVCBU
{
    using System.Collections.Generic;

    public class Concesionario
    {
        private List<Carro> listaCarros = new List<Carro>();
        private List<Moto> listaMotos = new List<Moto>();
        private List<Avion> listaAviones = new List<Avion>();

        // MÉTODOS PARA AGREGAR VEHÍCULOS
        public void AgregarCarro(Carro carro)
        {
            listaCarros.Add(carro);
        }

        public void AgregarMoto(Moto moto)
        {
            listaMotos.Add(moto);
        }

        public void AgregarAvion(Avion avion)
        {
            listaAviones.Add(avion);
        }

        // MÉTODOS PARA OBTENER LISTAS DE VEHÍCULOS
        public List<Carro> ObtenerCarros()
        {
            return listaCarros;
        }

        public List<Moto> ObtenerMotos()
        {
            return listaMotos;
        }

        public List<Avion> ObtenerAviones()
        {
            return listaAviones;
        }

        // MÉTODO PARA MOSTRAR TODAS LAS LISTAS DE VEHÍCULOS JUNTAS
        public List<string> MostrarTodosLosVehiculos()
        {
            List<string> todosVehiculos = new List<string>();

            foreach (Carro carro in listaCarros)
            {
                todosVehiculos.Add($"Carro: {carro.Nombre} - {carro.Marca} - {carro.Modelo}");
            }

            foreach (Moto moto in listaMotos)
            {
                todosVehiculos.Add($"Moto: {moto.Nombre} - {moto.Marca} - {moto.Modelo}");
            }

            foreach (Avion avion in listaAviones)
            {
                todosVehiculos.Add($"Avión: {avion.Nombre} - {avion.Marca} - {avion.Modelo}");
            }

            return todosVehiculos;
        }

        // MÉTODOS PARA ELIMINAR VEHÍCULOS POR NOMBRE (MARCA)
        public bool EliminarCarroPorNombre(string nombre)
        {
            for (int i = 0; i < listaCarros.Count; i++)
            {
                if (listaCarros[i].Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase))//HACE LA COMPARACION SIN TOMAR EN CUENTA MAYUSCULAS O MINUSCULAS
                {
                    listaCarros.RemoveAt(i);  // Eliminar el carro de la lista
                    return true;
                }
            }
            return false;  // Si no se encuentra el carro
        }

        public bool EliminarMotoPorNombre(string nombre)
        {
            for (int i = 0; i < listaMotos.Count; i++)
            {
                if (listaMotos[i].Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    listaMotos.RemoveAt(i);  // Eliminar la moto de la lista
                    return true;
                }
            }
            return false;  // Si no se encuentra la moto
        }

        public bool EliminarAvionPorNombre(string nombre)
        {
            for (int i = 0; i < listaAviones.Count; i++)
            {
                if (listaAviones[i].Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    listaAviones.RemoveAt(i);  // Eliminar el carro de la lista
                    return true;
                }
            }
            return false;  // Si no se encuentra el carro
        }


        // MÉTODOS PARA ACTUALIZAR VEHÍCULOS POR NOMBRE (MARCA)
        public bool ActualizarCarro(string nombreAntiguo, string nuevoNombre, string nuevaMarca, string nuevoModelo, int nuevoAño)
        {
            for (int i = 0; i < listaCarros.Count; i++)
            {
                if (listaCarros[i].Nombre.Equals(nombreAntiguo.Trim(), StringComparison.OrdinalIgnoreCase))    // Buscar por el nombre antiguo
                {
                    // Actualizar las propiedades del carro
                    listaCarros[i].Nombre = nuevoNombre;
                    listaCarros[i].Marca = nuevaMarca;
                    listaCarros[i].Modelo = nuevoModelo;
                    listaCarros[i].Año = nuevoAño;
                    return true;
                }
            }
            return false;  // Si no se encuentra el carro
        }

        //MÉTODO PARA ACTUALIZAR MOTO POR NOMBRE
        public bool ActualizarMoto(string nombreAntiguo, string nuevoNombre, string nuevaMarca, string nuevoModelo, int nuevoAño)
        {
            for (int i = 0; i < listaMotos.Count; i++)
            {
                if (listaMotos[i].Nombre.Equals(nombreAntiguo.Trim(), StringComparison.OrdinalIgnoreCase))    // Buscar por el nombre antiguo
                {
                    // Actualizar las propiedades del carro
                    listaMotos[i].Nombre = nuevoNombre;
                    listaMotos[i].Marca = nuevaMarca;
                    listaMotos[i].Modelo = nuevoModelo;
                    listaMotos[i].Año = nuevoAño;
                    return true;
                }
            }
            return false;  // Si no se encuentra el carro
        }

        //METODO PARA ACTUALIZAR AVION POR NOMBRE
        public bool ActualizarAvion(string nombreAntiguo, string nuevoNombre, string nuevaMarca, string nuevoModelo, int nuevoAño)
        {
            for (int i = 0; i < listaAviones.Count; i++)
            {
                if (listaAviones[i].Nombre.Equals(nombreAntiguo.Trim(), StringComparison.OrdinalIgnoreCase))    // Buscar por el nombre antiguo
                {
                    // Actualizar las propiedades del carro
                    listaAviones[i].Nombre = nuevoNombre;
                    listaAviones[i].Marca = nuevaMarca;
                    listaAviones[i].Modelo = nuevoModelo;
                    listaAviones[i].Año = nuevoAño;
                    return true;
                }
            }
            return false;  // Si no se encuentra el carro
        }
    }


}
