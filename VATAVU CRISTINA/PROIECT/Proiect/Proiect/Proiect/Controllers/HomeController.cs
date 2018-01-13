using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cont.Model.DTOs;
using System.IO;
using Cont.Repositories;
using Modele.Cont;
using Modele.Generic;
using Cont.Comenzi;
using Proiect.Controllers.RabbitMQ;

namespace Proiect.Controllers
{
    public class HomeController : Controller
    {
        //daca proiectul e mutat in alta locatie trebuie schimbata calea catre folderul cu fisere
        private string RootPath = "C:\\Users\\Vatavu\\Documents\\Visual Studio 2017\\Projects\\Proiect\\Proiect\\Cont\\Files";
        private ReadRepo _readRepo;
        private WriteRepo _writeRepo;



        public HomeController()
        {
            _readRepo = new ReadRepo(RootPath);
            _writeRepo = new WriteRepo(RootPath);
        }

        public HomeController(ReadRepo readRepo, WriteRepo writeRepo)
        {
            _readRepo = readRepo;
            _writeRepo = writeRepo;
        }



        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Depunere(Model_Index model)
        {

            if (model.SumaDep != 0)
            {
                //toate datele au fost completate
                ContDTO cont = _readRepo.CautaCont(model.IBAN);
                if (cont != null)
                {
                    double sum = Convert.ToDouble(model.SumaDep.ToString());
                    TranzactieDTO tranzDTO = new TranzactieDTO()
                    {
                        data = DateTime.Now.ToString(),
                        partenerTranzactie = model.IBAN,//depune catre el insusi
                        suma = sum,
                        tipTranz = "depunere"
                    };
                    //return View();
                    //_writeRepo.AdaugaTranzactie(tranzDTO, model.IBAN);
                    bool res = EfectueazaTranzactie(model.SumaDep, cont);
                    if (res == true)
                    { return View("Confirmare", GenereazaModelView(tranzDTO)); }
                    else
                    {
                        return View("Esec", GenereazaModelView("Tranzactia nu s-a putut efectua"));
                    }
                }
                else
                {
                    //iban-ul userului nu exista
                    return View("Esec", GenereazaModelView("IBAN-ul dumneavoastra nu exista"));
                }
            }
            else
            {
                return View("Esec", GenereazaModelView("Nu ati introdus suma"));
            }


        }

        [HttpPost]
        public ActionResult Transfera(Model_Index model)
        {
            if (!String.IsNullOrEmpty(model.IBANdest) &&
                model.SumaTransf != 0)
            {
                //toate datele au fost completate
                ContDTO cont = _readRepo.CautaCont(model.IBAN);
                if (cont != null)
                {
                    //iban-ul userului e corect
                    ContDTO contDest = _readRepo.CautaCont(model.IBANdest);
                    if (contDest != null)
                    {
                        //iban-ul destinatie e corect
                        double sum = Convert.ToDouble(model.SumaTransf.ToString());
                        TranzactieDTO tranzDTO = new TranzactieDTO()
                        {
                            data = DateTime.Now.ToString(),
                            partenerTranzactie = model.IBANdest,
                            suma = sum,
                            tipTranz = "transfer"
                        };
                        //Tranzactie t = _writeRepo.AdaugaTranzactie(tranzDTO, model.IBAN);
                        bool res = EfectueazaTranzactie(model.SumaTransf, cont, contDest);
                        if(res == true)
                        {
                            return View("Confirmare", GenereazaModelView(tranzDTO));
                        }
                        else
                        {
                            return View("Esec", GenereazaModelView("Tranzactia nu se poate efectua"));
                        }
                        
                    }
                    else
                    {
                        //iban-ul destinatie nu exista
                        return View("Esec", GenereazaModelView("IBAN-ul destinatie nu exista"));
                    }
                }
                else
                {
                    //iban-ul userului nu exista
                    return View("Esec", GenereazaModelView("IBAN-ul dumneavoastra nu exista"));
                }
            }
            else
            {
                if (model.SumaTransf == 0)
                {
                    return View("Esec", GenereazaModelView("Nu ati introdus suma"));
                }
                else
                {
                    return View("Esec", GenereazaModelView("Nu ati introdus IBAN-ul destinatarului"));
                }

            }
        }

        [HttpPost]
        public ActionResult Vizualizeaza(Model_Index model)
        {
            ContDTO cont = _readRepo.CautaCont(model.IBAN);
            if (cont == null)
            {
                ContDTO date = new ContDTO()
                {
                    iban = model.IBAN,
                    client = "Nu exista un client cu acest IBAN",
                    Sold = 0
                };
                return View("Vizualizare", GenereazaModelView(date));
            }
            else
            {

            }

            return View("Vizualizare", GenereazaModelView(cont));
        }

        [HttpPost]
        public ActionResult IstoricTranzactii(Model_Index model)
        {
            var toateTranz = _readRepo.ObtineTranzactii(model.IBAN);
            List<Istoric> modelGenerat = GenereazaModelView(toateTranz);
            if(modelGenerat == null)
            {
                return View("Esec", GenereazaModelView("Nu exista inca nicio tranzactie pentur acest cont"));
            }
            return View("Istoric", GenereazaModelView(toateTranz));

        }





        private static Confirmare GenereazaModelView(TranzactieDTO t)
        {
            return new Confirmare()
            {
                data = t.data,
                partenerTranzactie = t.partenerTranzactie,
                suma = t.suma,
                tipTranz = t.tipTranz
            };
        }

        private static Esec GenereazaModelView(string m)
        {
            return new Esec()
            {
                motiv = m
            };
        }

        private static DateCont GenereazaModelView(ContDTO c)
        {
            return new DateCont()
            {
                iban = c.iban,
                client = c.client,
                Sold = c.Sold
            };
        }

        private static List<Istoric> GenereazaModelView(List<TranzactieDTO> t)
        {
            List<Istoric> ret = new List<Istoric>();
            if (t != null)
            {
                foreach (TranzactieDTO tr in t)
                {
                    Istoric obj = new Models.Istoric()
                    {
                        data = tr.data,
                        partenerTranzactie = tr.partenerTranzactie,
                        suma = tr.suma,
                        tipTranz = tr.tipTranz
                    };
                    ret.Add(obj);
                }
            }
            
            return ret;
        }




        //tranzactie
        public bool EfectueazaTranzactie(double sum, ContDTO source, ContDTO destination)
        {
            //compune o comanda si serializeaz-o
            String serializedCommand = new SerializedCommandDTO(sum, source, destination).Serialize();
            //trimite comanda pe coada de comenzi. Procesatorul de comenzi va pune un rezultatt pe coada de rezultate
            CmdSender.Send(serializedCommand);
            //cere rezultatul
            SerializedResultDTO res = ResultReceiver.Receive(); //astepta raspunsul de pe coada de raspunsuri

            //modifica fisierele conform rezultatului comenzii
            _writeRepo.AdaugaTranzactie(res.tranzactii[0], res.conturi[0].iban);
            _writeRepo.ActualizareContInLista(source, res.conturi[0].Sold);

            _writeRepo.AdaugaTranzactie(res.tranzactii[1], res.conturi[1].iban);
            _writeRepo.ActualizareContInLista(destination, res.conturi[1].Sold);

            return true;
        }

        //depunere
        public bool EfectueazaTranzactie(double sum, ContDTO source)
        {
            //compune o comanda si serializeaz-o
            String serializedCommand = new SerializedCommandDTO(sum, source).Serialize();
            //trimite comanda pe coada de comenzi. Procesatorul de comenzi va pune un rezultatt pe coada de rezultate
            CmdSender.Send(serializedCommand);
            //cere rezultatul
            SerializedResultDTO res = ResultReceiver.Receive(); //astepta raspunsul de pe coada de raspunsuri

            //modifica fisierele conform rezultatului comenzii
            _writeRepo.AdaugaTranzactie(res.tranzactii[0], res.conturi[0].iban);
            _writeRepo.ActualizareContInLista(source, res.conturi[0].Sold);
            return true;
            
        }

    }
}


