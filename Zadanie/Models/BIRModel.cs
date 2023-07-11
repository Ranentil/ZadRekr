using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;
using System.Xml.Serialization;
using UslugaBIR;

namespace Zadanie.Models
{
    public class BIRModel
    {
        string endpoint = "https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
        string userkey = "abcde12345abcde12345";
        BIRDane birDane;

        public async Task<BIRDane> Search(string nip)
        {
            var binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Transport;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            binding.MessageEncoding = WSMessageEncoding.Mtom;

            var ea = new EndpointAddress(endpoint);
            var client = new UslugaBIRzewnPublClient(binding, ea);
            await client.OpenAsync();

            var session = await client.ZalogujAsync(userkey);

            using (new OperationContextScope(client.InnerChannel))
            {
                var requestMessage = new HttpRequestMessageProperty();
                //requestMessage.Headers.Add("sid", session);
                requestMessage.Headers["sid"] = session.ZalogujResult;

                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;

                var par = new ParametryWyszukiwania { Nip = nip };
                var result = await client.DaneSzukajPodmiotyAsync(par);
                var requestResult = result.DaneSzukajPodmiotyResult;

                XDocument doc = XDocument.Parse(requestResult);
                birDane = DaneKlienta.Load(doc).dane;

                var result2 = await client.DanePobierzPelnyRaportAsync(birDane.Regon, getType(birDane.Typ, birDane.SilosID));
                var requestResult2 = result2.DanePobierzPelnyRaportResult;
                requestResult2 = requestResult2.Replace("praw_", "").Replace("fiz_", "");
                XDocument doc2 = XDocument.Parse(requestResult2);
                DaneRozsz.Dane dane2 = DaneRozsz.Load(doc2).dane;

                this.Uzupelnij(nip, dane2);
            }
            await client.WylogujAsync(session.ZalogujResult);
            await client.CloseAsync();
            return birDane;
        }

        public class BIRDane
        {
            public string NIP { get; set; }
            public string Regon { get; set; }
            public string Nazwa { get; set; }
            public string Miejscowosc { get; set; }
            public string KodPocztowy { get; set; }
            public string Ulica { get; set; }
            public string Typ { get; set; }
            public string SilosID { get; set; }
        }

        private void Uzupelnij(string nip, DaneRozsz.Dane r)
        {
            birDane.NIP = nip;
            birDane.Ulica = (birDane.Ulica + " " + r.adSiedzNumerNieruchomosci + " " + r.adSiedzNumerLokalu).Trim();
        }

        [XmlRoot("root")]
        public class DaneKlienta
        {
            public BIRDane dane { get; set; }

            public static DaneKlienta Load(XDocument xDoc)
            {
                XmlSerializer s = new XmlSerializer(typeof(DaneKlienta));
                return (DaneKlienta)s.Deserialize(xDoc.CreateReader());
            }
        }

        [XmlRoot("root")]
        public class DaneRozsz
        {
            public Dane dane { get; set; }

            public static DaneRozsz Load(XDocument xDoc)
            {
                XmlSerializer s = new XmlSerializer(typeof(DaneRozsz));
                return (DaneRozsz)s.Deserialize(xDoc.CreateReader());
            }

            public class Dane
            {
                public string adSiedzNumerNieruchomosci { get; set; }
                public string adSiedzNumerLokalu { get; set; }
            }
        }


        private string getType(string t, string s)
        {
            if (t == "P")
                return "PublDaneRaportPrawna";
            if (t == "F" && s == "1")
                return "PublDaneRaportDzialalnoscFizycznejCeidg";
            if (t == "F" && s == "2")
                return "PublDaneRaportDzialalnoscFizycznejRolnicza";
            if (t == "F" && s == "3")
                return "PublDaneRaportDzialalnoscFizycznejPozostala";
            if (t == "F" && s == "4")
                return "PublDaneRaportDzialalnoscFizycznejWKrupgn";
            if (t == "LP")
                return "PublDaneRaportLokalnaPrawnej";
            if (t == "LF")
                return "PublDaneRaportLokalnaFizycznej";
            return "";
        }
    }
}
