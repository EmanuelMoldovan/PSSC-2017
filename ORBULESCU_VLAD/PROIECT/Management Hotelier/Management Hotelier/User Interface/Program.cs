using Core.Persons_layer.Models;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface
{
    class Program
    {
        private static UserService userService = new UserService();
        static void Main(string[] args)
        {
            userService.userFactory.CreateUser("vladorbulescu10", "Par0la01", "vlad@gmail.com", 0, "Vlad", "Orbulescu", new Adresa("Ep. N. Popeea",9,"Romania","Caransebes","Caras-Severin"), 22);
        }
    }
}
