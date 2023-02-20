// Decompiled with JetBrains decompiler
// Type: CardPrinter.ReportApi
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using System.Net;

namespace CardPrinter
{
  internal class ReportApi
  {
    public string URL = "http://192.168.1.4/api/api/";

    public string getData(string url) => new WebClient().DownloadString(url);
  }
}
