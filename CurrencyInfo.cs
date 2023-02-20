// Decompiled with JetBrains decompiler
// Type: CardPrinter.CurrencyInfo
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

namespace CardPrinter
{
  internal class CurrencyInfo
  {
    public CurrencyInfo(CurrencyInfo.Currencies currency)
    {
      switch (currency)
      {
        case CurrencyInfo.Currencies.Sudan:
          this.CurrencyID = 0;
          this.CurrencyCode = "SDG";
          this.IsCurrencyNameFeminine = true;
          this.EnglishCurrencyName = "Sundanesse Pound";
          this.EnglishPluralCurrencyName = "Sundanesse Pounds";
          this.EnglishCurrencyPartName = "Piaster";
          this.EnglishPluralCurrencyPartName = "Piasteres";
          this.Arabic1CurrencyName = "جنيه سوداني";
          this.Arabic2CurrencyName = "جنيهين سودانيتان";
          this.Arabic310CurrencyName = "جنيهات سودانية";
          this.Arabic1199CurrencyName = "جنيه سوداني";
          this.Arabic1CurrencyPartName = "قرش";
          this.Arabic2CurrencyPartName = "قرشان";
          this.Arabic310CurrencyPartName = "قروش";
          this.Arabic1199CurrencyPartName = "قرشاً";
          this.PartPrecision = (byte) 2;
          this.IsCurrencyPartNameFeminine = false;
          break;
        case CurrencyInfo.Currencies.UAE:
          this.CurrencyID = 1;
          this.CurrencyCode = "AED";
          this.IsCurrencyNameFeminine = false;
          this.EnglishCurrencyName = "UAE Dirham";
          this.EnglishPluralCurrencyName = "UAE Dirhams";
          this.EnglishCurrencyPartName = "Fils";
          this.EnglishPluralCurrencyPartName = "Fils";
          this.Arabic1CurrencyName = "درهم إماراتي";
          this.Arabic2CurrencyName = "درهمان إماراتيان";
          this.Arabic310CurrencyName = "دراهم إماراتية";
          this.Arabic1199CurrencyName = "درهماً إماراتياً";
          this.Arabic1CurrencyPartName = "فلس";
          this.Arabic2CurrencyPartName = "فلسان";
          this.Arabic310CurrencyPartName = "فلوس";
          this.Arabic1199CurrencyPartName = "فلساً";
          this.PartPrecision = (byte) 2;
          this.IsCurrencyPartNameFeminine = false;
          break;
        case CurrencyInfo.Currencies.SaudiArabia:
          this.CurrencyID = 2;
          this.CurrencyCode = "SAR";
          this.IsCurrencyNameFeminine = false;
          this.EnglishCurrencyName = "Saudi Riyal";
          this.EnglishPluralCurrencyName = "Saudi Riyals";
          this.EnglishCurrencyPartName = "Halala";
          this.EnglishPluralCurrencyPartName = "Halalas";
          this.Arabic1CurrencyName = "ريال سعودي";
          this.Arabic2CurrencyName = "ريالان سعوديان";
          this.Arabic310CurrencyName = "ريالات سعودية";
          this.Arabic1199CurrencyName = "ريالاً سعودياً";
          this.Arabic1CurrencyPartName = "هللة";
          this.Arabic2CurrencyPartName = "هللتان";
          this.Arabic310CurrencyPartName = "هللات";
          this.Arabic1199CurrencyPartName = "هللة";
          this.PartPrecision = (byte) 2;
          this.IsCurrencyPartNameFeminine = true;
          break;
        case CurrencyInfo.Currencies.Tunisia:
          this.CurrencyID = 3;
          this.CurrencyCode = "TND";
          this.IsCurrencyNameFeminine = false;
          this.EnglishCurrencyName = "Tunisian Dinar";
          this.EnglishPluralCurrencyName = "Tunisian Dinars";
          this.EnglishCurrencyPartName = "milim";
          this.EnglishPluralCurrencyPartName = "millimes";
          this.Arabic1CurrencyName = "دينار تونسي";
          this.Arabic2CurrencyName = "ديناران تونسيان";
          this.Arabic310CurrencyName = "دنانير تونسية";
          this.Arabic1199CurrencyName = "ديناراً تونسياً";
          this.Arabic1CurrencyPartName = "مليم";
          this.Arabic2CurrencyPartName = "مليمان";
          this.Arabic310CurrencyPartName = "ملاليم";
          this.Arabic1199CurrencyPartName = "مليماً";
          this.PartPrecision = (byte) 3;
          this.IsCurrencyPartNameFeminine = false;
          break;
        case CurrencyInfo.Currencies.Gold:
          this.CurrencyID = 4;
          this.CurrencyCode = "XAU";
          this.IsCurrencyNameFeminine = false;
          this.EnglishCurrencyName = "Gram";
          this.EnglishPluralCurrencyName = "Grams";
          this.EnglishCurrencyPartName = "Milligram";
          this.EnglishPluralCurrencyPartName = "Milligrams";
          this.Arabic1CurrencyName = "جرام";
          this.Arabic2CurrencyName = "جرامان";
          this.Arabic310CurrencyName = "جرامات";
          this.Arabic1199CurrencyName = "جراماً";
          this.Arabic1CurrencyPartName = "ملجرام";
          this.Arabic2CurrencyPartName = "ملجرامان";
          this.Arabic310CurrencyPartName = "ملجرامات";
          this.Arabic1199CurrencyPartName = "ملجراماً";
          this.PartPrecision = (byte) 2;
          this.IsCurrencyPartNameFeminine = false;
          break;
      }
    }

    public int CurrencyID { get; set; }

    public string CurrencyCode { get; set; }

    public bool IsCurrencyNameFeminine { get; set; }

    public string EnglishCurrencyName { get; set; }

    public string EnglishPluralCurrencyName { get; set; }

    public string Arabic1CurrencyName { get; set; }

    public string Arabic2CurrencyName { get; set; }

    public string Arabic310CurrencyName { get; set; }

    public string Arabic1199CurrencyName { get; set; }

    public byte PartPrecision { get; set; }

    public bool IsCurrencyPartNameFeminine { get; set; }

    public string EnglishCurrencyPartName { get; set; }

    public string EnglishPluralCurrencyPartName { get; set; }

    public string Arabic1CurrencyPartName { get; set; }

    public string Arabic2CurrencyPartName { get; set; }

    public string Arabic310CurrencyPartName { get; set; }

    public string Arabic1199CurrencyPartName { get; set; }

    public enum Currencies
    {
      Sudan,
      UAE,
      SaudiArabia,
      Tunisia,
      Gold,
    }
  }
}
