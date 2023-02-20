// Decompiled with JetBrains decompiler
// Type: CardPrinter.StdAccount
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using System.Collections.Generic;

namespace CardPrinter
{
  public class StdAccount
  {
    public string StdName { get; set; }

    public string StdClass { get; set; }

    public string semester { get; set; }

    public string collegeNumber { get; set; }

    public string program { get; set; }

    public string currency { get; set; }

    public int loans { get; set; }

    public string stdYear { get; set; }

    public List<Payment> payments { get; set; }

    public List<Transaction> transactions { get; set; }
  }
}
