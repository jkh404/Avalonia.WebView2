﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2GetFaviconCompletedHandler
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core.Raw
{
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("A2508329-7DA8-49D7-8C05-FA125E4AEE8D")]
  [TypeIdentifier]
  [ComImport]
  public interface ICoreWebView2GetFaviconCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.Interface), In] IStream faviconStream);
  }
}
