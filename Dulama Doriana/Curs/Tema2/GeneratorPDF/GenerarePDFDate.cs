using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Web;
using System.IO;
using Model.Pacienti;

namespace GeneratorPDF
{
    public class GenerarePDFDate
    {

        public GenerarePDFDate(Pacient pacient, string path, string optiuneFisa)
        {

            string outputFile = Path.Combine(path);

            switch (optiuneFisa)
            {
                case "date identificare":

                    
                    using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (Document doc = new Document(PageSize.LETTER))
                        {
                            using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                            {
                                doc.Open();

                                var paragraph = new Paragraph("Fisa date identificare pacient");
                                paragraph.Alignment = Element.ALIGN_CENTER;
                                doc.Add(paragraph);

                                doc.Add(new Paragraph("\n"));

                                var paragraphNume = new Paragraph(pacient.numePacient.toString());
                                paragraphNume.Alignment = Element.ALIGN_CENTER;
                                doc.Add(paragraphNume);

                                doc.Add(new Paragraph("\n"));
                                doc.Add(new Paragraph("CNP - " + pacient.cnp));

                                doc.Add(new Paragraph("\n"));
                                doc.Add(new Paragraph("Data nasterii - " + pacient.dataNastere.toString()));

                                doc.Add(new Paragraph("\n"));
                                doc.Add(new Paragraph("Adresa - " + pacient.adresa.toString()));

                                doc.Add(new Paragraph("\n"));
                                doc.Add(new Paragraph("Ocupatie - " + pacient.ocupatie));

                                doc.Add(new Paragraph("\n"));
                                doc.Add(new Paragraph("Loc munca - " + pacient.locMunca));

                                Console.WriteLine("GenerarePDF() : S-a generat pdf cu datele pacientului");

                                doc.Close();

                            }
                        }
                    }

                    break;

                case "istoric":

                  
                    using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (Document doc = new Document(PageSize.LETTER))
                        {
                            using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                            {
                                doc.Open();

                                var paragraph = new Paragraph("Istoric Pacient");
                                paragraph.Alignment = Element.ALIGN_CENTER;
                                doc.Add(paragraph);

                                doc.Add(new Paragraph("\n"));

                                var paragraphNume = new Paragraph(pacient.numePacient.toString());
                                paragraphNume.Alignment = Element.ALIGN_CENTER;
                                doc.Add(paragraphNume);

                               
                                    //foreach (var item in pacient.afectiuneRecomandare)
                                    //{
                                    //    string text = "Afectiune: " + item.Key + " - " + "Recomandare: " + item.Value;
                                    //    var paragraphAfectiune = new Paragraph(text);
                                    //    doc.Add(paragraphAfectiune);
                                    //    doc.Add(new Paragraph("\n"));
                                    //}

                                foreach(var item in pacient.afectiuneRecomandare.AllKeys)
                                {
                                    string text = "Afectiune: " + item + " - " + "Recomandare: " + pacient.afectiuneRecomandare[item];
                                    var paragraphAfectiune = new Paragraph(text);
                                    doc.Add(paragraphAfectiune);
                                    doc.Add(new Paragraph("\n"));
                                }

                                    Console.WriteLine("GenerarePDF() : S-a generat pdf cu istoricul pacientului");

                                doc.Close();
                            }
                        }
                    }

                    break;

            }
        }

      
    }
}
