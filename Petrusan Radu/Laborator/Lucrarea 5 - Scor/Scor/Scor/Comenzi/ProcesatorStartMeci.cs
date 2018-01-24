using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scor.Comenzi
{
	public class ProcesatorStartMeci
	{
		public void Procesare(ComandaStartMeci comanda)
		{
			var repo = new WriteRepository();
			repo.GasesteMeci(comanda.Meci);
		}
	}
}
