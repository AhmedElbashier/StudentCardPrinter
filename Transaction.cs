// Decompiled with JetBrains decompiler
// Type: CardPrinter.Transaction
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

namespace CardPrinter
{
  public class Transaction
  {
    public int id { get; set; }

    public int amount { get; set; }

    public int leftover { get; set; }

    public string payments { get; set; }

    public int userId { get; set; }

    public int studantId { get; set; }

    public object StatmentNumber { get; set; }

    public object ReceiptNumber { get; set; }

    public string StatmentDate { get; set; }

    public string PaymentMethod { get; set; }

    public string created_at { get; set; }

    public string updated_at { get; set; }
  }
}
