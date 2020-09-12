using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromAutomoviles
{
    class Automoviles
    {
		public string Modelo { set; get; }
		public string Placa { set; get; }
		public int Kilometraje { set; get; }
		public string Dueño { set; get; }

		public Automoviles()
		{
		}

		public Automoviles(string modelo, string placa, int kilometraje, string dueño)
		{
			Modelo = modelo;
			Placa = placa;
			Kilometraje = kilometraje;
			Dueño = dueño;
		}
	}
}
