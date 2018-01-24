using Scor.Comenzi;
using Scor.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scor
{
	class Program
	{
		static void Main(string[] args)
		{
			var writeRepository = new WriteRepository();
			var meciNouDto = new MeciDto()
			{
				Data = DateTime.Now,
				Echipa1 = "Poli",
				Echipa2 = "FCSB"
			};
			writeRepository.ProgrameazaMeci(meciNouDto);

			//---------------------------------------------------

			var readRepository = new ReadRepository();
			var meci = readRepository.ObtineMeciuri().FirstOrDefault();
			Console.WriteLine(meci);

			var command = new ComandaStartMeci() { Meci = meci };
			var procesator = new ProcesatorStartMeci();
			procesator.Procesare(command);


			var command1 = new ComandaGolMarcat() { NumeEchipa = "Poli"};
			var procesator1 = new ProcesatorGolMarcat();
			procesator1.Procesare(command1);

			Console.ReadLine();
		}
	}
}
