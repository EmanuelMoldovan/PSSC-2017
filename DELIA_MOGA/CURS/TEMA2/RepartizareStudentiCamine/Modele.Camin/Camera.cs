using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Camin
{
    public class Camera
    {
        public List<Student> Studenti { get; set; }
        public int NumarCamera { get; set; }
        public int NumarLocuriCamera { get; set; }
        public bool esteGoala;
        public bool EsteGoala
        {
            get { return esteGoala; }
            set { this.esteGoala = (this.Studenti.Count() == 0) ? true : false; }
        }
        public bool estePlina;
        public bool EstePlina
        {
            get { return estePlina; }
            set { this.estePlina = (this.Studenti.Count() == this.NumarLocuriCamera) ? true : false; }
        }

        public Camera(List<Student> studenti, int numarCamera, int numarLocuriCamera)
        {
            Studenti = studenti;
            NumarCamera = numarCamera;
            NumarLocuriCamera = numarLocuriCamera;
        }
    }
}
