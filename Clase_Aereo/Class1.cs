using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia.Entidades1
{
    public class Class1
    {
        private string _Modelo;
        private int _Marca;
        private string _Color;
        private int _Peso;
        private int _Kilometraje;
        private double _Año;
        private string _Motor;
        private int _Asientos;
        private int _Puertas;
        private int _Placa;
        private string _Velocidad;

        //Constructores 

        public Class1()

        {
        }
        public Class1(string modelo, int marca, string color, int kilimetraje, int peso, double año, string motor, int asientos, int puertas, int placa, string velocidad)

        {
            _Modelo = modelo;
            _Marca = marca;
            _Color = color;
            _Peso = peso;
            _Kilometraje = kilimetraje;
            _Año = año;
            _Motor = motor;
            _Asientos = asientos;
            _Puertas = puertas;
            _Placa = placa;
            _Velocidad = velocidad;
        }
        //GET y SET 

        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public int Marca { get => _Marca; set => _Marca = value; }
        public string Color { get => _Color; set => _Color = value; }
        public int Peso { get => _Peso; set => _Peso = value; }
        public int Kilometraje  { get => _Kilometraje; set => _Kilometraje = value; }
        public double Año { get => _Año; set => _Año = value; }
        public string Motor { get => _Motor; set => _Motor = value; }
        public int Asientos { get => _Asientos; set => _Asientos = value; }
        public int Puertas { get => _Puertas; set => _Puertas = value; }
        public string Velocidad { get => _Velocidad; set => _Velocidad = value; }

        //método nombreCompleto que se sobreescribirá con EmpleadoTurno  
        public virtual String DetalleCompleto()
        {
            return string.Format("Modelo: " + _Modelo + "Marca: " + _Marca + "Color" + _Color + " Peso " + _Peso
                + " Kilometraje " + _Kilometraje + " Año " + _Año+ " Motor " + _Motor + "Asientos " + _Asientos + " Puertas " + _Puertas + " Placa " + _Placa + " Velocidad " + _Velocidad);

        }
    }
}