using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DIP
{
    public class BussinessLogicLayer
    {
        private static List<Provider> providers;
        

        public void ComputeSomething()
        {
			int stuff;
            foreach(Provider pv in providers)
				stuff += pv.ProvideSomething();          
            
        }
    }
	
	public class Provider
    {
        public int ProvideSomething()
        {
            throw new NotImplementedException();
        }
    }
	
	 public class ProviderType2 : Provider
    {
        public int ProvideSomething()
        {
            throw new NotImplementedException();
        }
    }
}