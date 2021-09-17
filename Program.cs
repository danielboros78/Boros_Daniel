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

    }

    private static void OtodikFeladat()
    {
      Console.Write("5. feladat: Kérem egy részleg nevét: ");
      string reszlegBeker = Console.ReadLine();
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
