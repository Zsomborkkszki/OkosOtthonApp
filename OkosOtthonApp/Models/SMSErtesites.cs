using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthonApp.Models
{
    internal class SMSErtesites : Ertesites
    {
        public SMSErtesites(string telefon, string uzenet): base()
        {
            Telefon = telefon;
            Uzenet = uzenet;
        }

        public string Telefon { get; set; }
        public string Uzenet { get; set; }
        public override void Kuld()
        {
            Console.WriteLine($"[SMS] Küldés a(z) {Telefon} telefonszámra | Idő: {DateTime.Now} | Üzenet: {Uzenet}");
        }
    }
}
