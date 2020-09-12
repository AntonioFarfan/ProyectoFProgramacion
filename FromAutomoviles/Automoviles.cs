using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromAutomoviles
{
    public class Automoviles
    {
		public string Placa { set; get; }
		public int Kilometraje { set; get; }
		public string Dueño { set; get; }

		public Automoviles()
		{
		}

		public Automoviles(string placa, int kilometraje, string dueño)
		{
			Placa = placa;
			Kilometraje = kilometraje;
			Dueño = dueño;
		}
	}
}
