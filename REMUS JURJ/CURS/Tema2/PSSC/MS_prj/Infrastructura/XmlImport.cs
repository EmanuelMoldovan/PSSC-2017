using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace PSSC
{
    class XmlImport
    {
        public static XmlDocument import_xml = new XmlDocument();
        public static void Read_Xml(string _path)
        {
            import_xml.Load(_path);
            XmlElement root = import_xml.DocumentElement;
            XmlNodeList order_node = root.SelectNodes("//Order");

            foreach(XmlNode _order_node in order_node)
            {
                for(int i=0;i<_order_node.ChildNodes[2].ChildNodes.Count;i++)
                {
                    try
                    {
                        GetXmlData _get_data = new GetXmlData(_order_node.ChildNodes[0].Attributes["Name"].InnerText,
                            _order_node.Attributes["No"].InnerText,
                            _order_node.ChildNodes[1].Attributes["Table_No"].InnerText,
                            _order_node.ChildNodes[2].ChildNodes[i].Attributes["Food_Type"].InnerText,
                            _order_node.ChildNodes[2].ChildNodes[i].Attributes["Food_Amount"].InnerText);
                        MyLists._my_XmlData_list.Add(_get_data);
                    }
                    catch (Exception) { };
                }

                for (int i = 0; i < _order_node.ChildNodes[3].ChildNodes.Count; i++)
                {
                    try
                    {
                        GetXmlData _get_data = new GetXmlData(_order_node.ChildNodes[0].Attributes["Name"].InnerText,
                            _order_node.Attributes["No"].InnerText,
                            _order_node.ChildNodes[1].Attributes["Table_No"].InnerText,
                            _order_node.ChildNodes[3].ChildNodes[i].Attributes["Drink_Type"].InnerText,
                            _order_node.ChildNodes[3].ChildNodes[i].Attributes["Drink_Amount"].InnerText);
                        MyLists._my_XmlData_list.Add(_get_data);
                    }
                    catch (Exception) { };
                }
            }
            
        }

    }
}
