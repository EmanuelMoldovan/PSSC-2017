using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disciplina;
namespace DisciplinaRepository
{
    public class DisciplinaRepository
    {
        private static List<Disciplina.Disciplina> ListaDiscipline = new List<Disciplina.Disciplina>();

        public void AdaugaDisciplina(Disciplina.Disciplina disciplina)
        {
            ListaDiscipline.Add(disciplina);
        }

        public void StergeDisciplina(Disciplina.Disciplina disciplina)
        {
            ListaDiscipline.Remove(disciplina);
        }

        public override string ToString()
        {
            string sir ="";
            if (ListaDiscipline.Count>0)
            {
                foreach (Disciplina.Disciplina d in ListaDiscipline)
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
