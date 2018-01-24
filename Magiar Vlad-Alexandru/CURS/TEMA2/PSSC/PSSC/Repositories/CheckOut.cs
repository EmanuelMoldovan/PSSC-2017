using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSC
{
    public class CheckOut
    {
        TreeView t; Hotel h1;
        public CheckOut(TreeView t, Hotel h1)
        {
          T = t;
           H1 = h1;
        }

        public TreeView T { get => t; set => t = value; }
        public Hotel H1 { get => h1; set => h1 = value; }

        public void DeleteReservationEntry()
        {
            string[] s = t.SelectedNode.Text.Split('.');
            if (t.SelectedNode.Level == 1)
            {
                foreach (Floor f in h1.floors)
                {
                    foreach (Room r in f.Rooms)
                    {
                        if (s[1] == r.Number.ToString())
                        {
                            CalculatePeriod CP = new CalculatePeriod(h1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Start_date);                                             
                            CalculateBill CB = new CalculateBill(h1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Pers, CP.period());
                            h1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Name = string.Empty;
                            h1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Start_date = string.Empty;
                            h1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].End_date = string.Empty;
                            h1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Vacancy = "vacant";
                            UpdateXml a = new UpdateXml(h1);
                            a.update();

                            MessageBox.Show(CB.Total() + "€");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a room!");
            }
        }
    }
}
