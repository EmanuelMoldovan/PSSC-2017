using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSC.Models;
using PSSC.Models.DTO;

namespace PSSCWebTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void createClient()
        {
            var client = new PSSC.Models.Client(null);

            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void createCont()
        {
            var cont = new Cont(new ContDTO() {
                AccountNumber = "ROSDSNASD29121",
                MoneyDeposited = 300,
                Currency = "RON",
            });

            Assert.IsNull(cont);
        }

        [TestMethod]
        public void withdrawMoney()
        {
            Cont cont = new Cont(new ContDTO()
            {
                AccountNumber = "ROSDSNASD29121",
                MoneyDeposited = 300,
                Currency = "RON",
            });

            ActionDTO action = new ActionDTO()
            {
                _ActionType = ActionType.Withdraw,
                Money = 400
            }; 

            Assert.IsTrue(cont.makeTransaction(action));
        }

        [TestMethod]
        public void depositMoney()
        {
            Cont cont = new Cont(new ContDTO()
            {
                AccountNumber = "ROSDSNASD29121",
                MoneyDeposited = 300,
                Currency = "RON",
            });

            ActionDTO action = new ActionDTO()
            {
                _ActionType = ActionType.Deposit,
                Money = 400
            };

            Assert.IsTrue(cont.makeTransaction(action));
        }


    }
}
