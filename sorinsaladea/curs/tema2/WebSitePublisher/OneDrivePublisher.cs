using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSitePublisher
{
    public class OneDrivePublisher
    {
        public Uri PublishToOneDrive(string fisierContinut)
        {
            Console.WriteLine("Continutul a fost publicat: http://www.onedrive.com/continut.pdf");

            return new Uri("http://www.onedrive.com/continut.pdf");
        }
    }
 }
