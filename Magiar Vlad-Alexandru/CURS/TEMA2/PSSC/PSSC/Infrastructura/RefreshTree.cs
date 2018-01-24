using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PSSC
{
   public  class RefreshTree
    {
        String _path = Environment.CurrentDirectory.ToString() + "\\in.xml";
       public XmlDocument import_xml = new XmlDocument();
        Hotel h1;
        TreeView treeView1;
        TextBox nume, startDate, stopDate;

        public RefreshTree(Hotel h1, TreeView treeView1,TextBox t1)
        {
            H1 = h1;
            TreeView1 = treeView1;
            Nume = t1;
        }

        public Hotel H1 { get => h1; set => h1 = value; }
        public TreeView TreeView1 { get => treeView1; set => treeView1 = value; }
        public TextBox Nume { get => nume; set => nume = value; }

        public void refresh()
        {
            
            import_xml.Load(_path);
            XmlElement root = import_xml.DocumentElement;
            XmlNodeList floor = root.SelectNodes("//Floor");
            Floor _floor;
            List<Floor> _floors = new List<Floor>();

            foreach (XmlNode child in floor)
            {
                List<Room> _rooms = new List<Room>();
                for (int i = 0; i < child.ChildNodes.Count; i++)
                {

                    Room room = new Room(Int32.Parse(child.ChildNodes[i].Attributes["Nr"].InnerText),
                        Int32.Parse(child.ChildNodes[i].Attributes["Pers"].InnerText),
                        child.ChildNodes[i].Attributes["Vacancy"].InnerText,
                        child.ChildNodes[i].Attributes["Name"].InnerText,
                        child.ChildNodes[i].Attributes["Start"].InnerText,
                        child.ChildNodes[i].Attributes["End"].InnerText);

                    _rooms.Add(room);
                }
                _floor = new Floor(Int32.Parse(child.Attributes["Nr"].InnerText), _rooms);
                _floors.Add(_floor);
            }

            Form1.h1 = new Hotel(_floors);
            TreeView1.Nodes.Clear();
            
            RefreshFields RF = new RefreshFields(Nume);
            RF.Refresh();

            foreach (Floor f in Form1.h1.floors)
            {
                TreeView1.Nodes.Add("Floor " + f.Number);
                foreach (Room r in f.Rooms)
                {
                    TreeView1.Nodes[f.Number - 1].Nodes.Add("Room Nr." + r.Number+"..."+r.Pers+" Pers.");
                    if (r.Vacancy == "vacant")
                    {
                        TreeView1.Nodes[f.Number - 1].Nodes[r.Number % 10 - 1].BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        CheckEndDate a = new CheckEndDate(r.End_date);    
                        if (a.Check()==1)
                            TreeView1.Nodes[f.Number - 1].Nodes[r.Number % 10 - 1].BackColor = System.Drawing.Color.BlueViolet;
                        else
                            TreeView1.Nodes[f.Number - 1].Nodes[r.Number % 10 - 1].BackColor = System.Drawing.Color.Red;
                    }
                }
            }
            ExpandTree ET = new ExpandTree(TreeView1);
            ET.expand();
           
        }
    }
}
