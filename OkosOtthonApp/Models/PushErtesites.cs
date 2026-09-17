using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthonApp.Models
{
    internal class PushErtesites : Ertesites
    {
        public PushErtesites(string deviceid, string uzenet):base()
        {
            DeviceID = deviceid;
            Uzenet = uzenet;
        }
        public string Uzenet { get; set; }
        public string DeviceID { get; set; }
        public override void Kuld(string üzenet)
        {
            Console.WriteLine($"[PUSH] Küldés a(z) {DeviceID} eszközre | Idő: {DateTime.Now} | Üzenet: {üzenet}");
        }
    }
}
