using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PSSC
{
    class XmlExport
    {
        public static void Write_Xml(string _path)
        {
            XmlTextWriter settingwriter = new XmlTextWriter(_path, null)
            {
                Formatting = Formatting.Indented,
                Indentation = 4
            };
            settingwriter.WriteStartElement("Orders");

            for (int order_iteration = 1; order_iteration <= Variables._order_nr; order_iteration++)
            {
                settingwriter.WriteStartElement("Order");
                settingwriter.WriteAttributeString("No", order_iteration.ToString());
                

                foreach (Order _order in MyLists._my_orders_list)
                {
                    if (_order._order_nr == order_iteration)
                    {
                        settingwriter.WriteStartElement("Waiter");
                        settingwriter.WriteAttributeString("Name", _order._waiter);
                        settingwriter.WriteEndElement();

                        settingwriter.WriteStartElement("Table");
                        settingwriter.WriteAttributeString("Table_No", _order._table);
                        settingwriter.WriteEndElement();

                        settingwriter.WriteStartElement("FooD");
                        foreach (Food _food in MyLists._my_food_list)
                        {
                            if (_food._order_nr == order_iteration)
                            {
                                settingwriter.WriteStartElement("Food");
                                settingwriter.WriteAttributeString("Food_Type", _food._food);
                                settingwriter.WriteAttributeString("Food_Amount", _food._amount);
                                settingwriter.WriteEndElement();
                            }
                        }
                        settingwriter.WriteEndElement();

                        settingwriter.WriteStartElement("Drinks");
                        foreach (Drinks _drink in MyLists._my_drinks_list)
                        {
                            if (_drink._order_nr == order_iteration)
                            {
                                settingwriter.WriteStartElement("Drink");
                                settingwriter.WriteAttributeString("Drink_Type", _drink._drink);
                                settingwriter.WriteAttributeString("Drink_Amount", _drink._amount);
                                settingwriter.WriteEndElement();
                            }
                        }
                        settingwriter.WriteEndElement();
                    }
                }
                settingwriter.WriteEndElement();
            }


            settingwriter.WriteEndElement(); 


            settingwriter.Close();
        }
    }
}
