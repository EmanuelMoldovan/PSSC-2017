using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
namespace PSSC
{
    public partial class Form1 : Form
    {
        String _path = Environment.CurrentDirectory.ToString() + "\\in.xml";
        public XmlDocument import_xml = new XmlDocument();
        Floor _floor;
        public static Hotel h1;
        public Form1()
        {
            InitializeComponent();
            RefreshTree RF = new RefreshTree(h1, treeView1, NameTxt);
            RF.refresh();
            #region Old


            /* import_xml.Load(_path);
             XmlElement root = import_xml.DocumentElement;
             XmlNodeList floor = root.SelectNodes("//Floor");

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
             h1 = new Hotel(_floors);
             treeView1.Nodes.Clear();
             foreach (Floor f in h1.floors)
             {
                 treeView1.Nodes.Add("Floor " + f.Number);
                 foreach (Room r in f.Rooms)
                 {
                     treeView1.Nodes[f.Number - 1].Nodes.Add("Room Nr." + r.Number);
                     if (r.Vacancy == "vacant")
                     {
                         treeView1.Nodes[f.Number - 1].Nodes[r.Number % 10 - 1].BackColor = System.Drawing.Color.Green;
                     }
                     else
                     {
                         treeView1.Nodes[f.Number - 1].Nodes[r.Number % 10 - 1].BackColor = System.Drawing.Color.Red;
                     }
                 }
             }
             */
            #endregion
        }

        #region Old
        /*
        private void Save_Click(object sender, EventArgs e)
        {

            
            XmlTextWriter _writer = new XmlTextWriter(_path, null)
            {
                Formatting = Formatting.Indented,
                Indentation = 4
            };
            _writer.WriteStartElement("Hotel");
            foreach (Floor f in h1.floors)
            {
                _writer.WriteStartElement("Floor");
                _writer.WriteAttributeString("Nr", f.Number.ToString());
                foreach (Room r in f.Rooms)
                {
                    _writer.WriteStartElement("Room");
                    _writer.WriteAttributeString("Nr", r.Number.ToString());
                    _writer.WriteAttributeString("Pers", r.Pers.ToString());
                    _writer.WriteAttributeString("Vacancy", r.Vacancy);
                    _writer.WriteAttributeString("Name", r.Name);
                    _writer.WriteAttributeString("Start", r.Start_date);
                    _writer.WriteAttributeString("End", r.End_date);
                    _writer.WriteEndElement();
                }
                _writer.WriteEndElement();
            }          
            _writer.WriteEndElement();
            _writer.Close();

        }

        private void Load_Click(object sender, EventArgs e)
        {
           
            import_xml.Load(_path);
            XmlElement root = import_xml.DocumentElement;
            XmlNodeList floor = root.SelectNodes("//Floor");

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
            h1 = new Hotel(_floors);
            treeView1.Nodes.Clear();
            foreach (Floor f in h1.floors)
            {
                treeView1.Nodes.Add("Floor " + f.Number);
                foreach (Room r in f.Rooms)
                {
                    treeView1.Nodes[f.Number - 1].Nodes.Add("Room Nr." + r.Number);
                    if (r.Vacancy == "vacant")
                    {
                        treeView1.Nodes[f.Number - 1].Nodes[r.Number % 10 - 1].BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        treeView1.Nodes[f.Number - 1].Nodes[r.Number % 10 - 1].BackColor = System.Drawing.Color.Red;
                    }
                }
            }

        }
        */
        #endregion  //Comment

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowList SL = new ShowList(listView1, e, h1);
            SL.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckOut a = new CheckOut(treeView1, h1);
                a.DeleteReservationEntry();
                RefreshTree RF = new RefreshTree(h1, treeView1,NameTxt);
                RF.refresh();
            }
            catch
            {
                MessageBox.Show("Room already empty!");
            }
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            string EndDateText = dateTimePicker1.Text;
           
            if ((NameTxt.Text == String.Empty))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            try
            {
                Reserve R = new Reserve(treeView1, h1,NameTxt.Text, dateTimePicker2.Text, dateTimePicker1.Text);
                R.AddReservation();
                RefreshTree RF = new RefreshTree(h1, treeView1, NameTxt);
                RF.refresh();
            }
            catch
            {
                MessageBox.Show("Select a room!");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
