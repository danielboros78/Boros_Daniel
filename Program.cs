using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Boros_Daniel
{
  class Program
  {
    static List<Adatok> adatok = new List<Adatok>();
    static string reszlegBeker = "";
    static void Main(string[] args)
    {
      ElsoFeladat();
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      Console.ReadKey();
    }

    private static void HetedikFeladat()
    {

    }

    private static void HatodikFeladat()
    {
      bool van = false;
      int max = 0;
      int iMax = 0;
      for (int i = 0; i < adatok.Count; i++)
      {
        if (reszlegBeker == adatok[i].Reszleg)
        {
          van = true;
        }
        if (adatok[i].Fizetes > max && van)
        {
          max = adatok[i].Fizetes;
          iMax = i;
        }
      }
        
      
      if (van == true)
      {
        Console.WriteLine($"6. feladat: A legtöbbet kereső dolgozó a megadott részlegen");
        Console.WriteLine("\tNév:",adatok[iMax].Nev);
        Console.WriteLine("\tNem:", adatok[iMax].Nem);
        Console.WriteLine("\tRészleg:", adatok[iMax].Reszleg);
        Console.WriteLine("\tBelépés:", adatok[iMax].Ev);
        Console.WriteLine("\tBér:", adatok[iMax].Fizetes);
      }
      else
      {
        Console.WriteLine("N");
      }
    }

    private static void OtodikFeladat()
    {
      Console.Write("5. feladat: Kérem egy részleg nevét: ");
      reszlegBeker = Console.ReadLine();
    }

    private static void NegyedikFeladat()
    {
      double szamol = 0;
      foreach (var a in adatok)
      {
        szamol += a.Fizetes;
      }
      szamol = szamol / adatok.Count / 1000;
      szamol = Math.Round(szamol, 1);
      Console.WriteLine($"4. feladat: Bérek átlaga: {szamol} eFt");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: Dolgozók száma: {adatok.Count} fő");
    }

    private static void MasodikFeladat()
    {
      StreamReader olvas = new StreamReader("berek2020.txt");
      olvas.ReadLine();
      while (!olvas.EndOfStream)
      {
        adatok.Add(new Adatok(olvas.ReadLine()));
      }
      olvas.Close();
    }

    private static void ElsoFeladat()
    {

    }
  }
}
