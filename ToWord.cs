// Decompiled with JetBrains decompiler
// Type: CardPrinter.ToWord
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using System;

namespace CardPrinter
{
  internal class ToWord
  {
    private long _intergerValue;
    private int _decimalValue;
    private static string[] englishOnes = new string[20]
    {
      "Zero",
      "One",
      "Two",
      "Three",
      "Four",
      "Five",
      "Six",
      "Seven",
      "Eight",
      "Nine",
      "Ten",
      "Eleven",
      "Twelve",
      "Thirteen",
      "Fourteen",
      "Fifteen",
      "Sixteen",
      "Seventeen",
      "Eighteen",
      "Nineteen"
    };
    private static string[] englishTens = new string[8]
    {
      "Twenty",
      "Thirty",
      "Forty",
      "Fifty",
      "Sixty",
      "Seventy",
      "Eighty",
      "Ninety"
    };
    private static string[] englishGroup = new string[35]
    {
      "Hundred",
      "Thousand",
      "Million",
      "Billion",
      "Trillion",
      "Quadrillion",
      "Quintillion",
      "Sextillian",
      "Septillion",
      "Octillion",
      "Nonillion",
      "Decillion",
      "Undecillion",
      "Duodecillion",
      "Tredecillion",
      "Quattuordecillion",
      "Quindecillion",
      "Sexdecillion",
      "Septendecillion",
      "Octodecillion",
      "Novemdecillion",
      "Vigintillion",
      "Unvigintillion",
      "Duovigintillion",
      "10^72",
      "10^75",
      "10^78",
      "10^81",
      "10^84",
      "10^87",
      "Vigintinonillion",
      "10^93",
      "10^96",
      "Duotrigintillion",
      "Trestrigintillion"
    };
    private static string[] arabicOnes = new string[20]
    {
      string.Empty,
      "واحد",
      "اثنان",
      "ثلاثة",
      "أربعة",
      "خمسة",
      "ستة",
      "سبعة",
      "ثمانية",
      "تسعة",
      "عشرة",
      "أحد عشر",
      "اثنا عشر",
      "ثلاثة عشر",
      "أربعة عشر",
      "خمسة عشر",
      "ستة عشر",
      "سبعة عشر",
      "ثمانية عشر",
      "تسعة عشر"
    };
    private static string[] arabicFeminineOnes = new string[20]
    {
      string.Empty,
      "إحدى",
      "اثنتان",
      "ثلاث",
      "أربع",
      "خمس",
      "ست",
      "سبع",
      "ثمان",
      "تسع",
      "عشر",
      "إحدى عشرة",
      "اثنتا عشرة",
      "ثلاث عشرة",
      "أربع عشرة",
      "خمس عشرة",
      "ست عشرة",
      "سبع عشرة",
      "ثماني عشرة",
      "تسع عشرة"
    };
    private static string[] arabicTens = new string[8]
    {
      "عشرون",
      "ثلاثون",
      "أربعون",
      "خمسون",
      "ستون",
      "سبعون",
      "ثمانون",
      "تسعون"
    };
    private static string[] arabicHundreds = new string[10]
    {
      "",
      "مائة",
      "مئتان",
      "ثلاثمائة",
      "أربعمائة",
      "خمسمائة",
      "ستمائة",
      "سبعمائة",
      "ثمانمائة",
      "تسعمائة"
    };
    private static string[] arabicAppendedTwos = new string[8]
    {
      "مئتا",
      "ألفا",
      "مليونا",
      "مليارا",
      "تريليونا",
      "كوادريليونا",
      "كوينتليونا",
      "سكستيليونا"
    };
    private static string[] arabicTwos = new string[8]
    {
      "مئتان",
      "ألفان",
      "مليونان",
      "ملياران",
      "تريليونان",
      "كوادريليونان",
      "كوينتليونان",
      "سكستيليونان"
    };
    private static string[] arabicGroup = new string[8]
    {
      "مائة",
      "ألف",
      "مليون",
      "مليار",
      "تريليون",
      "كوادريليون",
      "كوينتليون",
      "سكستيليون"
    };
    private static string[] arabicAppendedGroup = new string[8]
    {
      "",
      "ألفاً",
      "مليوناً",
      "ملياراً",
      "تريليوناً",
      "كوادريليوناً",
      "كوينتليوناً",
      "سكستيليوناً"
    };
    private static string[] arabicPluralGroups = new string[8]
    {
      "",
      "آلاف",
      "ملايين",
      "مليارات",
      "تريليونات",
      "كوادريليونات",
      "كوينتليونات",
      "سكستيليونات"
    };

    public Decimal Number { get; set; }

    public CurrencyInfo Currency { get; set; }

    public string EnglishPrefixText { get; set; }

    public string EnglishSuffixText { get; set; }

    public string ArabicPrefixText { get; set; }

    public string ArabicSuffixText { get; set; }

    public ToWord(Decimal number, CurrencyInfo currency) => this.InitializeClass(number, currency, string.Empty, "only.", "فقط", "لا غير.");

    public ToWord(
      Decimal number,
      CurrencyInfo currency,
      string englishPrefixText,
      string englishSuffixText,
      string arabicPrefixText,
      string arabicSuffixText) => this.InitializeClass(number, currency, englishPrefixText, englishSuffixText, arabicPrefixText, arabicSuffixText);

    private void InitializeClass(
      Decimal number,
      CurrencyInfo currency,
      string englishPrefixText,
      string englishSuffixText,
      string arabicPrefixText,
      string arabicSuffixText)
    {
      this.Number = number;
      this.Currency = currency;
      this.EnglishPrefixText = englishPrefixText;
      this.EnglishSuffixText = englishSuffixText;
      this.ArabicPrefixText = arabicPrefixText;
      this.ArabicSuffixText = arabicSuffixText;
      this.ExtractIntegerAndDecimalParts();
    }

    private string GetDecimalValue(string decimalPart)
    {
      string empty = string.Empty;
      string str;
      if ((int) this.Currency.PartPrecision != decimalPart.Length)
      {
        int length = decimalPart.Length;
        for (int index = 0; index < (int) this.Currency.PartPrecision - length; ++index)
          decimalPart += "0";
        str = Math.Round(Convert.ToDecimal(string.Format("{0}.{1}", (object) decimalPart.Substring(0, (int) this.Currency.PartPrecision), (object) decimalPart.Substring((int) this.Currency.PartPrecision, decimalPart.Length - (int) this.Currency.PartPrecision)))).ToString();
      }
      else
        str = decimalPart;
      for (int index = 0; index < (int) this.Currency.PartPrecision - str.Length; ++index)
        str += "0";
      return str;
    }

    private void ExtractIntegerAndDecimalParts()
    {
      string[] strArray = this.Number.ToString().Split('.');
      this._intergerValue = (long) Convert.ToInt32(strArray[0]);
      if (strArray.Length <= 1)
        return;
      this._decimalValue = Convert.ToInt32(this.GetDecimalValue(strArray[1]));
    }

    private string ProcessGroup(int groupNumber)
    {
      int index1 = groupNumber % 100;
      int index2 = groupNumber / 100;
      string str = string.Empty;
      if (index2 > 0)
        str = string.Format("{0} {1}", (object) ToWord.englishOnes[index2], (object) ToWord.englishGroup[0]);
      if (index1 > 0)
      {
        if (index1 < 20)
        {
          str = str + (str != string.Empty ? " " : string.Empty) + ToWord.englishOnes[index1];
        }
        else
        {
          int index3 = index1 % 10;
          int index4 = index1 / 10 - 2;
          str = str + (str != string.Empty ? " " : string.Empty) + ToWord.englishTens[index4];
          if (index3 > 0)
            str = str + (str != string.Empty ? " " : string.Empty) + ToWord.englishOnes[index3];
        }
      }
      return str;
    }

    public string ConvertToEnglish()
    {
      Decimal number = this.Number;
      if (number == 0M)
        return "Zero";
      string str1 = this.ProcessGroup(this._decimalValue);
      string str2 = string.Empty;
      int index = 0;
      if (number < 1M)
      {
        str2 = ToWord.englishOnes[0];
      }
      else
      {
        while (number >= 1M)
        {
          int groupNumber = (int) (number % 1000M);
          number /= 1000M;
          string str3 = this.ProcessGroup(groupNumber);
          if (str3 != string.Empty)
          {
            if (index > 0)
              str2 = string.Format("{0} {1}", (object) ToWord.englishGroup[index], (object) str2);
            str2 = string.Format("{0} {1}", (object) str3, (object) str2);
          }
          ++index;
        }
      }
      return string.Empty + (this.EnglishPrefixText != string.Empty ? string.Format("{0} ", (object) this.EnglishPrefixText) : string.Empty) + (str2 != string.Empty ? str2 : string.Empty) + (str2 != string.Empty ? (this._intergerValue == 1L ? this.Currency.EnglishCurrencyName : this.Currency.EnglishPluralCurrencyName) : string.Empty) + (str1 != string.Empty ? " and " : string.Empty) + (str1 != string.Empty ? str1 : string.Empty) + (str1 != string.Empty ? " " + (this._decimalValue == 1 ? this.Currency.EnglishCurrencyPartName : this.Currency.EnglishPluralCurrencyPartName) : string.Empty) + (this.EnglishSuffixText != string.Empty ? string.Format(" {0}", (object) this.EnglishSuffixText) : string.Empty);
    }

    private string GetDigitFeminineStatus(int digit, int groupLevel)
    {
      switch (groupLevel)
      {
        case -1:
          return this.Currency.IsCurrencyPartNameFeminine ? ToWord.arabicFeminineOnes[digit] : ToWord.arabicOnes[digit];
        case 0:
          return this.Currency.IsCurrencyNameFeminine ? ToWord.arabicFeminineOnes[digit] : ToWord.arabicOnes[digit];
        default:
          return ToWord.arabicOnes[digit];
      }
    }

    private string ProcessArabicGroup(int groupNumber, int groupLevel, Decimal remainingNumber)
    {
      int digit1 = groupNumber % 100;
      int index1 = groupNumber / 100;
      string str = string.Empty;
      if (index1 > 0)
        str = digit1 != 0 || index1 != 2 ? string.Format("{0}", (object) ToWord.arabicHundreds[index1]) : string.Format("{0}", (object) ToWord.arabicAppendedTwos[0]);
      if (digit1 > 0)
      {
        if (digit1 < 20)
        {
          if (digit1 == 2 && index1 == 0 && groupLevel > 0)
          {
            str = this._intergerValue != 2000L && this._intergerValue != 2000000L && (this._intergerValue != 2000000000L && this._intergerValue != 2000000000000L) && this._intergerValue != 2000000000000000L && this._intergerValue != 2000000000000000000L ? string.Format("{0}", (object) ToWord.arabicTwos[groupLevel]) : string.Format("{0}", (object) ToWord.arabicAppendedTwos[groupLevel]);
          }
          else
          {
            if (str != string.Empty)
              str += " و ";
            str = digit1 != 1 || groupLevel <= 0 || index1 != 0 ? (digit1 != 1 && digit1 != 2 || groupLevel != 0 && groupLevel != -1 || index1 != 0 || !(remainingNumber == 0M) ? str + this.GetDigitFeminineStatus(digit1, groupLevel) : str + string.Empty) : str + " ";
          }
        }
        else
        {
          int digit2 = digit1 % 10;
          int index2 = digit1 / 10 - 2;
          if (digit2 > 0)
          {
            if (str != string.Empty)
              str += " و ";
            str += this.GetDigitFeminineStatus(digit2, groupLevel);
          }
          if (str != string.Empty)
            str += " و ";
          str += ToWord.arabicTens[index2];
        }
      }
      return str;
    }

    public string ConvertToArabic()
    {
      Decimal number = this.Number;
      if (number == 0M)
        return "صفر";
      string str1 = this.ProcessArabicGroup(this._decimalValue, -1, 0M);
      string str2 = string.Empty;
      byte num1 = 0;
      while (number >= 1M)
      {
        int groupNumber = (int) (number % 1000M);
        number /= 1000M;
        string str3 = this.ProcessArabicGroup(groupNumber, (int) num1, Math.Floor(number));
        if (str3 != string.Empty)
        {
          if (num1 > (byte) 0)
          {
            if (str2 != string.Empty)
              str2 = string.Format("{0} {1}", (object) "و", (object) str2);
            if (groupNumber != 2)
              str2 = groupNumber % 100 == 1 ? string.Format("{0} {1}", (object) ToWord.arabicGroup[(int) num1], (object) str2) : (groupNumber < 3 || groupNumber > 10 ? (!(str2 != string.Empty) ? string.Format("{0} {1}", (object) ToWord.arabicGroup[(int) num1], (object) str2) : string.Format("{0} {1}", (object) ToWord.arabicAppendedGroup[(int) num1], (object) str2)) : string.Format("{0} {1}", (object) ToWord.arabicPluralGroups[(int) num1], (object) str2));
          }
          str2 = string.Format("{0} {1}", (object) str3, (object) str2);
        }
        ++num1;
      }
      string str4 = string.Empty + (this.ArabicPrefixText != string.Empty ? string.Format("{0} ", (object) this.ArabicPrefixText) : string.Empty) + (str2 != string.Empty ? str2 : string.Empty);
      if ((ulong) this._intergerValue > 0UL)
      {
        int num2 = (int) (this._intergerValue % 100L);
        switch (num2)
        {
          case 0:
            str4 += this.Currency.Arabic1CurrencyName;
            break;
          case 1:
            str4 += this.Currency.Arabic1CurrencyName;
            break;
          case 2:
            str4 = this._intergerValue != 2L ? str4 + this.Currency.Arabic1CurrencyName : str4 + this.Currency.Arabic2CurrencyName;
            break;
          default:
            if (num2 >= 3 && num2 <= 10)
            {
              str4 += this.Currency.Arabic310CurrencyName;
              break;
            }
            if (num2 >= 11 && num2 <= 99)
            {
              str4 += this.Currency.Arabic1199CurrencyName;
              break;
            }
            break;
        }
      }
      string str5 = str4 + (this._decimalValue != 0 ? " و " : string.Empty) + (this._decimalValue != 0 ? str1 : string.Empty);
      if ((uint) this._decimalValue > 0U)
      {
        str5 += " ";
        int num2 = this._decimalValue % 100;
        switch (num2)
        {
          case 0:
            str5 += this.Currency.Arabic1CurrencyPartName;
            break;
          case 1:
            str5 += this.Currency.Arabic1CurrencyPartName;
            break;
          case 2:
            str5 += this.Currency.Arabic2CurrencyPartName;
            break;
          default:
            if (num2 >= 3 && num2 <= 10)
            {
              str5 += this.Currency.Arabic310CurrencyPartName;
              break;
            }
            if (num2 >= 11 && num2 <= 99)
            {
              str5 += this.Currency.Arabic1199CurrencyPartName;
              break;
            }
            break;
        }
      }
      return str5 + (this.ArabicSuffixText != string.Empty ? string.Format(" {0}", (object) this.ArabicSuffixText) : string.Empty);
    }
  }
}
