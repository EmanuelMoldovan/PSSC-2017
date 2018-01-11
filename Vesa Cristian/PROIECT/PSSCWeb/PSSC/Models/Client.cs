using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSSC.Models.DTO;
namespace PSSC.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public List<Cont> myAccounts { get; set; }

        public Client(ClientDTO client)
        {
            adaugaClient(client);
        }

        public void adaugaClient(ClientDTO client)
        {
            if (client != null)
            {
                Id = client.Id;
                Username = client.Username;
                FirstName = client.FirstName;
                LastName = client.FirstName;
                Password = client.Password;
                myAccounts = new List<Cont>();
            }
            
        }

        public void adaugaCont(ContDTO cont)
        {
            Cont account = new Cont(cont);
            myAccounts.Add(account);
        }

        public void removeCont(Guid id)
        {
            myAccounts.Remove(myAccounts.Find(x => x.Id == id));
        }
    }
}
