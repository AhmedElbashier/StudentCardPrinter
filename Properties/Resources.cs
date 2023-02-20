// Decompiled with JetBrains decompiler
// Type: CardPrinter.Properties.Resources
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CardPrinter.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (CardPrinter.Properties.Resources.resourceMan == null)
          CardPrinter.Properties.Resources.resourceMan = new ResourceManager("CardPrinter.Properties.Resources", typeof (CardPrinter.Properties.Resources).Assembly);
        return CardPrinter.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => CardPrinter.Properties.Resources.resourceCulture;
      set => CardPrinter.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap devenv_5A0sJN0pUM => (Bitmap) CardPrinter.Properties.Resources.ResourceManager.GetObject(nameof (devenv_5A0sJN0pUM), CardPrinter.Properties.Resources.resourceCulture);
  }
}
