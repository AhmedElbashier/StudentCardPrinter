// Decompiled with JetBrains decompiler
// Type: CardPrinter.CardFront
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using CardPrinter.Properties;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;

namespace CardPrinter
{
  public class CardFront : XtraReport
  {
    private ReportApi reportApi;
    private IContainer components;
    private DetailBand Detail;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRPictureBox StdPic;
    private XRLabel StdYear;
    private XRLabel xrLabel8;
    private XRLabel xrLabel6;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel7;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRLabel StdName;
    private XRLabel StdProgram;
    private XRLabel StdClass;
    private XRLabel CollegeNumber;
    private XRPictureBox xrPictureBox2;
    private XRLine xrLine2;
    private XRLine xrLine1;

    public CardFront(int Id)
    {
      base.\u002Ector();
      this.InitializeComponent();
      this.FillTable(Id);
    }

    public CardFront()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    public void FillTable(int Id)
    {
      Card card = (Card) JToken.Parse(this.reportApi.getData(this.reportApi.URL + "reports/card/" + (object) Id)).ToObject<Card>();
      ((XRControl) this.StdName).set_Text(card.StdName);
      ((XRControl) this.StdProgram).set_Text(card.program);
      ((XRControl) this.StdClass).set_Text(card.StdClass);
      ((XRControl) this.StdYear).set_Text(card.stdYear);
      ((XRControl) this.CollegeNumber).set_Text(card.collegeNumber);
      using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(card.pic)))
        this.StdPic.set_Image(Image.FromStream((Stream) memoryStream));
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CardFront));
      this.Detail = new DetailBand();
      this.xrLine2 = new XRLine();
      this.xrLine1 = new XRLine();
      this.xrPictureBox2 = new XRPictureBox();
      this.StdPic = new XRPictureBox();
      this.StdYear = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.xrLabel7 = new XRLabel();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.StdName = new XRLabel();
      this.StdProgram = new XRLabel();
      this.StdClass = new XRLabel();
      this.CollegeNumber = new XRLabel();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      ((ISupportInitialize) this).BeginInit();
      ((XRControl) this.Detail).set_BorderColor(Color.Transparent);
      ((XRControl) this.Detail).set_BorderWidth(9f);
      ((XRControl) this.Detail).get_Controls().AddRange(new XRControl[16]
      {
        (XRControl) this.xrLine2,
        (XRControl) this.xrLine1,
        (XRControl) this.xrPictureBox2,
        (XRControl) this.StdPic,
        (XRControl) this.StdYear,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrPictureBox1,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLabel1,
        (XRControl) this.StdName,
        (XRControl) this.StdProgram,
        (XRControl) this.StdClass,
        (XRControl) this.CollegeNumber
      });
      ((XRControl) this.Detail).set_HeightF(185.0072f);
      ((XRControl) this.Detail).set_KeepTogether(true);
      this.Detail.set_KeepTogetherWithDetailReports(true);
      ((XRControl) this.Detail).set_Name("Detail");
      ((XRControl) this.Detail).set_Padding(new PaddingInfo(0, 0, 0, 0, 100f));
      ((XRControl) this.Detail).set_SnapLinePadding(new PaddingInfo(0, 0, 0, 0, 100f));
      ((XRControl) this.Detail).get_StylePriority().set_UseBorderColor(false);
      ((XRControl) this.Detail).get_StylePriority().set_UseBorderWidth(false);
      ((XRControl) this.Detail).set_TextAlignment((TextAlignment) 1);
      ((XRControl) this.xrLine2).set_ForeColor(Color.DarkRed);
      this.xrLine2.set_LineDirection((LineDirection) 0);
      this.xrLine2.set_LineStyle(DashStyle.DashDot);
      this.xrLine2.set_LineWidth(2f);
      ((XRControl) this.xrLine2).set_LocationFloat(new PointFloat(1.041667f, 2.083333f));
      ((XRControl) this.xrLine2).set_Name("xrLine2");
      ((XRControl) this.xrLine2).set_SizeF(new SizeF(48.95834f, 48.95834f));
      ((XRControl) this.xrLine2).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.xrLine1).set_ForeColor(Color.MediumBlue);
      this.xrLine1.set_LineDirection((LineDirection) 0);
      this.xrLine1.set_LineStyle(DashStyle.DashDot);
      this.xrLine1.set_LineWidth(2f);
      ((XRControl) this.xrLine1).set_LocationFloat(new PointFloat(2f, 1f));
      ((XRControl) this.xrLine1).set_Name("xrLine1");
      ((XRControl) this.xrLine1).set_SizeF(new SizeF(38.54167f, 38.54167f));
      ((XRControl) this.xrLine1).get_StylePriority().set_UseForeColor(false);
      this.xrPictureBox2.set_ImageSource(new ImageSource((Image) Resources.devenv_5A0sJN0pUM, true));
      ((XRControl) this.xrPictureBox2).set_LocationFloat(new PointFloat(28.55903f, 147.5347f));
      ((XRControl) this.xrPictureBox2).set_Name("xrPictureBox2");
      ((XRControl) this.xrPictureBox2).set_SizeF(new SizeF(73.09029f, 19.26733f));
      this.xrPictureBox2.set_Sizing((ImageSizeMode) 1);
      ((XRControl) this.StdPic).set_LocationFloat(new PointFloat(20.57406f, 49.32467f));
      ((XRControl) this.StdPic).set_Name("StdPic");
      ((XRControl) this.StdPic).set_SizeF(new SizeF(72.9167f, 72.75037f));
      this.StdPic.set_Sizing((ImageSizeMode) 1);
      ((XRControl) this.StdYear).set_Font(new Font("Times New Roman", 9f));
      ((XRControl) this.StdYear).set_ForeColor(Color.Red);
      ((XRControl) this.StdYear).set_LocationFloat(new PointFloat(123.5915f, 70.77843f));
      ((XRControl) this.StdYear).set_Name("StdYear");
      ((XRControl) this.StdYear).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.StdYear).set_SizeF(new SizeF(84.88149f, 13.40702f));
      ((XRControl) this.StdYear).get_StylePriority().set_UseFont(false);
      ((XRControl) this.StdYear).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.StdYear).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.StdYear).set_Text("2020");
      ((XRControl) this.StdYear).set_TextAlignment((TextAlignment) 2);
      ((XRControl) this.xrLabel8).set_Font(new Font("Times New Roman", 10f, FontStyle.Bold));
      ((XRControl) this.xrLabel8).set_LocationFloat(new PointFloat(127.6275f, 54.33391f));
      ((XRControl) this.xrLabel8).set_Name("xrLabel8");
      ((XRControl) this.xrLabel8).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel8).set_SizeF(new SizeF(63.02092f, 15.70832f));
      ((XRControl) this.xrLabel8).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel8).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.xrLabel8).set_Text("بطاقة طالب");
      ((XRControl) this.xrLabel8).set_TextAlignment((TextAlignment) 2);
      ((XRControl) this.xrLabel6).set_Font(new Font("Times New Roman", 10f, FontStyle.Bold));
      ((XRControl) this.xrLabel6).set_LocationFloat(new PointFloat(75.37503f, 9.917212f));
      this.xrLabel6.set_Multiline(true);
      ((XRControl) this.xrLabel6).set_Name("xrLabel6");
      ((XRControl) this.xrLabel6).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel6).set_SizeF(new SizeF(184.375f, 33.41669f));
      ((XRControl) this.xrLabel6).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel6).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.xrLabel6).set_Text("وزارة التعليم العالي و البحث العلمي  \r\n كلية المدائن للعلوم الطبية و التكنولوجيا");
      ((XRControl) this.xrLabel6).set_TextAlignment((TextAlignment) 2);
      this.xrPictureBox1.set_ImageSource(new ImageSource("img", componentResourceManager.GetString("xrPictureBox1.ImageSource")));
      ((XRControl) this.xrPictureBox1).set_LocationFloat(new PointFloat(265.1667f, 9.917212f));
      ((XRControl) this.xrPictureBox1).set_Name("xrPictureBox1");
      ((XRControl) this.xrPictureBox1).set_SizeF(new SizeF(73.16666f, 68.54166f));
      this.xrPictureBox1.set_Sizing((ImageSizeMode) 1);
      ((XRControl) this.xrLabel7).set_Font(new Font("Times New Roman", 8f, FontStyle.Bold));
      ((XRControl) this.xrLabel7).set_ForeColor(Color.FromArgb(0, 0, 192));
      ((XRControl) this.xrLabel7).set_LocationFloat(new PointFloat(15.58673f, 167.2155f));
      ((XRControl) this.xrLabel7).set_Name("xrLabel7");
      ((XRControl) this.xrLabel7).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel7).set_SizeF(new SizeF(103.1251f, 17.79169f));
      ((XRControl) this.xrLabel7).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel7).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.xrLabel7).set_Text("توقيع أمين الشؤون العلمية");
      ((XRControl) this.xrLabel3).set_Font(new Font("Times New Roman", 9f, FontStyle.Bold));
      ((XRControl) this.xrLabel3).set_LocationFloat(new PointFloat(273.4974f, 147.3845f));
      ((XRControl) this.xrLabel3).set_Name("xrLabel3");
      ((XRControl) this.xrLabel3).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel3).set_SizeF(new SizeF(60.91672f, 14.66669f));
      ((XRControl) this.xrLabel3).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel3).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.xrLabel3).set_Text(":المســـتوى");
      ((XRControl) this.xrLabel3).set_TextAlignment((TextAlignment) 4);
      ((XRControl) this.xrLabel2).set_Font(new Font("Times New Roman", 9f, FontStyle.Bold));
      ((XRControl) this.xrLabel2).set_LocationFloat(new PointFloat(273.4975f, 125.8012f));
      ((XRControl) this.xrLabel2).set_Name("xrLabel2");
      ((XRControl) this.xrLabel2).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel2).set_SizeF(new SizeF(60.9166f, 12.58334f));
      ((XRControl) this.xrLabel2).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel2).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.xrLabel2).set_Text(":البرنــــامج");
      ((XRControl) this.xrLabel2).set_TextAlignment((TextAlignment) 4);
      ((XRControl) this.xrLabel1).set_Font(new Font("Times New Roman", 9f, FontStyle.Bold));
      ((XRControl) this.xrLabel1).set_LocationFloat(new PointFloat(273.4974f, 103.2178f));
      ((XRControl) this.xrLabel1).set_Name("xrLabel1");
      ((XRControl) this.xrLabel1).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel1).set_SizeF(new SizeF(60.9166f, 12.58335f));
      ((XRControl) this.xrLabel1).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel1).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.xrLabel1).set_Text(": الإســــــــم");
      ((XRControl) this.xrLabel1).set_TextAlignment((TextAlignment) 4);
      ((XRControl) this.StdName).set_Font(new Font("Times New Roman", 9f));
      ((XRControl) this.StdName).set_LocationFloat(new PointFloat(116.866f, 103.2177f));
      ((XRControl) this.StdName).set_Name("StdName");
      ((XRControl) this.StdName).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.StdName).set_SizeF(new SizeF(153.4648f, 12.58334f));
      ((XRControl) this.StdName).get_StylePriority().set_UseFont(false);
      ((XRControl) this.StdName).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.StdName).set_TextAlignment((TextAlignment) 4);
      ((XRControl) this.StdProgram).set_Font(new Font("Times New Roman", 9f));
      ((XRControl) this.StdProgram).set_LocationFloat(new PointFloat(116.866f, 125.8011f));
      ((XRControl) this.StdProgram).set_Name("StdProgram");
      ((XRControl) this.StdProgram).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.StdProgram).set_SizeF(new SizeF(153.4648f, 12.58334f));
      ((XRControl) this.StdProgram).get_StylePriority().set_UseFont(false);
      ((XRControl) this.StdProgram).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.StdProgram).set_TextAlignment((TextAlignment) 4);
      ((XRControl) this.StdClass).set_Font(new Font("Times New Roman", 9f));
      ((XRControl) this.StdClass).set_LocationFloat(new PointFloat(203.2141f, 147.3845f));
      ((XRControl) this.StdClass).set_Name("StdClass");
      ((XRControl) this.StdClass).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.StdClass).set_SizeF(new SizeF(67.11661f, 14.66669f));
      ((XRControl) this.StdClass).get_StylePriority().set_UseFont(false);
      ((XRControl) this.StdClass).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.StdClass).set_TextAlignment((TextAlignment) 4);
      ((XRControl) this.CollegeNumber).set_CanGrow(false);
      ((XRControl) this.CollegeNumber).set_LocationFloat(new PointFloat(20.90732f, 124.2f));
      ((XRControl) this.CollegeNumber).set_Name("CollegeNumber");
      ((XRControl) this.CollegeNumber).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.CollegeNumber).set_SizeF(new SizeF(78.75009f, 12.58334f));
      ((XRControl) this.CollegeNumber).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.CollegeNumber).set_TextAlignment((TextAlignment) 2);
      ((XRControl) this.TopMargin).set_HeightF(0.0f);
      ((XRControl) this.TopMargin).set_Name("TopMargin");
      ((XRControl) this.TopMargin).set_Padding(new PaddingInfo(0, 0, 0, 0, 100f));
      ((XRControl) this.TopMargin).set_TextAlignment((TextAlignment) 1);
      ((XRControl) this.BottomMargin).set_BorderWidth(0.0f);
      ((XRControl) this.BottomMargin).set_HeightF(0.0f);
      ((XRControl) this.BottomMargin).set_Name("BottomMargin");
      ((XRControl) this.BottomMargin).set_Padding(new PaddingInfo(0, 0, 0, 0, 100f));
      ((XRControl) this.BottomMargin).get_StylePriority().set_UseBorderWidth(false);
      ((XRControl) this.BottomMargin).set_TextAlignment((TextAlignment) 1);
      ((XtraReportBase) this).get_Bands().AddRange(new Band[3]
      {
        (Band) this.Detail,
        (Band) this.TopMargin,
        (Band) this.BottomMargin
      });
      ((XRControl) this).set_Font(new Font("Times New Roman", 9f));
      this.set_Landscape(true);
      this.set_Margins(new Margins(0, 0, 0, 0));
      this.set_PageHeight(195);
      this.set_PageWidth(352);
      this.set_PaperKind(PaperKind.Custom);
      this.set_SnappingMode((SnappingMode) 0);
      this.set_Version("19.2");
      ((ISupportInitialize) this).EndInit();
    }
  }
}
