using System;
  
class Program 
{
  
    static public void Main(String[] args)
    {
        kurs kurs1 = new kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engir Demiroğ";
        kurs1.IzlenmeOrani = 68;


        kurs kurs2 = new kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem ";
        kurs2.IzlenmeOrani = 54;
          
        kurs[] kurslar = new kurs[] {kurs1,kurs2};
    
        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi+" "
            +kurs.Egitmen+ " "+
            kurs.IzlenmeOrani);
        }
    
    }

}


class kurs
{
    public string KursAdi { get; set; }
    
    public string Egitmen { get; set; }

    public int IzlenmeOrani { get; set; }

}