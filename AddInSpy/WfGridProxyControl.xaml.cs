﻿// Decompiled with JetBrains decompiler
// Type: AddInSpy.WfGridProxyControl
// Assembly: AddInSpy, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 348DAB18-01AB-4E5E-BAAD-807E7B0E72BC
// Assembly location: C:\Users\Jozef\Downloads\AddInSpy\AddInSpy.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Markup;

namespace AddInSpy
{
  public partial class WfGridProxyControl : UserControl, IComponentConnector
  {
    internal WindowsFormsHost wfHost;
    internal AddInGridControl addInGridControl;
    private bool _contentLoaded;

    public WfGridProxyControl()
    {
      this.InitializeComponent();
    }

    protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
    {
      base.OnRenderSizeChanged(sizeInfo);
      int num1 = 0;
      int num2 = 12;
      if (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor == 1)
      {
        num1 = (int) (SystemParameters.VerticalScrollBarWidth * 0.75);
        num2 = (int) (SystemParameters.HorizontalScrollBarHeight * 1.5);
      }
      this.wfHost.Width = sizeInfo.NewSize.Width - 2.0 * SystemParameters.ResizeFrameVerticalBorderWidth + SystemParameters.VerticalScrollBarWidth - (double) num1;
      this.wfHost.Height = sizeInfo.NewSize.Height - 2.0 * SystemParameters.ResizeFrameHorizontalBorderHeight - SystemParameters.HorizontalScrollBarHeight - (double) num2;
    }

    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/AddInSpy;component/wfgridproxycontrol.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.wfHost = (WindowsFormsHost) target;
          break;
        case 2:
          this.addInGridControl = (AddInGridControl) target;
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
