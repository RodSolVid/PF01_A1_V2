namespace PF01_A1_V2
{
	public class Productos
	{
		
		//propiedades
		public string nombre;
		public double precio;
		public string calidad;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public double Precio
		{
			get { return precio; }
			set { precio = value; }

		}
		public string Calidad
		{
			get { return calidad; }
			set { calidad = value; }
		}

		//Constructor
		public Productos(string nombre, double precio, string calidad)
		{
			this.nombre = nombre;
			this.precio = precio;
			this.calidad = calidad;
		}

		//Métodos
		public void MostrarDatosProductos()
		{
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Precio: " + precio);
			Console.WriteLine("Calidad: " + calidad);
		}

		

	}
}

