using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public Adatok(string nev, string nem, string reszleg, int ev, int fizetes)
    {
      this.nev = nev;
      this.nem = nem;
      this.reszleg = reszleg;
      this.ev = ev;
      this.fizetes = fizetes;
    }
  }
}
