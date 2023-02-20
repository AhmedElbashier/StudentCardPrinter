// Decompiled with JetBrains decompiler
// Type: CardPrinter.Payment
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

namespace CardPrinter
{
  public class Payment
  {
    public int id { get; set; }

    public int amount { get; set; }

    public string PaymentTo { get; set; }

    public string PaymentFrom { get; set; }

    public string PaymentType { get; set; }

    public string PaymentDate { get; set; }

    public string PaymentMethod { get; set; }

    public string StatmentDate { get; set; }

    public string StatmentNumber { get; set; }

    public int userId { get; set; }

    public string created_at { get; set; }

    public string updated_at { get; set; }

    public int payed { get; set; }

    public int left { get; set; }
  }
}
