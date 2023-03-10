using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Aereo
{
    public class ClaseMarca
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

        // Atributos  

        private string _turno;

        //Constructores 

        public ClaseMarca()

        {

        }
        public ClaseMarca(string turno)

        {

            Turno = turno;

        }

        public ClaseMarca(string modelo, int marca, string color, int kilimetraje, int peso, double año, string motor, int asientos, int puertas, int placa, string velocidad)

           : base(modelo, marca, color, kilimetraje, peso, año,motor, asientos, puertas, placa, velocidad)
        {
            Turno = _turno;
        }

        //GET y SET 

        public string Turno { get => _turno; set => _turno = value; }
        // Override del método nombreCompleto de clasePersona para Doctor 
        public override String DetalleCompleto()

        {
            return string.Format("Modelo: {0} + Marca: {1} + Color: {2} + Kilometraje: {3} + Peso: {4} + Año: {5} + Motor: {6} + Asientos: {7}+  Puertas: {8}+  Placa: {9} +  Velocidad: {10} ",

               _Modelo, _Marca, _Color, _Kilometraje, _Peso, _Año, _Motor, _Asientos, _Puertas, _Velocidad);

        }

    }

}