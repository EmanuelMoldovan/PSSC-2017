using Cont.Model.DTOs;
using Modele.Cont;
using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.RabbitMQ
{
    public class ProcesatorComanda
    {
        public static String Proceseaza(double sum, ContDTO source, ContDTO destination)
        {
            AG_ROOT_Cont sursa = new AG_ROOT_Cont(new Modele.Generic.IBAN(source.iban), new Client(new PlainText(source.client), new PlainText("nu conteaza")), new Suma(source.Sold));
            AG_ROOT_Cont dest = new AG_ROOT_Cont(new Modele.Generic.IBAN(destination.iban), new Client(new PlainText(destination.client), new PlainText("nu conteaza")), new Suma(destination.Sold));
            AG_ROOT_Cont vehicle = new AG_ROOT_Cont();
            //cere modelului sa efectueze tranzactia
            List<AG_ROOT_Cont> result = vehicle.TransferBaniIntreDouaConturi(new Suma(sum), sursa, dest);



            //Pregateste rezultatul tranzactiei ca raspuns inapoi catre MVC

            //obtine tranzactia efectuata de sursa 
            TranzactieDTO tranzDTOScr = new TranzactieDTO();
            tranzDTOScr.partenerTranzactie = result.First().IstoricTranzactii.getTranzactii.First().PartenerTranzactie.getIBAN;
            tranzDTOScr.suma = result.First().IstoricTranzactii.getTranzactii.First().Suma.getSuma;
            tranzDTOScr.data = DateTime.Today.ToString();
            if (result.First().IstoricTranzactii.getTranzactii.First().Tip.Equals(TipTranzactie.Transfer))
            {
                tranzDTOScr.tipTranz = "transfer";
            }

            //obtine tranzactia efectuata la destinatar
            TranzactieDTO tranzDTODest = new TranzactieDTO();
            tranzDTODest.partenerTranzactie = result[1].IstoricTranzactii.getTranzactii.First().PartenerTranzactie.getIBAN;
            tranzDTODest.suma = result[1].IstoricTranzactii.getTranzactii.First().Suma.getSuma;
            tranzDTODest.data = DateTime.Today.ToString();
            if (result[1].IstoricTranzactii.getTranzactii.First().Tip == TipTranzactie.Transfer)
            {
                tranzDTODest.tipTranz = "transfer";
            }

            //obtine datele conturilor modifcate
            ContDTO updatedAccountSrc = new ContDTO();
            updatedAccountSrc.client = result[0].DateClient.Nume.Text;
            updatedAccountSrc.iban = result[0].IBAN.getIBAN;
            updatedAccountSrc.Sold = result[0].Sold.getSuma;

            ContDTO updatedAccountDest = new ContDTO();
            updatedAccountDest.client = result[1].DateClient.Nume.Text;
            updatedAccountDest.iban = result[1].IBAN.getIBAN;
            updatedAccountDest.Sold = result[1].Sold.getSuma;
            return new SerializedResultDTO(updatedAccountSrc, updatedAccountDest, tranzDTOScr, tranzDTODest).Serialize();
        }



        public static String Proceseaza(double sum, ContDTO source)
        {
            AG_ROOT_Cont sursa = new AG_ROOT_Cont(new Modele.Generic.IBAN(source.iban), new Client(new PlainText(source.client), new PlainText("nu conteaza")), new Suma(source.Sold));
            AG_ROOT_Cont result = sursa.DepuneBani(new Suma(sum));


            //Pregateste rezultatul tranzactiei ca raspuns inapoi catre MVC

            //obtine tranzactia sursei 
            TranzactieDTO tranzDTO = new TranzactieDTO();
            tranzDTO.partenerTranzactie = result.IstoricTranzactii.getTranzactii.First().PartenerTranzactie.getIBAN;
            tranzDTO.suma = result.IstoricTranzactii.getTranzactii.First().Suma.getSuma;
            tranzDTO.data = DateTime.Today.ToString();
            if (result.IstoricTranzactii.getTranzactii.First().Tip.Equals(TipTranzactie.Depunere))
            {
                tranzDTO.tipTranz = "depunere";
            }

            //obtine datele contului modificat
            ContDTO updatedAccount = new ContDTO();
            updatedAccount.client = result.DateClient.Nume.Text;
            updatedAccount.iban = result.IBAN.getIBAN;
            updatedAccount.Sold = result.Sold.getSuma;
            return  new SerializedResultDTO(updatedAccount, tranzDTO).Serialize();
        }
    }
}
