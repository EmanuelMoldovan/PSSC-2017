using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IFileManager<T> where T : List<object>
    {
        void WriteToFile(T listaObiecte, String filePath);
        T ReadFromFile(String filePath);
    }
}
