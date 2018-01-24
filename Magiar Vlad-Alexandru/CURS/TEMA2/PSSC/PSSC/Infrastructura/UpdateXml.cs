using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PSSC
{
    public class UpdateXml
    {
        Hotel h1;
        String _path = Environment.CurrentDirectory.ToString() + "\\in.xml";
        public UpdateXml(Hotel h1)
        {
            H1 = h1;
        }

        public Hotel H1 { get => h1; set => h1 = value; }

        public void update()
        {
            XmlTextWriter _writer = new XmlTextWriter(_path, null)
            {
                Formatting = Formatting.Indented,
                Indentation = 4
            };
            _writer.WriteStartElement("Hotel");
            foreach (Floor f in H1.floors)
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
    
}
}
