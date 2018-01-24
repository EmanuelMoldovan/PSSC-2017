using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PSSC.Repositories
{
    public class GenericFileRepository
    {
        protected string _rootPath;

        protected GenericFileRepository(string rootPath)
        {
            _rootPath = rootPath;
        }

        public virtual string CitesteContinutFisier(string cale)
        {
            return File.ReadAllText(CompuneCaleFisier(cale));
        }

        public virtual bool ExistaFisier(string cale)
        {
            return File.Exists(CompuneCaleFisier(cale));
        }

        public virtual void ScrieContinutFisier(string cale, string continut)
        {
            File.WriteAllText(CompuneCaleFisier(cale), continut);
        }

        private string CompuneCaleFisier(string fisier)
        {
            if (!string.IsNullOrWhiteSpace(_rootPath))
            {
                return Path.Combine(_rootPath, fisier);
            }
            return fisier;
        }
    }
}
