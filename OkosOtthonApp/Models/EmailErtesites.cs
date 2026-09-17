using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthonApp.Models
{
    internal class EmailErtesites:Ertesites
    {
        public EmailErtesites(string email, string uzenet):base()
        {
            Email = email;
            Uzenet = uzenet;
        }
        public string Email { get; set; }
        public string Uzenet { get; set; }
        public override void Kuld()
        {
            Console.WriteLine($"[EMAIL] Küldés a(z) {Email} email címre | Idő: {DateTime.Now} | Üzenet: {Uzenet}");
        }
    }
}
