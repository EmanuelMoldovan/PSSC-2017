using Core.Identity_and_access_layer.Models;
using Core_services.Repositories;
using Infrastructure.Data_management;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    class DataCheck : IDataCheck
    {
        public DataCheck()
        {}

        public bool CheckDuplicateUsername(string username,List<User> list)
        {
            bool exists = list.Find(x => x.Username == username) != null ? true : false;
            return exists;
        }

        public bool CheckFileEmpty(string filePath)
        {
            bool isEmpty = new FileInfo(filePath).Length == 0 || new FileInfo(filePath).Length == 3 ? true : false;
            return isEmpty;
        }
    }
}
