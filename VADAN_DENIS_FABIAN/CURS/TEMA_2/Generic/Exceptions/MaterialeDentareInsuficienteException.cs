using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Exceptions.MaterialeDentareInsuficienteException
{
    class MaterialeDentareInsuficienteException : Exception
    {
        public MaterialeDentareInsuficienteException()
        {
            Console.WriteLine("Materiale dentare insuficiente!");
        }
    }
}
