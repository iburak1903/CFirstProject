Deneme4.Esya urun1 = new Deneme4.Esya();
urun1.Adi = "İçecek";
urun1.Fiyati = 10;
urun1.AdetSayisi = 150;
urun1.İcindekiler = "Çikolatalı içecek,Çilekli içecek,Armutlu içecek";

Deneme4.Esya urun2 = new Deneme4.Esya();
urun2.Adi = "Yağ";
urun2.Fiyati = 150;
urun2.AdetSayisi = 400;
urun2.İcindekiler = "Zeytinyağı";

Deneme4.Esya urun3 = new Deneme4.Esya();
urun3.Adi = "Bakliyat";
urun3.Fiyati = 25;
urun3.AdetSayisi = 350;
urun3.İcindekiler = "Barbunya,Buğday,Fasulye";

Deneme4.Esya[] urunler = new Deneme4.Esya[] {urun1, urun2, urun3};

foreach (var urun in urunler)
{
    Console.WriteLine(" Ürün Adı: "+urun.Adi);
    Console.WriteLine(" Fiyatı: "+urun.Fiyati);
    Console.WriteLine("Adet Sayısı: "+ urun.AdetSayisi);
    Console.WriteLine("İçindekiler: "+urun.İcindekiler);
    Console.WriteLine("------------");
}

Deneme4.Sepet sepetim = new Deneme4.Sepet();

sepetim.sepet(urun1);
sepetim.sepet(urun2);
sepetim.sepet(urun3);

Console.WriteLine("----------");

Deneme4.Sepet Toplam = new Deneme4.Sepet();

Toplam.Toplam(urun1.Fiyati, urun2.Fiyati,urun3.Fiyati);

Deneme4.Sepet toplam2 = new Deneme4.Sepet();

toplam2.Toplam2(urun1.AdetSayisi, urun2.AdetSayisi,urun3.AdetSayisi);





