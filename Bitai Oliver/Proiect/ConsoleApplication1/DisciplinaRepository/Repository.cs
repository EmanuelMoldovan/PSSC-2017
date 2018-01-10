using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplinaRepository
{
    public class Repository
    {
        private static List<DisciplinaFactory.Disciplina> ListaDiscipline = new List<DisciplinaFactory.Disciplina>();

        public void AdaugaDisciplina(DisciplinaFactory.Disciplina disciplina)
        {
            ListaDiscipline.Add(disciplina);
        }

        public void StergeDisciplina(DisciplinaFactory.Disciplina disciplina)
        {
            ListaDiscipline.Remove(disciplina);
        }

        public override string ToString()
        {
            string sir = "";
            if (ListaDiscipline.Count > 0)
            {
                foreach (DisciplinaFactory.Disciplina d in ListaDiscipline)
                {
                    sir += d.ToString();
                }
            }
            else
            {
                sir = "Nu exista nici o disciplina \n";
            }
            return sir;
        }

    }
}
