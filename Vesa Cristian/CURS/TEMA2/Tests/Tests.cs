using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Models.Banca;
using Models.FilialaBanca;
using Models.Generic;
using MyFactory;
using BancaRepository;

namespace Tests
{
    public class Tests
    {
        public void creazaBanca()
        {
            var banca = BancaFactory.Instance.creazaBanca("Banca Transilvania");
            Assert.is
        }
    }
}
