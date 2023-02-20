// Decompiled with JetBrains decompiler
// Type: CardPrinter.CardBack
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace CardPrinter
{
  public class CardBack : XtraReport
  {
    private IContainer components;
    private DetailBand Detail;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private XRLabel xrLabel1;
    private XRPictureBox xrPictureBox1;
    private XRLine xrLine3;
    private XRLine xrLine4;
    private XRLine xrLine1;
    private XRLine xrLine2;
    private XRLabel xrLabel2;

    public CardBack()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    private void Detail_BeforePrint(object sender, PrintEventArgs e)
    {
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CardBack));
      this.Detail = new DetailBand();
      this.xrLabel2 = new XRLabel();
      this.xrLine3 = new XRLine();
      this.xrLine4 = new XRLine();
      this.xrLine1 = new XRLine();
      this.xrLine2 = new XRLine();
      this.xrLabel1 = new XRLabel();
      this.xrPictureBox1 = new XRPictureBox();
      this.TopMargin = new TopMarginBand();
      this.BottomMargin = new BottomMarginBand();
      ((ISupportInitialize) this).BeginInit();
      ((XRControl) this.Detail).get_Controls().AddRange(new XRControl[7]
      {
        (XRControl) this.xrLabel2,
        (XRControl) this.xrLine3,
        (XRControl) this.xrLine4,
        (XRControl) this.xrLine1,
        (XRControl) this.xrLine2,
        (XRControl) this.xrLabel1,
        (XRControl) this.xrPictureBox1
      });
      ((XRControl) this.Detail).set_Font(new Font("Times New Roman", 6f));
      ((XRControl) this.Detail).set_HeightF(182.744f);
      ((XRControl) this.Detail).set_KeepTogether(true);
      this.Detail.set_KeepTogetherWithDetailReports(true);
      ((XRControl) this.Detail).set_Name("Detail");
      ((XRControl) this.Detail).set_Padding(new PaddingInfo(0, 0, 0, 0, 100f));
      ((XRControl) this.Detail).get_StylePriority().set_UseFont(false);
      ((XRControl) this.Detail).set_TextAlignment((TextAlignment) 1);
      ((XRControl) this.Detail).add_BeforePrint(new PrintEventHandler(this.Detail_BeforePrint));
      ((XRControl) this.xrLabel2).set_Font(new Font("Times New Roman", 8f, FontStyle.Bold));
      ((XRControl) this.xrLabel2).set_ForeColor(Color.Red);
      ((XRControl) this.xrLabel2).set_LocationFloat(new PointFloat(112.125f, 155.4678f));
      ((XRControl) this.xrLabel2).set_Name("xrLabel2");
      ((XRControl) this.xrLabel2).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel2).set_SizeF(new SizeF(120.2916f, 14.66666f));
      ((XRControl) this.xrLabel2).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel2).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.xrLabel2).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.xrLabel2).set_Text("صالحة لمد عام دراسي واحد *");
      ((XRControl) this.xrLabel2).set_TextAlignment((TextAlignment) 4);
      ((XRControl) this.xrLine3).set_ForeColor(Color.DarkRed);
      this.xrLine3.set_LineDirection((LineDirection) 1);
      this.xrLine3.set_LineStyle(DashStyle.DashDot);
      this.xrLine3.set_LineWidth(2f);
      ((XRControl) this.xrLine3).set_LocationFloat(new PointFloat(297.125f, 0.0f));
      ((XRControl) this.xrLine3).set_Name("xrLine3");
      ((XRControl) this.xrLine3).set_SizeF(new SizeF(52.08337f, 52.08334f));
      ((XRControl) this.xrLine3).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.xrLine4).set_ForeColor(Color.MediumBlue);
      this.xrLine4.set_LineDirection((LineDirection) 1);
      this.xrLine4.set_LineStyle(DashStyle.DashDotDot);
      this.xrLine4.set_LineWidth(2f);
      ((XRControl) this.xrLine4).set_LocationFloat(new PointFloat(312.0417f, 1.666673f));
      ((XRControl) this.xrLine4).set_Name("xrLine4");
      ((XRControl) this.xrLine4).set_SizeF(new SizeF(38.54167f, 38.54167f));
      ((XRControl) this.xrLine4).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.xrLine1).set_ForeColor(Color.MediumBlue);
      this.xrLine1.set_LineDirection((LineDirection) 0);
      this.xrLine1.set_LineStyle(DashStyle.DashDot);
      this.xrLine1.set_LineWidth(2f);
      ((XRControl) this.xrLine1).set_LocationFloat(new PointFloat(0.0f, 0.0f));
      ((XRControl) this.xrLine1).set_Name("xrLine1");
      ((XRControl) this.xrLine1).set_SizeF(new SizeF(38.54167f, 38.54167f));
      ((XRControl) this.xrLine1).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.xrLine2).set_ForeColor(Color.DarkRed);
      this.xrLine2.set_LineDirection((LineDirection) 0);
      this.xrLine2.set_LineStyle(DashStyle.DashDot);
      this.xrLine2.set_LineWidth(2f);
      ((XRControl) this.xrLine2).set_LocationFloat(new PointFloat(0.0f, 0.0f));
      ((XRControl) this.xrLine2).set_Name("xrLine2");
      ((XRControl) this.xrLine2).set_SizeF(new SizeF(54.16668f, 54.16667f));
      ((XRControl) this.xrLine2).get_StylePriority().set_UseForeColor(false);
      ((XRControl) this.xrLabel1).set_Font(new Font("Times New Roman", 9f, FontStyle.Bold));
      ((XRControl) this.xrLabel1).set_LocationFloat(new PointFloat(2.04167f, 63.2505f));
      this.xrLabel1.set_Multiline(true);
      ((XRControl) this.xrLabel1).set_Name("xrLabel1");
      ((XRControl) this.xrLabel1).set_Padding(new PaddingInfo(2, 2, 0, 0, 100f));
      ((XRControl) this.xrLabel1).set_SizeF(new SizeF(328.875f, 87.15127f));
      ((XRControl) this.xrLabel1).get_StylePriority().set_UseFont(false);
      ((XRControl) this.xrLabel1).get_StylePriority().set_UseTextAlignment(false);
      ((XRControl) this.xrLabel1).set_Text(componentResourceManager.GetString("xrLabel1.Text"));
      ((XRControl) this.xrLabel1).set_TextAlignment((TextAlignment) 4);
      this.xrPictureBox1.set_ImageSource(new ImageSource("img", componentResourceManager.GetString("xrPictureBox1.ImageSource")));
      ((XRControl) this.xrPictureBox1).set_LocationFloat(new PointFloat(136.3855f, 0.9583473f));
      ((XRControl) this.xrPictureBox1).set_Name("xrPictureBox1");
      ((XRControl) this.xrPictureBox1).set_SizeF(new SizeF(73.47919f, 60.33384f));
      this.xrPictureBox1.set_Sizing((ImageSizeMode) 1);
      ((XRControl) this.TopMargin).set_HeightF(0.0f);
      ((XRControl) this.TopMargin).set_Name("TopMargin");
      ((XRControl) this.TopMargin).set_Padding(new PaddingInfo(0, 0, 0, 0, 100f));
      ((XRControl) this.TopMargin).set_TextAlignment((TextAlignment) 1);
      ((XRControl) this.BottomMargin).set_HeightF(0.0f);
      ((XRControl) this.BottomMargin).set_Name("BottomMargin");
      ((XRControl) this.BottomMargin).set_Padding(new PaddingInfo(0, 0, 0, 0, 100f));
      ((XRControl) this.BottomMargin).set_TextAlignment((TextAlignment) 1);
      ((XtraReportBase) this).get_Bands().AddRange(new Band[3]
      {
        (Band) this.Detail,
        (Band) this.TopMargin,
        (Band) this.BottomMargin
      });
      this.set_Landscape(true);
      this.set_Margins(new Margins(0, 0, 0, 0));
      this.set_PageHeight(186);
      this.set_PageWidth(351);
      this.set_PaperKind(PaperKind.Custom);
      this.set_SnappingMode((SnappingMode) 0);
      this.set_Version("19.2");
      ((ISupportInitialize) this).EndInit();
    }
  }
}
