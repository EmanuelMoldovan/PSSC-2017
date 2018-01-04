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
        private IDataValidation validation;
        private PersonRepository personRepository;

        public UserService(IDataValidation _validation)
        {
            userFactory = new UserFactory();
            userRepository = new UserRepository();
            personRepository = new PersonRepository();
            validation = _validation;
        }

        public Persoana GetLoggedInPerson()
        {
            return personRepository.GetAllPersons().Find(x => x.UserId.Equals(LoggedInUser.UserId));
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

        public User Register(string u, string p, string e, string n, string pr, Adresa a, int v)
        {
            validation = new DataValidation();
            if(validation.CheckPasswordLength(p) && validation.CheckPasswordCharacters(p))
            {
                return userFactory.CreateUser(u, p, e, n, pr, a, v);
            }
            else
            {
                return null;
            }
        }

        public bool RemoveUser(Guid id)
        {
            return userRepository.DeleteUserByUserId(id);
        }
    }
}
