using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSC
{
    public class Reserve
    {
        private TreeView treeView1;
        private Hotel h1;
        private string text1;
        private string text2;
        private string text3;

        public Reserve(TreeView treeView1, Hotel h1, string text1, string text2, string text3)
        {
            TreeView1 = treeView1;
            H1 = h1;
            Text1 = text1;
            Text2 = text2;
            Text3 = text3;
        }

        public TreeView TreeView1 { get => treeView1; set => treeView1 = value; }
        public Hotel H1 { get => h1; set => h1 = value; }
        public string Text1 { get => text1; set => text1 = value; }
        public string Text2 { get => text2; set => text2 = value; }
        public string Text3 { get => text3; set => text3 = value; }

        public void AddReservation()
        {
            string[] s = TreeView1.SelectedNode.Text.Split('.');
            if (TreeView1.SelectedNode.Level == 1)
            {
                foreach (Floor f in H1.floors)
                {
                    foreach (Room r in f.Rooms)
                    {
                        if (s[1] == r.Number.ToString())
                        {
                            H1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Name = Text1;
                            H1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Start_date = Text2;
                            H1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].End_date = Text3;
                            H1.floors[f.Number - 1].Rooms[r.Number % 10 - 1].Vacancy = "occupied";
                            UpdateXml a = new UpdateXml(h1);
                            a.update();

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
