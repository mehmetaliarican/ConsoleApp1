using System;
using TOS;

namespace ConsoleApp1
{
    enum Deneme
    {
        Value1, Value2
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Tos();
            WriteTo();

            //Console.WriteLine(DateTime.Now.ToString());

            //KPSClientNS.KPSPublicSoapClient client = new KPSClientNS.KPSPublicSoapClient(KPSClientNS.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //var result =  client.TCKimlikNoDogrula(new KPSClientNS.TCKimlikNoDogrulaRequest
            //{
            //    Body = new KPSClientNS.TCKimlikNoDogrulaRequestBody
            //    {
            //        Ad = "MEHMET ALİ",
            //        Soyad = "ARICAN",
            //        DogumYili = 1985,
            //        TCKimlikNo = 19217055864
            //    }
            //});

            Console.ReadKey();
        }
        public static async void WriteTo()
        {
            Console.WriteLine("Bağlanıyor...");
            var date = Convert.ToDateTime("2019-04-09 00:00");
            VakifSNS.SOnlineEkstreServisClient client = new VakifSNS.SOnlineEkstreServisClient();

            Console.WriteLine("Hareketler çekiliyor....");
            var serviseResult = await client.GetirHareketAsync(new VakifSNS.GetirHareketRequest
            {
                sorgu = new VakifSNS.DtoEkstreSorgu
                {
                    MusteriNo = "007283000555",
                    HesapNo = "00158000020757464",
                    KurumKullanici = "alicoban",
                    Sifre = "DQKHTZUG",
                    SorguBaslangicTarihi = "2019-04-09 00:00",
                    SorguBitisTarihi = "2019-11-09 00:00",
                }
            });

            Console.WriteLine("Hesaplar yazdırılıyor....");
            var hareketResult = serviseResult.GetirHareketResult;
            if (hareketResult.Hesaplar != null)
            {
                foreach (var hesap in hareketResult.Hesaplar)
                {
                    Console.WriteLine("Şube:" + hesap.SubeAdi);
                    Console.WriteLine("Hesap :" + hesap.HesapNo);
                    Console.WriteLine("IBAN:" + hesap.HesapNoIban);
                    Console.WriteLine("Açılış:" + hesap.HesapTipi);
                    Console.WriteLine("Açılış:" + hesap.AcilisBakiye);
                    Console.WriteLine("Açılış:" + hesap.VergiKimlikNumarasi);
                    Console.WriteLine("--------------------------");
                }
            }
            Console.WriteLine("Bitti.");
             await client.CloseAsync();
        }

        public static void Tos()
        {
            TosServiceClient client = new TosServiceClient();
            var output = client.VitTosIslem(new TOS.TopluOdemeInput
            {
                TopluIslemListesi = new VitTosIslemIstek[]
                 {
                      new VitTosIslemIstek
                      {
                         KurumKodu= "0005821",
                         Aciklama = "Deneme",
                         AliciAdi = "ARİF KÖKBUDAK",
                         AliciAdres = "Ankara",
                         AliciBabaAdi = "SABRİ",
                         AliciEmail = "arif@vakifbank.com.tr",
                         AliciBankaKodu = "0062",
                         AliciHesapNo = "00158007304157140",
                         AliciSubeKodu = "00154",
                         AliciTcVergiNo = "26287370309",
                         AliciTel = "5061234567",
                         AliciVergiDairesi = "26287370309",
                         DovizCinsi = "TL",
                         GelenIadeIslemSorguNumarasi = "paket1",
                         IslemTutari = 100.10M,
                         KayitTipi = KayitTipleri.Hesap,
                         KaynakHesapNo = "00158007304157607",
                         KrediKullanilsin = true,
                         KurumIslemId = "20180928VIT000000000000003000005",
                         OdemeTarihi = DateTime.Now.AddDays(11).ToString("yyyy-MM-dd"),
                         PaketNo = "paket1",
                         VergiTcKontrolEdilsin = true
                      }

                 },
                SecuredWebServiceHeader = new SecuredWebServiceHeader
                {
                    Password = "DQKHTZUG",
                    Username = "alicoban"
                }
            });
            foreach (var item in output.OdemeSonucListesi)
            {
                Console.WriteLine(item.DurumKoduAciklama);
                Console.WriteLine(item.DurumKodu);
            }
        }
    }
}
