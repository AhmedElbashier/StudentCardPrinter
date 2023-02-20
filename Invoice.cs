// Decompiled with JetBrains decompiler
// Type: CardPrinter.Invoice
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

namespace CardPrinter
{
  public class Invoice
  {
    public string StdName { get; set; }

    public string StdClass { get; set; }

    public string semester { get; set; }

    public string collegeNumber { get; set; }

    public string program { get; set; }

    public string currency { get; set; }

    public string stdYear { get; set; }

    public string userName { get; set; }

    public Payment payment { get; set; }
  }
}
