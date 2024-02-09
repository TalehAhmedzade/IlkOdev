
//using Business.Concrete;
//using Entities.Concrete;

//SelamVer(isim: "Engin");
//int sonuc = Topla(2, 5);
//Console.ReadLine();

////massivler diziler (/ Arrays

//string ogrenci1 = "Engin";
//string ogrenci2 = "Taleh";

//string[] ogrenciler = new string[2];
//ogrenciler[0] = "Engin";
//ogrenciler[1] = "Taleh";
//for (int i = 0; i < ogrenciler.Length; i++)
//{
//	Console.WriteLine(ogrenciler[i]);
//}

//string[] sehirler1 = new[] { "Baku", "Sumqayit" };
//string[] sehirler2 = new[] { "Istanbul", "Ankara" };
//sehirler2 = sehirler1;
//sehirler2[0] = "Agstafa";
//Console.WriteLine(sehirler2[0]);
//foreach (var sehir in sehirler1)
//{
//	Console.WriteLine(sehir);
//}
//List<string> sehirler = new List<string> { "Baku", "Adana", "Izmir" };

//sehirler.Add(item: "Samsun ");

//static void SelamVer(string isim = "isimsiz")
//{
//	Console.WriteLine("Merhaba " + isim);
//}
//static int Topla(int sayi1, int sayi2)
//{
//	int sonuc = sayi1 + sayi2;
//	Console.WriteLine("Toplam : " + sonuc.ToString());

//	return sonuc;
//}

using Business.Concrete;
using Entities.Concrete;

Person person = new Person()
{
	FirstName = "Taleh",
	LastName = "Əhmədzadə",
	NationalIdentity = 1234
};
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);