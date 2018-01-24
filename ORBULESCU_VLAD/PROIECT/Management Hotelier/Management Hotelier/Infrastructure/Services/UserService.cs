using Application.Services;
using Core.Identity_and_access_layer.Models;
using Infrastructure.Data_management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persons_layer.Models;
using Infrastructure.Exceptions;

namespace Infrastructure.Services
{
    public class UserService : IUserSession<User>
    {
        public UserRepository userRepository;
        public UserFactory userFactory;
        private User LoggedInUser;

        public UserService()
        {
            userFactory = new UserFactory();
            userRepository = new UserRepository();
            userRepository.getAllUsers();
        }

        public User Login(string u, string p)
        {
            User us = userRepository.GetUserByUsernameAndPassword(u, p);
            if(us != null)
            {
                LoggedInUser = us;
                return LoggedInUser;
            }
            else
            {
                throw new WrongCredentialsException();
            }
        }

        public void Register(string u, string p, string e, int roleNo, string n, string pr, Adresa a, int v)
        {
            throw new NotImplementedException();
        }
    }
}
