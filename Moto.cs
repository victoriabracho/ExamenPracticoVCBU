using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPracticoVCBU
{
    public class Moto
    {
        private string nombre;
        private string marca;
        private string modelo;
        private int año;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public Moto(string nombre, string marca, string modelo, int año)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
        }
    }

}
