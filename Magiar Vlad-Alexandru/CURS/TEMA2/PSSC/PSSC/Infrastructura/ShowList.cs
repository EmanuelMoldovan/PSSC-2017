using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PSSC
{
    public class ShowList
    {
        ListView listView1; TreeViewEventArgs e;
        Hotel h1;
        public ShowList(ListView listView1, TreeViewEventArgs e,Hotel h1)
        {
            ListView1 = listView1;
            E = e;
            H1 = h1;
        }

        public ListView ListView1 { get => listView1; set => listView1 = value; }
        public TreeViewEventArgs E { get => e; set => e = value; }
        public Hotel H1 { get => h1; set => h1 = value; }

        public void show()
        {
            ListView1.Items.Clear();
            string[] s =E.Node.Text.Split('.');
            if (E.Node.Level == 1)
                foreach (Floor f in H1.floors)
                {
                    foreach (Room r in f.Rooms)
                    {
                        if (s[1] == r.Number.ToString())
                        {
                            ListViewItem lv = new ListViewItem();
                            lv.Text = r.Name;
                            lv.SubItems.Add(r.Start_date);
                            lv.SubItems.Add(r.End_date);
                            listView1.Items.Insert(0, lv);
                        }
                    }
                }
        }
    }
}
