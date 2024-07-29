internal class Program
{
    private static void Main(string[] args)
    {
        //Tanımlama ve ekleme
        var personelListesi = new Dictionary<int, Personel>()
        {
            {100, new Personel( "Selma", "Bakar", 3500 ) },
            {101, new Personel("Betül", "Kaya", 5200) },
            {102, new Personel("Bilge", "Seva", 1600) }
        };

        //ekleme
        personelListesi.Add( 110, new Personel("Zeynep", "Coşkun", 2000 ));

        //dolaşma
        foreach( var personel in personelListesi )
        {
            Console.WriteLine( personel );
        }
    }
}

public class Personel
{
    public Personel(string adi, string soyadi, decimal maas)
    {
        Adi = adi;
        Soyadi = soyadi;
        Maas = maas;
    }

    //public int SicilNo { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public decimal Maas { get; set; }

    public override string ToString()
    {
        return $"{Adi, -10} {Soyadi, -15} {Maas, -10}";
    }
}