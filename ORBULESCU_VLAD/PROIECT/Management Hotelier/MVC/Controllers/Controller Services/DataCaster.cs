using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace Infrastructure
{
    public class DataCaster<T> : IDataCaster<T>
    {
        public List<T> CastObjectListToTypeList(List<object> list)
        {
            List<T> castedList = new List<T>();
            foreach(JObject o in list)
            {
                castedList.Add(o.ToObject<T>());
            }
            return castedList;
        }

        public List<object> CastTypeListToObjectList(List<T> list)
        {
            List<object> castedList = new List<object>();
            foreach(T type in list)
            {
                castedList.Add((object)type);
            }
            return castedList;
        }
    }
}
