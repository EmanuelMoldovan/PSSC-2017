using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.Camin.DTO;

namespace Modele.Camin
{
    public class Camin
    {
        public PlainText NumeCamin { get; private set; }
        public PlainText NumeAdministrator { get; private set; }
        public int NumarCamere { get; private set; }
        public List<Camera> Camere = new List<Camera>();
        public Nota MedieMinimaNecesara { get; private set; }
        public int NumarLocuriCamera { get; set; }
        public bool estePlin;
        public bool EstePlin
        {
            get
            {
                bool indice = true;
                foreach (Camera camera in Camere)
                {
                    if (!camera.EstePlina)//nu este plina
                    {
                        indice = false;
                        break;
                    }
                }
                return indice;
            }
            set
            {
                this.estePlin = value;
            }
        }

        public Camin(PlainText numeCamin, PlainText numeAdministrator, int numarCamere, List<Camera> camere, Nota medieMinimaNecesara, int numarLocuriCamera)
        {
            NumeCamin = numeCamin;
            NumeAdministrator = numeAdministrator;
            NumarCamere = numarCamere;
            Camere = camere;
            MedieMinimaNecesara = medieMinimaNecesara;
            NumarLocuriCamera = numarLocuriCamera;
        }
        //public int NumarTotalLocuri(Camin c)
        //{
        //    int NrTotalLocuri = c.NumarCamere * c.NumarLocuriCamera;
        //    return NrTotalLocuri;
        //}
    }
}
