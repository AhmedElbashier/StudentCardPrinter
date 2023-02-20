// Decompiled with JetBrains decompiler
// Type: CardPrinter.Form1
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CardPrinter
{
  public class Form1 : RibbonForm
  {
    public int count;
    private Database db;
    private IContainer components;
    private GridControl gridControl;
    private GridView gridView;
    private RibbonControl ribbonControl;
    private RibbonPage ribbonPage1;
    private RibbonPageGroup ribbonPageGroup1;
    private BarButtonItem btnPrintAll;
    private RibbonPageGroup ribbonPageGroup2;
    private RibbonStatusBar ribbonStatusBar;
    private BarStaticItem bsiRecordsCount;
    private BarButtonItem bbiRefresh;
    private BarButtonItem btnStudentPrint;
    private GridView gridView1;
    private GridSplitContainer gridSplitContainer1;
    private RibbonPage ribbonPage4;
    private BackgroundWorker backgroundWorker1;

    public Form1()
    {
      base.\u002Ector();
      this.InitializeComponent();
      try
      {
        this.gridControl.set_DataSource((object) this.db.getData());
        ((ColumnView) this.gridView).get_Columns().get_Item(0).set_Caption("اسم الطالب");
        ((ColumnView) this.gridView).get_Columns().get_Item(1).set_Caption("الرقم الجامعي");
        ((ColumnView) this.gridView).get_Columns().get_Item(2).set_Caption("العام الدراسي");
        ((ColumnView) this.gridView).get_Columns().get_Item(3).set_Caption("البرنامج");
        ((ColumnView) this.gridView).get_Columns().get_Item(4).set_Caption("المستوى");
        ((ColumnView) this.gridView).get_Columns().get_Item(5).set_Caption("الفصل الدراسي");
        ((ColumnView) this.gridView).get_Columns().get_Item(6).set_Visible(false);
        ((ColumnView) this.gridView).get_Columns().get_Item(7).set_Visible(false);
        ((BarItem) this.bsiRecordsCount).set_Caption("عدد الطلاب : " + (object) ((BaseView) this.gridView).get_RowCount());
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.count = int.Parse(XtraInputBox.Show("ادخل عدد البطاقات للطباعة", "طباعة البطاقات", "30"));
      this.print();
    }

    public void print()
    {
      try
      {
        for (int index = 0; index < this.count; ++index)
        {
          CardFront cardFront = new CardFront(int.Parse(((ColumnView) this.gridView).GetRowCellValue(index, "id").ToString()));
          CardBack cardBack = new CardBack();
          cardFront.CreateDocument();
          cardBack.CreateDocument();
          cardFront.get_Pages().AddRange((IEnumerable) cardBack.get_Pages());
          ReportPrintTool reportPrintTool = new ReportPrintTool((IReport) cardFront);
          // ISSUE: method pointer
          ((PrintToolBase) reportPrintTool).get_PrintingSystem().add_StartPrint(new PrintDocumentEventHandler((object) this, __methodptr(PrintingSystem_StartPrint)));
          ((PrintToolBase) reportPrintTool).Print();
          this.db.addUser(int.Parse(((ColumnView) this.gridView).GetRowCellValue(index, "id").ToString()));
          ((ColumnView) this.gridView).DeleteRow(index);
          ((BarItem) this.bsiRecordsCount).set_Caption("عدد الطلاب : " + (object) ((BaseView) this.gridView).get_RowCount());
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e) => e.get_PrintDocument().PrinterSettings.Duplex = Duplex.Horizontal;

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        this.print();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void btnStudentPrint_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        CardFront cardFront = new CardFront(this.db.getStudant(XtraInputBox.Show("ادخل الرقم الجامعي للطالب", "طباعة البطاقات", "")));
        CardBack cardBack = new CardBack();
        cardFront.CreateDocument();
        cardBack.CreateDocument();
        cardFront.get_Pages().AddRange((IEnumerable) cardBack.get_Pages());
        ReportPrintTool reportPrintTool = new ReportPrintTool((IReport) cardFront);
        XtraReportPreviewExtensions.ShowPreviewDialog((IReport) cardFront);
      }
      catch
      {
      }
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((XtraForm) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.gridControl = new GridControl();
      this.gridView = new GridView();
      this.ribbonControl = new RibbonControl();
      this.btnPrintAll = new BarButtonItem();
      this.bsiRecordsCount = new BarStaticItem();
      this.bbiRefresh = new BarButtonItem();
      this.btnStudentPrint = new BarButtonItem();
      this.ribbonPage1 = new RibbonPage();
      this.ribbonPageGroup1 = new RibbonPageGroup();
      this.ribbonPageGroup2 = new RibbonPageGroup();
      this.ribbonStatusBar = new RibbonStatusBar();
      this.gridView1 = new GridView();
      this.gridSplitContainer1 = new GridSplitContainer();
      this.ribbonPage4 = new RibbonPage();
      this.backgroundWorker1 = new BackgroundWorker();
      ((ISupportInitialize) this.gridControl).BeginInit();
      ((ISupportInitialize) this.gridView).BeginInit();
      ((ISupportInitialize) this.ribbonControl).BeginInit();
      ((ISupportInitialize) this.gridView1).BeginInit();
      ((ISupportInitialize) this.gridSplitContainer1).BeginInit();
      ((Control) this.gridSplitContainer1).SuspendLayout();
      ((XtraForm) this).SuspendLayout();
      ((Control) this.gridControl).Dock = DockStyle.Fill;
      ((Control) this.gridControl).Location = new Point(0, 0);
      this.gridControl.set_MainView((BaseView) this.gridView);
      ((EditorContainer) this.gridControl).set_MenuManager((IDXMenuManager) this.ribbonControl);
      ((Control) this.gridControl).Name = "gridControl";
      ((Control) this.gridControl).Size = new Size(1147, 482);
      ((Control) this.gridControl).TabIndex = 2;
      this.gridControl.get_ViewCollection().AddRange(new BaseView[2]
      {
        (BaseView) this.gridView,
        (BaseView) this.gridView1
      });
      ((BaseView) this.gridView).set_BorderStyle((BorderStyles) 0);
      ((BaseView) this.gridView).set_GridControl(this.gridControl);
      ((BaseView) this.gridView).set_Name("gridView");
      ((ColumnViewOptionsBehavior) this.gridView.get_OptionsBehavior()).set_Editable(false);
      ((ColumnViewOptionsBehavior) this.gridView.get_OptionsBehavior()).set_ReadOnly(true);
      ((BarItem) this.ribbonControl.get_ExpandCollapseItem()).set_Id(0);
      ((BarItems) this.ribbonControl.get_Items()).AddRange(new BarItem[6]
      {
        (BarItem) this.ribbonControl.get_ExpandCollapseItem(),
        (BarItem) this.ribbonControl.get_SearchEditItem(),
        (BarItem) this.btnPrintAll,
        (BarItem) this.bsiRecordsCount,
        (BarItem) this.bbiRefresh,
        (BarItem) this.btnStudentPrint
      });
      ((Control) this.ribbonControl).Location = new Point(0, 0);
      this.ribbonControl.set_MaxItemId(21);
      ((Control) this.ribbonControl).Name = "ribbonControl";
      this.ribbonControl.get_Pages().AddRange(new RibbonPage[1]
      {
        this.ribbonPage1
      });
      this.ribbonControl.set_RibbonStyle((RibbonControlStyle) 3);
      this.ribbonControl.set_ShowApplicationButton((DefaultBoolean) 1);
      ((Control) this.ribbonControl).Size = new Size(1147, 158);
      this.ribbonControl.set_StatusBar(this.ribbonStatusBar);
      this.ribbonControl.set_ToolbarLocation((RibbonQuickAccessToolbarLocation) 3);
      ((BarItem) this.btnPrintAll).set_Caption("طباعة كل البطاقات");
      ((BarItem) this.btnPrintAll).set_Id(14);
      ((ImageOptions) ((BarItem) this.btnPrintAll).get_ImageOptions()).get_ImageUri().set_Uri("Preview");
      ((BarItem) this.btnPrintAll).set_Name("btnPrintAll");
      // ISSUE: method pointer
      ((BarItem) this.btnPrintAll).add_ItemClick(new ItemClickEventHandler((object) this, __methodptr(bbiPrintPreview_ItemClick)));
      ((BarItem) this.bsiRecordsCount).set_Caption("RECORDS : 0");
      ((BarItem) this.bsiRecordsCount).set_Id(15);
      ((BarItem) this.bsiRecordsCount).set_Name("bsiRecordsCount");
      ((BarItem) this.bbiRefresh).set_Caption("Refresh");
      ((BarItem) this.bbiRefresh).set_Id(19);
      ((ImageOptions) ((BarItem) this.bbiRefresh).get_ImageOptions()).get_ImageUri().set_Uri("Refresh");
      ((BarItem) this.bbiRefresh).set_Name("bbiRefresh");
      ((BarItem) this.btnStudentPrint).set_Caption("طباعة طالب");
      ((BarItem) this.btnStudentPrint).set_Id(20);
      ((BarItem) this.btnStudentPrint).set_Name("btnStudentPrint");
      // ISSUE: method pointer
      ((BarItem) this.btnStudentPrint).add_ItemClick(new ItemClickEventHandler((object) this, __methodptr(btnStudentPrint_ItemClick)));
      this.ribbonPage1.get_Groups().AddRange(new RibbonPageGroup[2]
      {
        this.ribbonPageGroup1,
        this.ribbonPageGroup2
      });
      this.ribbonPage1.set_MergeOrder(0);
      this.ribbonPage1.set_Name("ribbonPage1");
      this.ribbonPage1.set_Text("طباعة البطاقات");
      this.ribbonPageGroup1.set_AllowTextClipping(false);
      this.ribbonPageGroup1.set_CaptionButtonVisible((DefaultBoolean) 1);
      ((BarItemLinkCollection) this.ribbonPageGroup1.get_ItemLinks()).Add((BarItem) this.bbiRefresh);
      this.ribbonPageGroup1.set_Name("ribbonPageGroup1");
      this.ribbonPageGroup1.set_Text("Tasks");
      this.ribbonPageGroup2.set_AllowTextClipping(false);
      this.ribbonPageGroup2.set_CaptionButtonVisible((DefaultBoolean) 1);
      ((BarItemLinkCollection) this.ribbonPageGroup2.get_ItemLinks()).Add((BarItem) this.btnPrintAll);
      ((BarItemLinkCollection) this.ribbonPageGroup2.get_ItemLinks()).Add((BarItem) this.btnStudentPrint);
      this.ribbonPageGroup2.set_Name("ribbonPageGroup2");
      this.ribbonPageGroup2.set_Text("Print and Export");
      this.ribbonStatusBar.get_ItemLinks().Add((BarItem) this.bsiRecordsCount);
      ((Control) this.ribbonStatusBar).Location = new Point(0, 616);
      ((Control) this.ribbonStatusBar).Name = "ribbonStatusBar";
      this.ribbonStatusBar.set_Ribbon(this.ribbonControl);
      ((Control) this.ribbonStatusBar).Size = new Size(1147, 24);
      ((BaseView) this.gridView1).set_GridControl(this.gridControl);
      ((BaseView) this.gridView1).set_Name("gridView1");
      ((Control) this.gridSplitContainer1).Dock = DockStyle.Fill;
      this.gridSplitContainer1.set_Grid(this.gridControl);
      ((Control) this.gridSplitContainer1).Location = new Point(0, 158);
      ((Control) this.gridSplitContainer1).Name = "gridSplitContainer1";
      ((Control) ((SplitContainerControl) this.gridSplitContainer1).get_Panel1()).Controls.Add((Control) this.gridControl);
      ((Control) this.gridSplitContainer1).Size = new Size(1147, 482);
      ((Control) this.gridSplitContainer1).TabIndex = 4;
      this.ribbonPage4.set_Name("ribbonPage4");
      this.ribbonPage4.set_Text("ribbonPage4");
      this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Form) this).ClientSize = new Size(1147, 640);
      ((Control) this).Controls.Add((Control) this.ribbonStatusBar);
      ((Control) this).Controls.Add((Control) this.gridSplitContainer1);
      ((Control) this).Controls.Add((Control) this.ribbonControl);
      ((Control) this).Name = nameof (Form1);
      this.set_Ribbon(this.ribbonControl);
      ((Control) this).RightToLeft = RightToLeft.Yes;
      ((Form) this).RightToLeftLayout = true;
      this.set_StatusBar(this.ribbonStatusBar);
      ((ISupportInitialize) this.gridControl).EndInit();
      ((ISupportInitialize) this.gridView).EndInit();
      ((ISupportInitialize) this.ribbonControl).EndInit();
      ((ISupportInitialize) this.gridView1).EndInit();
      ((ISupportInitialize) this.gridSplitContainer1).EndInit();
      ((Control) this.gridSplitContainer1).ResumeLayout(false);
      ((XtraForm) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }
  }
}
