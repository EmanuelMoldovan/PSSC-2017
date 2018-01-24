using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PsscT2.Infrastructura
{
    class GeneRareRapoarteXML
    {

        public void GenerareXMl( string Nume, String Data)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement(Data);
            xmlDoc.AppendChild(rootNode);            

            xmlDoc.Save(Nume);

        }
    }
        
    }
