using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Boros_Daniel
{
  class Adatok
  {
    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }

    private string nem;

    public string Nem
    {
      get { return nem; }
      set { nem = value; }
    }

    private string reszleg;

    public string Reszleg
    {
      get { return reszleg; }
      set { reszleg = value; }
    }

    private int ev;

    public int Ev
    {
      get { return ev; }
      set { ev = value; }
    }

    private int fizetes;

    public int Fizetes
    {
      get { return fizetes; }
      set { fizetes = value; }
    }

    public Adatok(string olvas)
    {
      string[] sor = olvas.Split(';');
      this.nev = sor[0];
      this.nem = sor[1];
      this.reszleg = sor[2];
      this.ev = Convert.ToInt32(sor[3]);
      this.fizetes = Convert.ToInt32(sor[4]);
    }
  }
  }
