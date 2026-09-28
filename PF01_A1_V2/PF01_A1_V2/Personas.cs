using System;
using System.Collections.Generic;
using System.Text;

namespace PF01_A1_V2
{
    public class Personas
    {
        
            //Propiedades
            private string nombre;
        private int edad;
        private char sexo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        //Constructor
        public Personas(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        //Métodos
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Sexo: {sexo}");
        }

        public void CumplirAnios()
        {
            edad++;
            Console.WriteLine(nombre + " ha cumplido " + edad + " años.");
        }

		public void MayorEdad()
		{
			if (edad >= 18)
			{
				Console.WriteLine(nombre + " es mayor de edad.");
			}
			else
			{
				Console.WriteLine(nombre + " es menor de edad.");
			}
		}
	}
    
}

