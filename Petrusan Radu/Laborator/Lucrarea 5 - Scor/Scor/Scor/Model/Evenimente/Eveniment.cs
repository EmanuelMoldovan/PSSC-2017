using System;

namespace Scor
{
	public class Eveniment
	{
		public Guid Id { get; private set; }
		public object Detalii { get; private set; }

		public Eveniment(object detalii)
		{
			Detalii = detalii;
			Id = Guid.NewGuid();
		}
	}

	public class EvenimentGeneric<T>: Eveniment 
	{
		public EvenimentGeneric(T detalii)
			: base(detalii)
		{
		}
	}
}