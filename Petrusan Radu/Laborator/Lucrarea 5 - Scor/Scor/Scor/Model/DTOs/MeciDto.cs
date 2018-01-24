using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scor.Model.DTOs
{
	public struct MeciDto
	{
		public string Echipa1 { get; set; }
		public string Echipa2 { get; set; }
		public DateTime Data { get; set; }

		public override string ToString()
		{
			return string.Format("{0} - {1}", Echipa1, Echipa2);
		}
	}
}
