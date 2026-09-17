using OkosOtthonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthonApp
{
    internal class Program
    {
        static List<Ertesites> ertesitesk = new List<Ertesites>();
        static void Main(string[] args)
        {
            string riasztas = "Riasztás: Betörés történt az otthonban!";
            PushErtesites push = new PushErtesites("Device123", riasztas);
            EmailErtesites email = new EmailErtesites("szia@gmail.com", riasztas);
            SMSErtesites sms = new SMSErtesites("+36123456789", riasztas);

            ertesitesk.Add(push);
            ertesitesk.Add(email);
            ertesitesk.Add(sms);
            foreach (var item in ertesitesk)
            {
                item.Kuld(riasztas);
            }
        }
    }
}
