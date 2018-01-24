using Scor.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Scor.Model
{
	public class Meci
	{
		private readonly List<Eveniment> _evenimenteNoi=new List<Eveniment>();
		public ReadOnlyCollection<Eveniment> EvenimenteNoi
		{
			get
			{
				return _evenimenteNoi.AsReadOnly();
			}
		}

		public string Echipa1 { get; private set; }
		public string Echipa2 { get; private set; }

		public DateTime Data { get; private set; }
		public DateTime DataStart { get; private set; }

		public StareMeci Stare { get; private set; }

		public Goluri GoluriEchipa1 { get; private set; }
		public Goluri GoluriEchipa2 { get; private set; }

		public event EventHandler<Eveniment> EvenimentMeci;

		public Meci(MeciDto meciDto)
		{
			Echipa1 = meciDto.Echipa1;
			Echipa2 = meciDto.Echipa2;
			Data = meciDto.Data;
			GoluriEchipa1 = new Goluri();
			GoluriEchipa2 = new Goluri();

			PublicaEveniment(new EvenimentGeneric<MeciDto>(meciDto));
		}

		public void Start()
		{
			DataStart = DateTime.Now;

			PublicaEveniment(new EvenimentGeneric<DateTime>(DataStart));
		}

		public void Marcheaza(GolMarcatDto golMarcat)
		{
			golMarcat.Minut = (byte)Math.Ceiling((DateTime.Now - DataStart).TotalMinutes);
			if (Echipa1 == golMarcat.NumeEchipa)
			{
				GoluriEchipa1 = new Goluri(GoluriEchipa1.NumarGoluri + 1);
			}
			else if (Echipa2 == golMarcat.NumeEchipa)
			{
				GoluriEchipa2 = new Goluri(GoluriEchipa2.NumarGoluri + 1);
			}
			var eveniment = new EvenimentGeneric<GolMarcatDto>(golMarcat);
			PublicaEveniment(eveniment);
		}

		protected void PublicaEveniment(Eveniment eveniment)
		{
			_evenimenteNoi.Add(eveniment);
			if (EvenimentMeci != null)
			{
				EvenimentMeci(this, eveniment);
			}
		}
	}
}